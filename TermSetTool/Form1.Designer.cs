namespace TermSetTool
{
    partial class frmTermStoreSync
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTermStoreSync));
            this.cboEnvironment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestDomain = new System.Windows.Forms.TextBox();
            this.txtDestPassword = new System.Windows.Forms.TextBox();
            this.txtDestUserID = new System.Windows.Forms.TextBox();
            this.cboDestEnvironment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGetMMSGroups = new System.Windows.Forms.Button();
            this.tvSource = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tvDestination = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // cboEnvironment
            // 
            this.cboEnvironment.FormattingEnabled = true;
            this.cboEnvironment.Items.AddRange(new object[] {
            "http://groupgovernance.cimic.com.au/ggs/governance",
            "http://uat.groupgovernance.cimic.com.au/ggs/governance",
            "http://dev.groupgovernance.cimic.com.au/ggs/governance"});
            this.cboEnvironment.Location = new System.Drawing.Point(91, 57);
            this.cboEnvironment.Name = "cboEnvironment";
            this.cboEnvironment.Size = new System.Drawing.Size(326, 21);
            this.cboEnvironment.TabIndex = 0;
            this.cboEnvironment.SelectedIndexChanged += new System.EventHandler(this.cboEnvironment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Source Domain / UserID / pwd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(240, 19);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(84, 20);
            this.txtDomain.TabIndex = 51;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(443, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(95, 20);
            this.txtPassword.TabIndex = 53;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(330, 19);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(107, 20);
            this.txtUserID.TabIndex = 52;
            // 
            // btn_Sync
            // 
            this.btn_Sync.Location = new System.Drawing.Point(417, 535);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(121, 30);
            this.btn_Sync.TabIndex = 57;
            this.btn_Sync.Text = "Sync";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Destination Domain / UserID / pwd";
            // 
            // txtDestDomain
            // 
            this.txtDestDomain.Location = new System.Drawing.Point(240, 295);
            this.txtDestDomain.Name = "txtDestDomain";
            this.txtDestDomain.Size = new System.Drawing.Size(84, 20);
            this.txtDestDomain.TabIndex = 58;
            // 
            // txtDestPassword
            // 
            this.txtDestPassword.Location = new System.Drawing.Point(443, 295);
            this.txtDestPassword.Name = "txtDestPassword";
            this.txtDestPassword.Size = new System.Drawing.Size(95, 20);
            this.txtDestPassword.TabIndex = 60;
            this.txtDestPassword.UseSystemPasswordChar = true;
            // 
            // txtDestUserID
            // 
            this.txtDestUserID.Location = new System.Drawing.Point(330, 295);
            this.txtDestUserID.Name = "txtDestUserID";
            this.txtDestUserID.Size = new System.Drawing.Size(107, 20);
            this.txtDestUserID.TabIndex = 59;
            // 
            // cboDestEnvironment
            // 
            this.cboDestEnvironment.AutoCompleteCustomSource.AddRange(new string[] {
            "http://groupgovernance.cimic.com.au/ggs/governance",
            "http://uat.groupgovernance.cimic.com.au/ggs/governance",
            "http://dev.groupgovernance.cimic.com.au/ggs/governance"});
            this.cboDestEnvironment.FormattingEnabled = true;
            this.cboDestEnvironment.Items.AddRange(new object[] {
            "http://groupgovernance.cimic.com.au/ggs/governance",
            "http://uat.groupgovernance.cimic.com.au/ggs/governance",
            "http://dev.groupgovernance.cimic.com.au/ggs/governance"});
            this.cboDestEnvironment.Location = new System.Drawing.Point(97, 325);
            this.cboDestEnvironment.Name = "cboDestEnvironment";
            this.cboDestEnvironment.Size = new System.Drawing.Size(325, 21);
            this.cboDestEnvironment.TabIndex = 62;
            this.cboDestEnvironment.SelectedIndexChanged += new System.EventHandler(this.cboDestEnvironment_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Source SP Site";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Dest SP Site";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnGetMMSGroups
            // 
            this.btnGetMMSGroups.Location = new System.Drawing.Point(423, 56);
            this.btnGetMMSGroups.Name = "btnGetMMSGroups";
            this.btnGetMMSGroups.Size = new System.Drawing.Size(115, 21);
            this.btnGetMMSGroups.TabIndex = 71;
            this.btnGetMMSGroups.Text = "Load Source Tree";
            this.btnGetMMSGroups.UseVisualStyleBackColor = true;
            this.btnGetMMSGroups.Click += new System.EventHandler(this.btnGetMMSGroups_Click);
            // 
            // tvSource
            // 
            this.tvSource.ImageIndex = 0;
            this.tvSource.ImageList = this.imageList1;
            this.tvSource.Location = new System.Drawing.Point(12, 87);
            this.tvSource.Name = "tvSource";
            this.tvSource.SelectedImageIndex = 0;
            this.tvSource.Size = new System.Drawing.Size(526, 177);
            this.tvSource.TabIndex = 72;
            this.tvSource.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvSource_BeforeSelect);
            this.tvSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvSource_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Home.ico");
            this.imageList1.Images.SetKeyName(1, "RedFolderClosed.ico");
            this.imageList1.Images.SetKeyName(2, "GreenFolderClosed.ico");
            this.imageList1.Images.SetKeyName(3, "GreenFolderOpen.ico");
            this.imageList1.Images.SetKeyName(4, "GreenFolderOpen2.bmp");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 21);
            this.button1.TabIndex = 73;
            this.button1.Text = "Load Dest Tree";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tvDestination
            // 
            this.tvDestination.ImageIndex = 0;
            this.tvDestination.ImageList = this.imageList1;
            this.tvDestination.Location = new System.Drawing.Point(12, 352);
            this.tvDestination.Name = "tvDestination";
            this.tvDestination.SelectedImageIndex = 0;
            this.tvDestination.Size = new System.Drawing.Size(526, 177);
            this.tvDestination.TabIndex = 74;
            this.tvDestination.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvDestination_BeforeSelect);
            this.tvDestination.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvDestination_MouseDown);
            // 
            // frmTermStoreSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 576);
            this.Controls.Add(this.tvDestination);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tvSource);
            this.Controls.Add(this.btnGetMMSGroups);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDestEnvironment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestDomain);
            this.Controls.Add(this.txtDestPassword);
            this.Controls.Add(this.txtDestUserID);
            this.Controls.Add(this.btn_Sync);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.cboEnvironment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTermStoreSync";
            this.Text = "TermStoreSync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEnvironment;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDomain;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDestDomain;
        public System.Windows.Forms.TextBox txtDestPassword;
        public System.Windows.Forms.TextBox txtDestUserID;
        private System.Windows.Forms.ComboBox cboDestEnvironment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGetMMSGroups;
        private System.Windows.Forms.TreeView tvSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView tvDestination;
        private System.Windows.Forms.ImageList imageList1;
    }
}

