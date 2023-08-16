using System.Drawing;

namespace AzureBurstGUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnSave;
            this.button1 = new System.Windows.Forms.Button();
            this.textScriptPath = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textSavePath = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabFunction = new System.Windows.Forms.TabControl();
            this.tabGatherInfo = new System.Windows.Forms.TabPage();
            this.tabLateralMove = new System.Windows.Forms.TabPage();
            this.tabRCE = new System.Windows.Forms.TabPage();
            this.tabGetCredential = new System.Windows.Forms.TabPage();
            btnSave = new System.Windows.Forms.Button();
            this.tabFunction.SuspendLayout();
            this.tabGatherInfo.SuspendLayout();
            this.tabLateralMove.SuspendLayout();
            this.tabRCE.SuspendLayout();
            this.tabGetCredential.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            btnSave.Location = new System.Drawing.Point(952, 373);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(73, 35);
            btnSave.TabIndex = 19;
            btnSave.Text = "...";
            btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(this.btnSave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(952, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textScriptPath
            // 
            this.textScriptPath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textScriptPath.Location = new System.Drawing.Point(335, 324);
            this.textScriptPath.Margin = new System.Windows.Forms.Padding(4);
            this.textScriptPath.Name = "textScriptPath";
            this.textScriptPath.Size = new System.Drawing.Size(599, 35);
            this.textScriptPath.TabIndex = 1;
            this.textScriptPath.TextChanged += new System.EventHandler(this.textScriptPath_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(1079, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 330);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(196, 22);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "结果是否导出到本地";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 358);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(178, 22);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "结果是否导出到云";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(23, 387);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(160, 22);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "是否在终端输出";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textSavePath
            // 
            this.textSavePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textSavePath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textSavePath.Location = new System.Drawing.Point(335, 374);
            this.textSavePath.Name = "textSavePath";
            this.textSavePath.Size = new System.Drawing.Size(599, 35);
            this.textSavePath.TabIndex = 7;
            this.textSavePath.Text = "请输入要保存的本地路径/云存储路径（导出到本地/云）";
            this.textSavePath.TextChanged += new System.EventHandler(this.textSavePath_TextChanged);
            this.textSavePath.Enter += new System.EventHandler(this.textSavePath_Enter);
            this.textSavePath.Leave += new System.EventHandler(this.textSavePath_Leave);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(18, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(255, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "获取Azure域上的信息";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(306, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(277, 42);
            this.button5.TabIndex = 10;
            this.button5.Text = "获取Azure上的可用凭据";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(57, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(332, 42);
            this.button6.TabIndex = 11;
            this.button6.Text = "在Azure的VM上批量执行命令";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button22.Location = new System.Drawing.Point(912, 18);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(247, 42);
            this.button22.TabIndex = 15;
            this.button22.Text = "重新登录AAD";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.Location = new System.Drawing.Point(512, 18);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(327, 42);
            this.button12.TabIndex = 14;
            this.button12.Text = "导出AADConnect服务的帐密";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(426, 96);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(291, 42);
            this.button10.TabIndex = 12;
            this.button10.Text = "安装收集帐户密钥的后门";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(723, 96);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(436, 42);
            this.button7.TabIndex = 11;
            this.button7.Text = "更改AzureAD上启用同步的帐户的密码";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(18, 80);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(255, 42);
            this.button8.TabIndex = 9;
            this.button8.Text = "获取AzureAD域的信息";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(165, 15);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(338, 42);
            this.button9.TabIndex = 10;
            this.button9.Text = "获取AzureAD启用同步的帐户";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button21.Location = new System.Drawing.Point(602, 80);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(341, 42);
            this.button21.TabIndex = 17;
            this.button21.Text = "REST方式转储存储帐户的密钥";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button20.Location = new System.Drawing.Point(793, 54);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(313, 42);
            this.button20.TabIndex = 16;
            this.button20.Text = "REST方式在目标VM执行命令";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button19.Location = new System.Drawing.Point(372, 55);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(213, 42);
            this.button19.TabIndex = 15;
            this.button19.Text = "枚举ACR容器映像";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.Location = new System.Drawing.Point(191, 96);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(177, 42);
            this.button13.TabIndex = 14;
            this.button13.Text = "发送钓鱼邮件";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button14.Location = new System.Drawing.Point(43, 55);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(291, 42);
            this.button14.TabIndex = 13;
            this.button14.Text = "重置VM登录帐密";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button15.Location = new System.Drawing.Point(306, 80);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(277, 42);
            this.button15.TabIndex = 12;
            this.button15.Text = "枚举Azure子域名";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button16.Location = new System.Drawing.Point(633, 55);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(184, 42);
            this.button16.TabIndex = 11;
            this.button16.Text = "枚举存储Blob";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button17.Location = new System.Drawing.Point(602, 20);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(267, 42);
            this.button17.TabIndex = 9;
            this.button17.Text = "获取VM扩展的配置信息";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button18.Location = new System.Drawing.Point(414, 54);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(338, 42);
            this.button18.TabIndex = 10;
            this.button18.Text = "使用VM扩展功能执行指定脚本";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "执行命令：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "保存路径：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 684);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 20;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabFunction
            // 
            this.tabFunction.Controls.Add(this.tabGatherInfo);
            this.tabFunction.Controls.Add(this.tabLateralMove);
            this.tabFunction.Controls.Add(this.tabRCE);
            this.tabFunction.Controls.Add(this.tabGetCredential);
            this.tabFunction.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabFunction.Location = new System.Drawing.Point(1, 39);
            this.tabFunction.Name = "tabFunction";
            this.tabFunction.SelectedIndex = 0;
            this.tabFunction.Size = new System.Drawing.Size(1199, 203);
            this.tabFunction.TabIndex = 12;
            // 
            // tabGatherInfo
            // 
            this.tabGatherInfo.Controls.Add(this.button21);
            this.tabGatherInfo.Controls.Add(this.button8);
            this.tabGatherInfo.Controls.Add(this.button4);
            this.tabGatherInfo.Controls.Add(this.button5);
            this.tabGatherInfo.Controls.Add(this.button15);
            this.tabGatherInfo.Controls.Add(this.button17);
            this.tabGatherInfo.Location = new System.Drawing.Point(4, 34);
            this.tabGatherInfo.Name = "tabGatherInfo";
            this.tabGatherInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabGatherInfo.Size = new System.Drawing.Size(1191, 165);
            this.tabGatherInfo.TabIndex = 0;
            this.tabGatherInfo.Text = "信息收集";
            this.tabGatherInfo.UseVisualStyleBackColor = true;
            // 
            // tabLateralMove
            // 
            this.tabLateralMove.Controls.Add(this.button14);
            this.tabLateralMove.Controls.Add(this.button19);
            this.tabLateralMove.Controls.Add(this.button16);
            this.tabLateralMove.Location = new System.Drawing.Point(4, 34);
            this.tabLateralMove.Name = "tabLateralMove";
            this.tabLateralMove.Padding = new System.Windows.Forms.Padding(3);
            this.tabLateralMove.Size = new System.Drawing.Size(1191, 165);
            this.tabLateralMove.TabIndex = 1;
            this.tabLateralMove.Text = "横向";
            this.tabLateralMove.UseVisualStyleBackColor = true;
            // 
            // tabRCE
            // 
            this.tabRCE.Controls.Add(this.button6);
            this.tabRCE.Controls.Add(this.button20);
            this.tabRCE.Controls.Add(this.button18);
            this.tabRCE.Location = new System.Drawing.Point(4, 34);
            this.tabRCE.Name = "tabRCE";
            this.tabRCE.Padding = new System.Windows.Forms.Padding(3);
            this.tabRCE.Size = new System.Drawing.Size(1191, 165);
            this.tabRCE.TabIndex = 2;
            this.tabRCE.Text = "远程执行";
            this.tabRCE.UseVisualStyleBackColor = true;
            // 
            // tabGetCredential
            // 
            this.tabGetCredential.Controls.Add(this.button7);
            this.tabGetCredential.Controls.Add(this.button10);
            this.tabGetCredential.Controls.Add(this.button13);
            this.tabGetCredential.Controls.Add(this.button22);
            this.tabGetCredential.Controls.Add(this.button9);
            this.tabGetCredential.Controls.Add(this.button12);
            this.tabGetCredential.Location = new System.Drawing.Point(4, 34);
            this.tabGetCredential.Name = "tabGetCredential";
            this.tabGetCredential.Padding = new System.Windows.Forms.Padding(3);
            this.tabGetCredential.Size = new System.Drawing.Size(1191, 165);
            this.tabGetCredential.TabIndex = 3;
            this.tabGetCredential.Text = "获取AAD帐密/token";
            this.tabGetCredential.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 462);
            this.Controls.Add(this.tabFunction);
            this.Controls.Add(this.label6);
            this.Controls.Add(btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSavePath);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textScriptPath);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabFunction.ResumeLayout(false);
            this.tabGatherInfo.ResumeLayout(false);
            this.tabLateralMove.ResumeLayout(false);
            this.tabRCE.ResumeLayout(false);
            this.tabGetCredential.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textScriptPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textSavePath;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TabControl tabFunction;
        private System.Windows.Forms.TabPage tabGatherInfo;
        private System.Windows.Forms.TabPage tabLateralMove;
        private System.Windows.Forms.TabPage tabRCE;
        private System.Windows.Forms.TabPage tabGetCredential;
    }
}

