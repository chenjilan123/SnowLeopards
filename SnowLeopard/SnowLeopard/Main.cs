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

namespace SnowLeopard
{
    public partial class Main : Skin_Color
    {
        private const string AssemblyName = "SnowLeopard.Controls";
        private const string PrefixNamespace = "SnowLeopard.Controls.Demo";
        private Assembly _assembly = null;
        //private Dictionary<string, dynamic> _formInstances = new Dictionary<string, dynamic>();
        private Dictionary<string, Form> _formInstances = new Dictionary<string, Form>();
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.Load(AssemblyName);
            var types = _assembly.GetTypes();
            foreach (var item in types)
            {
                
                if (item.Namespace != PrefixNamespace || !item.IsSubclassOf(typeof(Form)))
                {
                    continue;
                }
                SelectForm.Items.Add(item.Name);
            }
            if (SelectForm.Items.Count > 0)
            {
                SelectForm.SelectedIndex = 0;
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var typeName = $"{PrefixNamespace}.{SelectForm.SelectedItem.ToString()}";
                var type = _assembly.GetType(typeName);
                if (type == null)
                {
                    MessageBox.Show("Current selected item is invalid.");
                    return;
                }
                Form form;
                if (_formInstances.ContainsKey(type.FullName))
                {
                    form = _formInstances[type.FullName];
                }
                else
                {
                    form = _assembly.CreateInstance(type.FullName) as Form;
                    _formInstances[type.FullName] = form;
                }
                if (null != Application.OpenForms[form.Name])
                {
                    form.BringToFront();
                }
                else
                {
                    form = _assembly.CreateInstance(type.FullName) as Form;
                    _formInstances[type.FullName] = form;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
