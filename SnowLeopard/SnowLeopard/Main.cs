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
        private Dictionary<string, dynamic> _formInstances = new Dictionary<string, dynamic>();
        public Main()
        {
            InitializeComponent();
            _assembly = Assembly.Load(AssemblyName);
            var types = _assembly.GetTypes();
            foreach (var item in types)
            {
                if (item.Namespace != PrefixNamespace)
                {
                    continue;
                }
                SelectForm.Items.Add(item.Name);
            }
            SelectForm.SelectedIndex = 0;
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
                dynamic instance;
                if (_formInstances.ContainsKey(type.FullName))
                {
                    instance = _formInstances[type.FullName];
                }
                else
                {
                    instance = _assembly.CreateInstance(type.FullName);
                    _formInstances[type.FullName] = instance;
                }
                if (null != Application.OpenForms[instance.Name])
                {
                    instance.BringToFront();
                }
                else
                {
                    instance = _assembly.CreateInstance(type.FullName);
                    _formInstances[type.FullName] = instance;
                    instance.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
