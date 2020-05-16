namespace SerialPortHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_SerialPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Rx = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Tx = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Link = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_SerialOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Clean = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_LeftSwitch = new System.Windows.Forms.ToolStripButton();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_AutoSendTime = new System.Windows.Forms.NumericUpDown();
            this.checkBox_AutoSend = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_SendHex = new System.Windows.Forms.RadioButton();
            this.radioButton_SendAscii = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_ShowTime = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowSend = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoEnter = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_ReceiveHex = new System.Windows.Forms.RadioButton();
            this.radioButton_ReceiveAscii = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_ControlFlow = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_StopBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_DataBit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_History = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.panel_Receive = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Receive = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip_Main.SuspendLayout();
            this.panel_Left.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AutoSendTime)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel_Receive.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit_ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.Exit_ToolStripMenuItem.Text = "退出(&Q)";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.AboutToolStripMenuItem.Text = "关于(&A)";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_SerialPortStatus,
            this.toolStripStatusLabel_Rx,
            this.toolStripStatusLabel_Tx,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_Link});
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(1017, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_SerialPortStatus
            // 
            this.toolStripStatusLabel_SerialPortStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_SerialPortStatus.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel_SerialPortStatus.Name = "toolStripStatusLabel_SerialPortStatus";
            this.toolStripStatusLabel_SerialPortStatus.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripStatusLabel_SerialPortStatus.Size = new System.Drawing.Size(137, 24);
            this.toolStripStatusLabel_SerialPortStatus.Text = "Default CLOSED";
            // 
            // toolStripStatusLabel_Rx
            // 
            this.toolStripStatusLabel_Rx.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_Rx.Name = "toolStripStatusLabel_Rx";
            this.toolStripStatusLabel_Rx.Size = new System.Drawing.Size(84, 24);
            this.toolStripStatusLabel_Rx.Text = "Rx: 0 Byte";
            // 
            // toolStripStatusLabel_Tx
            // 
            this.toolStripStatusLabel_Tx.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_Tx.Name = "toolStripStatusLabel_Tx";
            this.toolStripStatusLabel_Tx.Size = new System.Drawing.Size(83, 24);
            this.toolStripStatusLabel_Tx.Text = "Tx: 0 Byte";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(545, 24);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel_Link
            // 
            this.toolStripStatusLabel_Link.AutoToolTip = true;
            this.toolStripStatusLabel_Link.IsLink = true;
            this.toolStripStatusLabel_Link.Name = "toolStripStatusLabel_Link";
            this.toolStripStatusLabel_Link.Size = new System.Drawing.Size(153, 24);
            this.toolStripStatusLabel_Link.Text = "https://www.z10.xin";
            this.toolStripStatusLabel_Link.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel_Link.ToolTipText = "打开 https://www.z10.xin";
            this.toolStripStatusLabel_Link.Click += new System.EventHandler(this.toolStripStatusLabel_Link_Click);
            // 
            // toolStrip_Main
            // 
            this.toolStrip_Main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip_Main.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_SerialOpen,
            this.toolStripSeparator1,
            this.toolStripButton_Clean,
            this.toolStripButton_LeftSwitch});
            this.toolStrip_Main.Location = new System.Drawing.Point(0, 30);
            this.toolStrip_Main.Name = "toolStrip_Main";
            this.toolStrip_Main.Size = new System.Drawing.Size(1017, 37);
            this.toolStrip_Main.TabIndex = 2;
            this.toolStrip_Main.Text = "toolStrip1";
            // 
            // toolStripButton_SerialOpen
            // 
            this.toolStripButton_SerialOpen.CheckOnClick = true;
            this.toolStripButton_SerialOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_SerialOpen.Image = global::SerialPortHelper.Properties.Resources.icons8_broken_32px;
            this.toolStripButton_SerialOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SerialOpen.Name = "toolStripButton_SerialOpen";
            this.toolStripButton_SerialOpen.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton_SerialOpen.Text = "打开串口";
            this.toolStripButton_SerialOpen.ToolTipText = "串口: OFF";
            this.toolStripButton_SerialOpen.Click += new System.EventHandler(this.toolStripButton_SerialOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton_Clean
            // 
            this.toolStripButton_Clean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Clean.Image = global::SerialPortHelper.Properties.Resources.icons8_broom_26px;
            this.toolStripButton_Clean.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Clean.Name = "toolStripButton_Clean";
            this.toolStripButton_Clean.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton_Clean.Text = "清空接收区";
            this.toolStripButton_Clean.ToolTipText = "清空接收区";
            this.toolStripButton_Clean.Click += new System.EventHandler(this.toolStripButton_Clean_Click);
            // 
            // toolStripButton_LeftSwitch
            // 
            this.toolStripButton_LeftSwitch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_LeftSwitch.Image = global::SerialPortHelper.Properties.Resources.icons8_navigation_toolbar_left_32px;
            this.toolStripButton_LeftSwitch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_LeftSwitch.Name = "toolStripButton_LeftSwitch";
            this.toolStripButton_LeftSwitch.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton_LeftSwitch.Text = "打开左侧栏";
            this.toolStripButton_LeftSwitch.Click += new System.EventHandler(this.toolStripButton_LeftSwitch_Click);
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Left.Controls.Add(this.groupBox3);
            this.panel_Left.Controls.Add(this.groupBox2);
            this.panel_Left.Controls.Add(this.groupBox1);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 67);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Left.Size = new System.Drawing.Size(284, 608);
            this.panel_Left.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDown_AutoSendTime);
            this.groupBox3.Controls.Add(this.checkBox_AutoSend);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(5, 413);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox3.Size = new System.Drawing.Size(274, 98);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "ms";
            // 
            // numericUpDown_AutoSendTime
            // 
            this.numericUpDown_AutoSendTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_AutoSendTime.Location = new System.Drawing.Point(109, 65);
            this.numericUpDown_AutoSendTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_AutoSendTime.Name = "numericUpDown_AutoSendTime";
            this.numericUpDown_AutoSendTime.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_AutoSendTime.TabIndex = 2;
            this.numericUpDown_AutoSendTime.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // checkBox_AutoSend
            // 
            this.checkBox_AutoSend.AutoSize = true;
            this.checkBox_AutoSend.Location = new System.Drawing.Point(13, 68);
            this.checkBox_AutoSend.Name = "checkBox_AutoSend";
            this.checkBox_AutoSend.Size = new System.Drawing.Size(89, 19);
            this.checkBox_AutoSend.TabIndex = 1;
            this.checkBox_AutoSend.Text = "自动重发";
            this.checkBox_AutoSend.UseVisualStyleBackColor = true;
            this.checkBox_AutoSend.CheckedChanged += new System.EventHandler(this.checkBox_AutoSend_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton_SendHex);
            this.panel2.Controls.Add(this.radioButton_SendAscii);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(12, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 29);
            this.panel2.TabIndex = 0;
            // 
            // radioButton_SendHex
            // 
            this.radioButton_SendHex.AutoSize = true;
            this.radioButton_SendHex.Location = new System.Drawing.Point(115, 5);
            this.radioButton_SendHex.Name = "radioButton_SendHex";
            this.radioButton_SendHex.Size = new System.Drawing.Size(52, 19);
            this.radioButton_SendHex.TabIndex = 1;
            this.radioButton_SendHex.Text = "Hex";
            this.radioButton_SendHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_SendHex.UseVisualStyleBackColor = true;
            // 
            // radioButton_SendAscii
            // 
            this.radioButton_SendAscii.AutoSize = true;
            this.radioButton_SendAscii.Checked = true;
            this.radioButton_SendAscii.Location = new System.Drawing.Point(12, 5);
            this.radioButton_SendAscii.Name = "radioButton_SendAscii";
            this.radioButton_SendAscii.Size = new System.Drawing.Size(68, 19);
            this.radioButton_SendAscii.TabIndex = 0;
            this.radioButton_SendAscii.TabStop = true;
            this.radioButton_SendAscii.Text = "ASCII";
            this.radioButton_SendAscii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_SendAscii.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_ShowTime);
            this.groupBox2.Controls.Add(this.checkBox_ShowSend);
            this.groupBox2.Controls.Add(this.checkBox_AutoEnter);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(5, 250);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox2.Size = new System.Drawing.Size(274, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收设置";
            // 
            // checkBox_ShowTime
            // 
            this.checkBox_ShowTime.AutoSize = true;
            this.checkBox_ShowTime.Checked = true;
            this.checkBox_ShowTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ShowTime.Location = new System.Drawing.Point(13, 116);
            this.checkBox_ShowTime.Name = "checkBox_ShowTime";
            this.checkBox_ShowTime.Size = new System.Drawing.Size(89, 19);
            this.checkBox_ShowTime.TabIndex = 3;
            this.checkBox_ShowTime.Text = "显示时间";
            this.checkBox_ShowTime.UseVisualStyleBackColor = true;
            // 
            // checkBox_ShowSend
            // 
            this.checkBox_ShowSend.AutoSize = true;
            this.checkBox_ShowSend.Checked = true;
            this.checkBox_ShowSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ShowSend.Location = new System.Drawing.Point(13, 91);
            this.checkBox_ShowSend.Name = "checkBox_ShowSend";
            this.checkBox_ShowSend.Size = new System.Drawing.Size(89, 19);
            this.checkBox_ShowSend.TabIndex = 2;
            this.checkBox_ShowSend.Text = "显示发送";
            this.checkBox_ShowSend.UseVisualStyleBackColor = true;
            // 
            // checkBox_AutoEnter
            // 
            this.checkBox_AutoEnter.AutoSize = true;
            this.checkBox_AutoEnter.Checked = true;
            this.checkBox_AutoEnter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AutoEnter.Location = new System.Drawing.Point(13, 66);
            this.checkBox_AutoEnter.Name = "checkBox_AutoEnter";
            this.checkBox_AutoEnter.Size = new System.Drawing.Size(89, 19);
            this.checkBox_AutoEnter.TabIndex = 1;
            this.checkBox_AutoEnter.Text = "自动换行";
            this.checkBox_AutoEnter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton_ReceiveHex);
            this.panel1.Controls.Add(this.radioButton_ReceiveAscii);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 29);
            this.panel1.TabIndex = 0;
            // 
            // radioButton_ReceiveHex
            // 
            this.radioButton_ReceiveHex.AutoSize = true;
            this.radioButton_ReceiveHex.Location = new System.Drawing.Point(115, 5);
            this.radioButton_ReceiveHex.Name = "radioButton_ReceiveHex";
            this.radioButton_ReceiveHex.Size = new System.Drawing.Size(52, 19);
            this.radioButton_ReceiveHex.TabIndex = 1;
            this.radioButton_ReceiveHex.Text = "Hex";
            this.radioButton_ReceiveHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_ReceiveHex.UseVisualStyleBackColor = true;
            // 
            // radioButton_ReceiveAscii
            // 
            this.radioButton_ReceiveAscii.AutoSize = true;
            this.radioButton_ReceiveAscii.Checked = true;
            this.radioButton_ReceiveAscii.Location = new System.Drawing.Point(12, 5);
            this.radioButton_ReceiveAscii.Name = "radioButton_ReceiveAscii";
            this.radioButton_ReceiveAscii.Size = new System.Drawing.Size(68, 19);
            this.radioButton_ReceiveAscii.TabIndex = 0;
            this.radioButton_ReceiveAscii.TabStop = true;
            this.radioButton_ReceiveAscii.Text = "ASCII";
            this.radioButton_ReceiveAscii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_ReceiveAscii.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_ControlFlow);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox_StopBit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_Parity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_DataBit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_BaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // comboBox_ControlFlow
            // 
            this.comboBox_ControlFlow.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_ControlFlow.FormattingEnabled = true;
            this.comboBox_ControlFlow.Items.AddRange(new object[] {
            "None",
            "RTS/CTS",
            "XON/XOFF"});
            this.comboBox_ControlFlow.Location = new System.Drawing.Point(67, 191);
            this.comboBox_ControlFlow.Name = "comboBox_ControlFlow";
            this.comboBox_ControlFlow.Size = new System.Drawing.Size(199, 27);
            this.comboBox_ControlFlow.TabIndex = 11;
            this.comboBox_ControlFlow.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(9, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "控制流";
            // 
            // comboBox_StopBit
            // 
            this.comboBox_StopBit.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_StopBit.FormattingEnabled = true;
            this.comboBox_StopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox_StopBit.Location = new System.Drawing.Point(67, 156);
            this.comboBox_StopBit.Name = "comboBox_StopBit";
            this.comboBox_StopBit.Size = new System.Drawing.Size(199, 27);
            this.comboBox_StopBit.TabIndex = 9;
            this.comboBox_StopBit.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(9, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "停止位";
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.comboBox_Parity.Location = new System.Drawing.Point(67, 121);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(199, 27);
            this.comboBox_Parity.TabIndex = 7;
            this.comboBox_Parity.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "校验位";
            // 
            // comboBox_DataBit
            // 
            this.comboBox_DataBit.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_DataBit.FormattingEnabled = true;
            this.comboBox_DataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_DataBit.Location = new System.Drawing.Point(67, 86);
            this.comboBox_DataBit.Name = "comboBox_DataBit";
            this.comboBox_DataBit.Size = new System.Drawing.Size(199, 27);
            this.comboBox_DataBit.TabIndex = 5;
            this.comboBox_DataBit.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据位";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "195200",
            "自定义"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(69, 51);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(199, 27);
            this.comboBox_BaudRate.TabIndex = 3;
            this.comboBox_BaudRate.Text = "9600";
            this.comboBox_BaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_BaudRate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(69, 19);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(199, 27);
            this.comboBox_Port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "端    口";
            // 
            // button_Send
            // 
            this.button_Send.AutoSize = true;
            this.button_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Send.Location = new System.Drawing.Point(639, 21);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 62);
            this.button_Send.TabIndex = 5;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(284, 605);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(733, 70);
            this.panel3.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_History);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(8, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(717, 54);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送历史";
            // 
            // comboBox_History
            // 
            this.comboBox_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_History.FormattingEnabled = true;
            this.comboBox_History.Location = new System.Drawing.Point(3, 21);
            this.comboBox_History.Name = "comboBox_History";
            this.comboBox_History.Size = new System.Drawing.Size(711, 23);
            this.comboBox_History.TabIndex = 0;
            this.comboBox_History.SelectedIndexChanged += new System.EventHandler(this.comboBox_History_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(284, 503);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8);
            this.panel4.Size = new System.Drawing.Size(733, 102);
            this.panel4.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_Send);
            this.groupBox5.Controls.Add(this.button_Send);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(8, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(717, 86);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送数据";
            // 
            // textBox_Send
            // 
            this.textBox_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Send.Location = new System.Drawing.Point(6, 23);
            this.textBox_Send.Multiline = true;
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(630, 59);
            this.textBox_Send.TabIndex = 4;
            // 
            // panel_Receive
            // 
            this.panel_Receive.Controls.Add(this.groupBox6);
            this.panel_Receive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Receive.Location = new System.Drawing.Point(284, 67);
            this.panel_Receive.Name = "panel_Receive";
            this.panel_Receive.Padding = new System.Windows.Forms.Padding(8);
            this.panel_Receive.Size = new System.Drawing.Size(733, 436);
            this.panel_Receive.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBox_Receive);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(8, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox6.Size = new System.Drawing.Size(717, 420);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "接收区";
            // 
            // richTextBox_Receive
            // 
            this.richTextBox_Receive.AutoWordSelection = true;
            this.richTextBox_Receive.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox_Receive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Receive.ForeColor = System.Drawing.Color.SpringGreen;
            this.richTextBox_Receive.Location = new System.Drawing.Point(8, 26);
            this.richTextBox_Receive.Name = "richTextBox_Receive";
            this.richTextBox_Receive.ReadOnly = true;
            this.richTextBox_Receive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox_Receive.Size = new System.Drawing.Size(701, 386);
            this.richTextBox_Receive.TabIndex = 0;
            this.richTextBox_Receive.Text = "";
            this.richTextBox_Receive.TextChanged += new System.EventHandler(this.richTextBox_Receive_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1017, 705);
            this.Controls.Add(this.panel_Receive);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.toolStrip_Main);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(650, 552);
            this.Name = "Form1";
            this.Text = "串口调试助手++ | QQ: 354541796 | https://www.z10.xin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip_Main.ResumeLayout(false);
            this.toolStrip_Main.PerformLayout();
            this.panel_Left.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AutoSendTime)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel_Receive.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_SerialPortStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Rx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Tx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Link;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip_Main;
        private System.Windows.Forms.ToolStripButton toolStripButton_SerialOpen;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ControlFlow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_StopBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_DataBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_ReceiveHex;
        private System.Windows.Forms.RadioButton radioButton_ReceiveAscii;
        private System.Windows.Forms.CheckBox checkBox_ShowTime;
        private System.Windows.Forms.CheckBox checkBox_ShowSend;
        private System.Windows.Forms.CheckBox checkBox_AutoEnter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_AutoSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton_SendHex;
        private System.Windows.Forms.RadioButton radioButton_SendAscii;
        private System.Windows.Forms.NumericUpDown numericUpDown_AutoSendTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox_History;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Clean;
        private System.Windows.Forms.Panel panel_Receive;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox richTextBox_Receive;
        private System.Windows.Forms.ToolStripButton toolStripButton_LeftSwitch;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

