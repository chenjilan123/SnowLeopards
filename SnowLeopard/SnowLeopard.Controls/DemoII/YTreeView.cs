using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoII
{
    public partial class YTreeView : BlueForm
    {
        private readonly TreeView[] trees = null;
        public YTreeView()
        {
            InitializeComponent();
            trees = new[]
            {
                treeView1,
                treeView2,
            };
            //控件未创建句柄时，可以异步加载
            InitTree();
        }

        private async void InitTree()
        {
            await Task.Run(() =>
            {
                foreach (var tree in trees)
                {
                    InitTree(tree);
                }
            });
        }

        private void YTreeView_Load(object sender, EventArgs e)
        {

        }

        private void InitTree(TreeView tree)
        {
            tree.Nodes.Add(new TreeNode() { Text = "Root", Name = "Root" });

            AddChild((TreeNode)tree.Nodes[0], 5);
        }

        private void AddChild(TreeNode node, int count)
        {
            while (count-- > 0)
            {
                node.Nodes.Add($"{node.Name}_{count}");
            }
        }
    }
}
