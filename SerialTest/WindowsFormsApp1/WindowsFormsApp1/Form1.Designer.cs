namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReceivePanel = new System.Windows.Forms.Panel();
            this.RecCharRadioButton = new System.Windows.Forms.RadioButton();
            this.RecHexRadioButton = new System.Windows.Forms.RadioButton();
            this.SendPanel = new System.Windows.Forms.Panel();
            this.SendCharRadioButton = new System.Windows.Forms.RadioButton();
            this.SendHexRadioButton = new System.Windows.Forms.RadioButton();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PortNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.ReceivePanel.SuspendLayout();
            this.SendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.ReceivePanel);
            this.groupBox1.Controls.Add(this.SendPanel);
            this.groupBox1.Controls.Add(this.CloseBtn);
            this.groupBox1.Controls.Add(this.OpenBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BaudRateComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PortNameComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // ReceivePanel
            // 
            this.ReceivePanel.Controls.Add(this.RecCharRadioButton);
            this.ReceivePanel.Controls.Add(this.RecHexRadioButton);
            this.ReceivePanel.Location = new System.Drawing.Point(68, 159);
            this.ReceivePanel.Name = "ReceivePanel";
            this.ReceivePanel.Size = new System.Drawing.Size(154, 36);
            this.ReceivePanel.TabIndex = 13;
            // 
            // RecCharRadioButton
            // 
            this.RecCharRadioButton.AutoSize = true;
            this.RecCharRadioButton.Location = new System.Drawing.Point(87, 12);
            this.RecCharRadioButton.Name = "RecCharRadioButton";
            this.RecCharRadioButton.Size = new System.Drawing.Size(47, 16);
            this.RecCharRadioButton.TabIndex = 2;
            this.RecCharRadioButton.Text = "字符";
            this.RecCharRadioButton.UseVisualStyleBackColor = true;
            // 
            // RecHexRadioButton
            // 
            this.RecHexRadioButton.AutoSize = true;
            this.RecHexRadioButton.Checked = true;
            this.RecHexRadioButton.Location = new System.Drawing.Point(13, 12);
            this.RecHexRadioButton.Name = "RecHexRadioButton";
            this.RecHexRadioButton.Size = new System.Drawing.Size(41, 16);
            this.RecHexRadioButton.TabIndex = 1;
            this.RecHexRadioButton.TabStop = true;
            this.RecHexRadioButton.Text = "hex";
            this.RecHexRadioButton.UseVisualStyleBackColor = true;
            // 
            // SendPanel
            // 
            this.SendPanel.Controls.Add(this.SendCharRadioButton);
            this.SendPanel.Controls.Add(this.SendHexRadioButton);
            this.SendPanel.Location = new System.Drawing.Point(68, 117);
            this.SendPanel.Name = "SendPanel";
            this.SendPanel.Size = new System.Drawing.Size(154, 36);
            this.SendPanel.TabIndex = 12;
            // 
            // SendCharRadioButton
            // 
            this.SendCharRadioButton.AutoSize = true;
            this.SendCharRadioButton.Location = new System.Drawing.Point(87, 11);
            this.SendCharRadioButton.Name = "SendCharRadioButton";
            this.SendCharRadioButton.Size = new System.Drawing.Size(47, 16);
            this.SendCharRadioButton.TabIndex = 1;
            this.SendCharRadioButton.Text = "字符";
            this.SendCharRadioButton.UseVisualStyleBackColor = true;
            // 
            // SendHexRadioButton
            // 
            this.SendHexRadioButton.AutoSize = true;
            this.SendHexRadioButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SendHexRadioButton.Checked = true;
            this.SendHexRadioButton.Location = new System.Drawing.Point(13, 11);
            this.SendHexRadioButton.Name = "SendHexRadioButton";
            this.SendHexRadioButton.Size = new System.Drawing.Size(41, 16);
            this.SendHexRadioButton.TabIndex = 0;
            this.SendHexRadioButton.TabStop = true;
            this.SendHexRadioButton.Text = "hex";
            this.SendHexRadioButton.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Enabled = false;
            this.CloseBtn.Location = new System.Drawing.Point(141, 241);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(81, 32);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Text = "关闭端口";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(11, 241);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(86, 32);
            this.OpenBtn.TabIndex = 10;
            this.OpenBtn.Text = "打开端口";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "接收格式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "发送格式";
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(81, 71);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(121, 20);
            this.BaudRateComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // PortNameComboBox
            // 
            this.PortNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNameComboBox.FormattingEnabled = true;
            this.PortNameComboBox.Location = new System.Drawing.Point(81, 24);
            this.PortNameComboBox.Name = "PortNameComboBox";
            this.PortNameComboBox.Size = new System.Drawing.Size(121, 20);
            this.PortNameComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(246, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(542, 322);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 351);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(612, 87);
            this.textBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(643, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 68);
            this.button3.TabIndex = 4;
            this.button3.Text = "发送";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 455);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SerialTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ReceivePanel.ResumeLayout(false);
            this.ReceivePanel.PerformLayout();
            this.SendPanel.ResumeLayout(false);
            this.SendPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PortNameComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel ReceivePanel;
        private System.Windows.Forms.Panel SendPanel;
        private System.Windows.Forms.RadioButton SendHexRadioButton;
        private System.Windows.Forms.RadioButton RecCharRadioButton;
        private System.Windows.Forms.RadioButton RecHexRadioButton;
        private System.Windows.Forms.RadioButton SendCharRadioButton;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

