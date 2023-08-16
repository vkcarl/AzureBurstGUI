using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureBurstGUI
{
    public partial class AddingClassificationForm : Form
    {
        public string ClassificationName;
        public string ClassificationDescription;
        public AddingClassificationForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // 获取用户输入的数据
            ClassificationName = textBoxClassName.Text;
            ClassificationDescription = textBoxClassDesc.Text;

            // 关闭对话框并返回 DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // 关闭对话框并返回 DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
