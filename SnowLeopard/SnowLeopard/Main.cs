using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CCWin.SkinControl;
using SnowLeopard.Controls;

namespace SnowLeopard
{
    public partial class Main : Skin_Color
    {
        private const string TargetAssemblyName = "SnowLeopard.Controls";
        string[] arrNamespace = new String[]
        {
                "SnowLeopard.Controls.Demo",
                "SnowLeopard.Controls.DemoI",
                "SnowLeopard.Controls.DemoII",
        };
        SkinComboBox[] arrCombo = null;
        private Assembly _assembly = null;
        private Dictionary<string, dynamic> _formInstances = new Dictionary<string, dynamic>();
        public Main(string openForm)
        {
            InitializeComponent();
            //this.ShowInTaskbar = false; //这样缩小化后会找不到。
            arrCombo = new SkinComboBox[]
            {
                combo1,
                combo2,
                combo3,
            };
            for (int i = 0; i < arrNamespace.Length; i++)
            {
                LoadControls(arrNamespace[i], arrCombo[i]);
            }

            ShowDefaultOpenForm(openForm);
        }

        private void ShowDefaultOpenForm(string openForm)
        {
            for (int i = 0; i < arrCombo.Length; i++)
            {
                var combo = arrCombo[i];
                foreach (var item in combo.Items)
                {
                    if (item.ToString() == openForm)
                    {
                        CreateForm(i, openForm);
                        return;
                    }
                }
            }
        }

        const int WS_EX_NOACTIVATE = 0x08000000;
        //重载Form的CreateParams属性，添加不获取焦点属性值。
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_NOACTIVATE;
                return cp;
            }
        }
        private void LoadControls(string sNamespace, SkinComboBox combo)
        {
            if (_assembly == null)
            {
                _assembly = Assembly.Load(TargetAssemblyName);
            }
            var types = _assembly.GetTypes();
            foreach (var item in types)
            {
                if (item.Namespace != sNamespace)
                {
                    continue;
                }
                //过滤特殊类型(SystemInfo...，<c>...（内部建造的异步类？）)
                if (item.BaseType != typeof(BlueForm) && item.BaseType != typeof(Form))
                {
                    continue;
                }
                combo.Items.Add(item.Name);
            }
            combo.SelectedIndex = 0;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                var number = button.Name.Substring(button.Name.Length - 1);
                int index = int.Parse(number.ToString()) - 1;
                CreateForm(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CreateForm(int index, string openForm = "")
        {
            CreateForm(arrNamespace[index], arrCombo[index], openForm);
            if (isMinimization.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void CreateForm(string prefixNamespace, SkinComboBox combo, string openForm)
        {
            var typeName = prefixNamespace + "." + (string.IsNullOrEmpty(openForm) ? combo.SelectedItem.ToString() : openForm);//$"{prefixNamespace}.{combo.SelectedItem.ToString()}";
            var type = _assembly.GetType(typeName);
            if (type == null)
            {
                MessageBox.Show("Current selected item is invalid.");
                return;
            }
            dynamic instance;
            bool bIsCreated = false;
            if (_formInstances.ContainsKey(type.FullName))
            {
                instance = _formInstances[type.FullName];
            }
            else
            {
                bIsCreated = true;
                instance = _assembly.CreateInstance(type.FullName);
                _formInstances[type.FullName] = instance;
            }
            if (instance.Name == "MenuContext")
            {
                instance.Name = "frmMenuContext";
            }
            if (null != Application.OpenForms[instance.Name])
            {
                instance.BringToFront();
            }
            else
            {
                if (!bIsCreated)
                {
                    instance = _assembly.CreateInstance(type.FullName);
                    _formInstances[type.FullName] = instance;
                }
                instance.Show();
            }
        }
    }
}
