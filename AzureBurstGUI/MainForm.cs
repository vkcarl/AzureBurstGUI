using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AzureBurstGUI
{
    public partial class MainForm : Form
    {
        private TreeNode selectedNode;
        private int rowIndex;
        public MainForm()
        {
            InitializeComponent();
            //
            //treeViewDomain
            //
            this.treeViewDomain.MouseClick += this.TreeViewDomain_MouseClick;
            //
            //dataGridView
            //
            this.dataGridView1.MouseDown += this.DataGridView_MouseDown;
            this.dataGridView1.RowCount = 20;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTokens_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuDomain_Opening(object sender, CancelEventArgs e)
        {

        }

        private void TreeViewDomain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 获取当前鼠标位置的节点
                selectedNode = treeViewDomain.GetNodeAt(e.X, e.Y);
                if (selectedNode != null)
                {
                    treeViewDomain.SelectedNode = selectedNode;
                }
                else
                {
                    treeViewDomain.SelectedNode = null;
                }
            }
        }

        private void 删除ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode2 = treeViewDomain.SelectedNode;
            if(selectedNode2 != null && selectedNode2 != treeViewDomain.Nodes[0])
            {
                selectedNode2.Remove();
            }

        }

        private void 新增ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //TreeNode selectedNode2 = treeViewDomain.SelectedNode;
            //if (selectedNode2 != null)
            //{
            //    // 创建一个新的子节点
            //    TreeNode newNode = new TreeNode("新的子节点");

            //    // 将新节点添加到当前选中节点的子节点中
            //    selectedNode2.Nodes.Add(newNode);

            //    // 展开当前选中节点，以显示新增的子节点
            //    selectedNode2.Expand();
            //}
            AddingClassificationForm dialogForm = new AddingClassificationForm();
            DialogResult result = dialogForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // 获取用户输入的参数
                string classificationName = dialogForm.ClassificationName;
                string classificationDescription = dialogForm.ClassificationDescription;

                // 执行相关函数,将参数拼接到命令后面
                treeViewDomain.Nodes[0].Nodes.Add(new TreeNode(classificationName));
            }

        }
        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TokensConfigForm dialogForm = new TokensConfigForm(treeViewDomain.Nodes[0]);
            DialogResult result = dialogForm.ShowDialog();
            dialogForm.Text = "编辑Token";

            if(result == DialogResult.OK)
            {

            }
        }

        private void 新增ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TokensConfigForm dialogForm = new TokensConfigForm(treeViewDomain.Nodes[0]);
            DialogResult result = dialogForm.ShowDialog();
            dialogForm.Text = "新增Token";

            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Insert(0, (dataGridView1.Rows.Count + 1).ToString(), dialogForm.token, "", DateTime.Now, "");
            }
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dataGridView1.SelectedRows;

            // 遍历选中的行
            foreach (DataGridViewRow row in selectedRow)
            {
                //// 在这里可以处理选中的行数据
                //string token = row.Cells["token"].Value.ToString();
                //string column2Value = row.Cells[""].Value.ToString();
                //string column3Value = row.Cells["列3"].Value.ToString();
                dataGridView1.Rows.Remove(row);

            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 获取当前鼠标位置的节点
                rowIndex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                // 判断是否在有效的行上点击
                if (rowIndex >= 0)
                {
                    // 取消之前的选择
                    dataGridView1.ClearSelection();

                    // 选中当前行
                    dataGridView1.Rows[rowIndex].Selected = true;
                }
            }
        }
    }
}
