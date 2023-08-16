using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureBurstGUI
{
    public partial class TokensConfigForm : Form
    {
        public string token;
        public string classification;
        public string comment;
        public TokensConfigForm(TreeNode rootNode)
        {
            InitializeComponent();
            LoadDomainClassification(rootNode);
            comboBoxClassification.DropDownStyle= ComboBoxStyle.DropDownList;
        }
        private void LoadDomainClassification(TreeNode rootNode)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                this.comboBoxClassification.Items.Add(node.Text);
            }
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            token = textBoxToken.Text;
            comment= textBoxComment.Text;
            classification = comboBoxClassification.Text;

            DialogResult= DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }
    }
    
}
