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
using System.Data.SqlClient;

namespace SnowLeopard
{
    public partial class Main : Skin_Color
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var dtPlan = DalProxy.Sql.GetDataTableBySP("spTimer_GetCheckPlan", new SqlParameter[0]);
                dtPlan.TableName = "sys_PlatfromCheckPlanInfo";
                var sbText = new StringBuilder();
                AppendTableInfo(dtPlan, sbText);

                var dtQuestion = DalProxy.Sql.GetDataTableBySP("spTimer_GetCheckQuestion", new SqlParameter[0]);
                dtQuestion.TableName = "biz_PlatformCheckQuestionBank";
                AppendTableInfo(dtQuestion, sbText);

                Number.Text = sbText.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static void AppendTableInfo(DataTable dtPlan, StringBuilder sbText)
        {
            sbText.Append($"{dtPlan.Rows.Count.ToString()}\r\n");
            sbText.Append($"Table: {dtPlan.TableName}\r\n");
            foreach (DataColumn dc in dtPlan.Columns)
            {
                sbText.Append($"typeof {dc.ColumnName}: {dc.DataType}\r\n");
            }
            sbText.Append("\r\n");
        }
    }
}
