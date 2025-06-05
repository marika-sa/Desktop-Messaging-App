namespace DesktopMessageApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFile = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbPic = new System.Windows.Forms.RadioButton();
            this.rbAudio = new System.Windows.Forms.RadioButton();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.rbVid = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbSMS = new System.Windows.Forms.RadioButton();
            this.rbMMS = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRecipient = new System.Windows.Forms.RichTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clbMsgIn = new System.Windows.Forms.CheckedListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cblMsgOut = new System.Windows.Forms.CheckedListBox();
            this.cbxGroup = new System.Windows.Forms.CheckBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(25, 67);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(557, 214);
            this.txtText.TabIndex = 1;
            this.txtText.Tag = "Enter the message here";
            this.txtText.Text = "";
            this.txtText.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFile);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.rbPic);
            this.groupBox2.Controls.Add(this.rbAudio);
            this.groupBox2.Controls.Add(this.lblFile);
            this.groupBox2.Controls.Add(this.btnFile);
            this.groupBox2.Controls.Add(this.rbVid);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(608, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 264);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(17, 146);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(117, 25);
            this.txtFile.TabIndex = 24;
            this.txtFile.Tag = "Enter media file name";
            this.txtFile.Text = "";
            this.txtFile.Visible = false;
            this.txtFile.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(21, 186);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(110, 30);
            this.btnSend.TabIndex = 16;
            this.btnSend.Tag = "Send message";
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(21, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Tag = "Cancel the message";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // rbPic
            // 
            this.rbPic.AutoSize = true;
            this.rbPic.Checked = true;
            this.rbPic.Location = new System.Drawing.Point(18, 20);
            this.rbPic.Name = "rbPic";
            this.rbPic.Size = new System.Drawing.Size(65, 21);
            this.rbPic.TabIndex = 7;
            this.rbPic.TabStop = true;
            this.rbPic.Tag = "Picture attachment";
            this.rbPic.Text = "Picture";
            this.rbPic.UseVisualStyleBackColor = true;
            this.rbPic.Visible = false;
            this.rbPic.CheckedChanged += new System.EventHandler(this.MediaRadioButton_CheckedChanged);
            this.rbPic.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // rbAudio
            // 
            this.rbAudio.AutoSize = true;
            this.rbAudio.Location = new System.Drawing.Point(18, 48);
            this.rbAudio.Name = "rbAudio";
            this.rbAudio.Size = new System.Drawing.Size(60, 21);
            this.rbAudio.TabIndex = 8;
            this.rbAudio.Tag = "Audio attachment";
            this.rbAudio.Text = "Audio";
            this.rbAudio.UseVisualStyleBackColor = true;
            this.rbAudio.Visible = false;
            this.rbAudio.CheckedChanged += new System.EventHandler(this.MediaRadioButton_CheckedChanged);
            this.rbAudio.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(14, 120);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(65, 17);
            this.lblFile.TabIndex = 19;
            this.lblFile.Text = "Select File";
            this.lblFile.Visible = false;
            // 
            // btnFile
            // 
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.Location = new System.Drawing.Point(85, 109);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(46, 31);
            this.btnFile.TabIndex = 13;
            this.btnFile.Tag = "Search for media file";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Visible = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            this.btnFile.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // rbVid
            // 
            this.rbVid.AutoSize = true;
            this.rbVid.Location = new System.Drawing.Point(18, 77);
            this.rbVid.Name = "rbVid";
            this.rbVid.Size = new System.Drawing.Size(60, 21);
            this.rbVid.TabIndex = 18;
            this.rbVid.Tag = "Video attachment";
            this.rbVid.Text = "Video";
            this.rbVid.UseVisualStyleBackColor = true;
            this.rbVid.Visible = false;
            this.rbVid.CheckedChanged += new System.EventHandler(this.MediaRadioButton_CheckedChanged);
            this.rbVid.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recipeint ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "My Number: ";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(930, 514);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 30);
            this.btnNew.TabIndex = 10;
            this.btnNew.Tag = "New message";
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1059, 514);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Tag = "Delete a message";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // rbSMS
            // 
            this.rbSMS.AutoSize = true;
            this.rbSMS.Checked = true;
            this.rbSMS.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSMS.Location = new System.Drawing.Point(968, 562);
            this.rbSMS.Name = "rbSMS";
            this.rbSMS.Size = new System.Drawing.Size(52, 21);
            this.rbSMS.TabIndex = 16;
            this.rbSMS.TabStop = true;
            this.rbSMS.Tag = "SMS message";
            this.rbSMS.Text = "SMS";
            this.rbSMS.UseVisualStyleBackColor = true;
            this.rbSMS.CheckedChanged += new System.EventHandler(this.MessageRadioButtons_CheckedChanged);
            this.rbSMS.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // rbMMS
            // 
            this.rbMMS.AutoSize = true;
            this.rbMMS.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMMS.Location = new System.Drawing.Point(1059, 562);
            this.rbMMS.Name = "rbMMS";
            this.rbMMS.Size = new System.Drawing.Size(57, 21);
            this.rbMMS.TabIndex = 17;
            this.rbMMS.Tag = "MMS message";
            this.rbMMS.Text = "MMS";
            this.rbMMS.UseVisualStyleBackColor = true;
            this.rbMMS.CheckedChanged += new System.EventHandler(this.MessageRadioButtons_CheckedChanged);
            this.rbMMS.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1031, 613);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 43);
            this.btnExit.TabIndex = 10;
            this.btnExit.Tag = "Click to exit application";
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MediaPlayer);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(735, 362);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(3, 21);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(729, 338);
            this.MediaPlayer.TabIndex = 1;
            this.MediaPlayer.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipient.Location = new System.Drawing.Point(25, 36);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(183, 25);
            this.txtRecipient.TabIndex = 21;
            this.txtRecipient.Tag = "Enter the recipients phone number";
            this.txtRecipient.Text = "";
            this.txtRecipient.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(10, 63);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 30);
            this.btnShow.TabIndex = 17;
            this.btnShow.Tag = "Click to show media";
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Visible = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShow.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(10, 103);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 30);
            this.btnStop.TabIndex = 18;
            this.btnStop.Tag = "Click to stop media";
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(10, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 30);
            this.btnPlay.TabIndex = 19;
            this.btnPlay.Tag = "Click to play media";
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPlay);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(787, 504);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 149);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.Location = new System.Drawing.Point(490, 39);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(92, 17);
            this.lblSender.TabIndex = 24;
            this.lblSender.Text = "087456734228";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(784, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 479);
            this.tabControl1.TabIndex = 25;
            this.tabControl1.Tag = "Inbox and sent messages";
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Message_SelectedIndexChanged);
            this.tabControl1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.clbMsgIn);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(388, 449);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Inbox";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clbMsgIn
            // 
            this.clbMsgIn.CheckOnClick = true;
            this.clbMsgIn.ColumnWidth = 400;
            this.clbMsgIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbMsgIn.FormattingEnabled = true;
            this.clbMsgIn.Location = new System.Drawing.Point(2, 2);
            this.clbMsgIn.Margin = new System.Windows.Forms.Padding(2);
            this.clbMsgIn.MultiColumn = true;
            this.clbMsgIn.Name = "clbMsgIn";
            this.clbMsgIn.Size = new System.Drawing.Size(384, 445);
            this.clbMsgIn.TabIndex = 0;
            this.clbMsgIn.Tag = "Received messages";
            this.clbMsgIn.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MessageListBox_ItemCheck);
            this.clbMsgIn.SelectedIndexChanged += new System.EventHandler(this.Message_SelectedIndexChanged);
            this.clbMsgIn.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cblMsgOut);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(388, 449);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Outbox";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cblMsgOut
            // 
            this.cblMsgOut.CheckOnClick = true;
            this.cblMsgOut.ColumnWidth = 400;
            this.cblMsgOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cblMsgOut.FormattingEnabled = true;
            this.cblMsgOut.Location = new System.Drawing.Point(2, 2);
            this.cblMsgOut.Margin = new System.Windows.Forms.Padding(2);
            this.cblMsgOut.MultiColumn = true;
            this.cblMsgOut.Name = "cblMsgOut";
            this.cblMsgOut.Size = new System.Drawing.Size(384, 445);
            this.cblMsgOut.TabIndex = 1;
            this.cblMsgOut.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MessageListBox_ItemCheck);
            this.cblMsgOut.SelectedIndexChanged += new System.EventHandler(this.Message_SelectedIndexChanged);
            this.cblMsgOut.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // cbxGroup
            // 
            this.cbxGroup.AutoSize = true;
            this.cbxGroup.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGroup.Location = new System.Drawing.Point(231, 35);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(94, 21);
            this.cbxGroup.TabIndex = 26;
            this.cbxGroup.Tag = "Tick if message is a group chat";
            this.cbxGroup.Text = "Group Chat";
            this.cbxGroup.UseVisualStyleBackColor = true;
            this.cbxGroup.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblHelp.Location = new System.Drawing.Point(27, 647);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(967, 17);
            this.lblHelp.TabIndex = 27;
            this.lblHelp.Text = "Click on the ? button on the title bar and then click on any control to display h" +
    "elp for the control or click on any control and press F11 to display help for th" +
    "e control ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 668);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.cbxGroup);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rbMMS);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.rbSMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPic;
        private System.Windows.Forms.RadioButton rbAudio;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbSMS;
        private System.Windows.Forms.RadioButton rbMMS;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbVid;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtRecipient;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RichTextBox txtFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckedListBox clbMsgIn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox cblMsgOut;
        private System.Windows.Forms.CheckBox cbxGroup;
        private System.Windows.Forms.Label lblHelp;
    }
}

