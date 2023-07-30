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
    public partial class Form2 : Form
    {
        public string UserInputData;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 关闭对话框并返回 DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // 获取用户输入的数据
            UserInputData = textBoxArgument.Text;

            // 关闭对话框并返回 DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBoxArgument_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
