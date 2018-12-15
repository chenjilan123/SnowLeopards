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
using System.Diagnostics;

namespace SnowLeopard
{
    public partial class Main : Skin_Color
    {
        public Main()
        {
            InitializeComponent();
        }

        private List<Model> GenerateList()
        {
            var lst = new List<Model>() {
                new Model(5, "Jack", 150.01M),
                new Model(5, "Jace", 154.98M),
                new Model(5, "Mick", 154.98M),
                new Model(5, "Michael", 154.98M),
                new Model(5, "Mark", 154.98M),
                new Model(8, "Jane", 50.50M),
                new Model(8, "Emerb", 99.01M),
                new Model(8, "Gador", 100.99M),
                new Model(19, "Gao", 978.05M),
                new Model(19, "Gace", 978.05M),
            };
            var lstReturn = new List<Model>();
            for (int i = 0; i < 10000; i++)
            {
                lstReturn.AddRange(lst.ToArray());
            }
            //100 000 记录
            //Calculate Time : 00:00:00.0851196
            //Get Result Time: 00:00:00.0035612
            //Result Length  : 3530330
            return lstReturn;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                //text.Text = GroupBySingleKey();
                var sw = Stopwatch.StartNew();
                text.Text = GroupByMultipleKey();
                sw.Stop();
                MessageBox.Show($"Print result time: {sw.Elapsed}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private string GroupByMultipleKey()
        {
            List<Model> lst = GenerateList();
            var sb = new StringBuilder();

            var sw = Stopwatch.StartNew();
            var queryTypes = from m in lst
                             group m by new { Type = m.Type, FirstName = m.Name[0] } into g
                             select g;
            foreach (var typeGroup in queryTypes)
            {
                var point = typeGroup.Sum(m => m.Value);
                sb.Append($"Type : {typeGroup.Key.ToString()}\r\n");
                sb.Append($"Point: {point}\r\n");
                foreach (var model in typeGroup)
                {
                    sb.Append($"\tId: {model.Id}, Name: {model.Name}, Value: {model.Value}\r\n");
                }
            }
            var calculateElapsed = sw.Elapsed;
            sw.Restart();
            var result = sb.ToString();
            sw.Stop();

            return 
                $"Calculate Time : {calculateElapsed}\r\n" +
                $"Get Result Time: {sw.Elapsed}\r\n" +
                $"Result Length  : {result.Length}\r\n" +
                $"Result         : \r\n{result}";
        }

        private string GroupBySingleKey()
        {
            var lst = GenerateList();
            var sb = new StringBuilder();

            var queryTypes = from m in lst
                             group m by m.Type into g
                             select g;
            foreach (var typeGroup in queryTypes)
            {
                sb.Append($"Type : {typeGroup.Key.ToString()}\r\n");
                foreach (var model in typeGroup)
                {
                    sb.Append($"\tId: {model.Id}, Name: {model.Name}\r\n");
                }
            }
            return sb.ToString();
        }
    }
}
