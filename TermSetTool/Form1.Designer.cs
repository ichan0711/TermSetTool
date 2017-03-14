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
            this.cboEnvironment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.cboMMSGroup = new System.Windows.Forms.ComboBox();
            this.cboMMSTermSet = new System.Windows.Forms.ComboBox();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestDomain = new System.Windows.Forms.TextBox();
            this.txtDestPassword = new System.Windows.Forms.TextBox();
            this.txtDestUserID = new System.Windows.Forms.TextBox();
            this.cboDestMMSTermSet = new System.Windows.Forms.ComboBox();
            this.cboDestMMSGroup = new System.Windows.Forms.ComboBox();
            this.cboDestEnvironment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboEnvironment
            // 
            this.cboEnvironment.FormattingEnabled = true;
            this.cboEnvironment.Items.AddRange(new object[] {
            "http://groupgovernance.cimic.com.au/ggs/governance",
            "http://uat.groupgovernance.cimic.com.au/ggs/governance",
            "http://dev.groupgovernance.cimic.com.au/ggs/governance"});
            this.cboEnvironment.Location = new System.Drawing.Point(147, 115);
            this.cboEnvironment.Name = "cboEnvironment";
            this.cboEnvironment.Size = new System.Drawing.Size(542, 21);
            this.cboEnvironment.TabIndex = 0;
            this.cboEnvironment.SelectedIndexChanged += new System.EventHandler(this.cboEnvironment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Source Domain / UserID / pwd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(423, 28);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(52, 20);
            this.txtDomain.TabIndex = 51;
            this.txtDomain.Text = "CIMIC";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(594, 28);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(95, 20);
            this.txtPassword.TabIndex = 53;
            this.txtPassword.Text = "cimic@123";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(481, 28);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(107, 20);
            this.txtUserID.TabIndex = 52;
            this.txtUserID.Text = "svc_spadminprod";
            // 
            // cboMMSGroup
            // 
            this.cboMMSGroup.FormattingEnabled = true;
            this.cboMMSGroup.Location = new System.Drawing.Point(147, 151);
            this.cboMMSGroup.Name = "cboMMSGroup";
            this.cboMMSGroup.Size = new System.Drawing.Size(542, 21);
            this.cboMMSGroup.TabIndex = 55;
            this.cboMMSGroup.SelectedIndexChanged += new System.EventHandler(this.cboMMSGroup_SelectedIndexChanged);
            // 
            // cboMMSTermSet
            // 
            this.cboMMSTermSet.FormattingEnabled = true;
            this.cboMMSTermSet.Location = new System.Drawing.Point(147, 187);
            this.cboMMSTermSet.Name = "cboMMSTermSet";
            this.cboMMSTermSet.Size = new System.Drawing.Size(542, 21);
            this.cboMMSTermSet.TabIndex = 56;
            // 
            // btn_Sync
            // 
            this.btn_Sync.Location = new System.Drawing.Point(12, 22);
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
            this.label2.Location = new System.Drawing.Point(243, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Destination Domain / UserID / pwd";
            // 
            // txtDestDomain
            // 
            this.txtDestDomain.Location = new System.Drawing.Point(423, 231);
            this.txtDestDomain.Name = "txtDestDomain";
            this.txtDestDomain.Size = new System.Drawing.Size(52, 20);
            this.txtDestDomain.TabIndex = 58;
            this.txtDestDomain.Text = "CIMIC";
            // 
            // txtDestPassword
            // 
            this.txtDestPassword.Location = new System.Drawing.Point(594, 231);
            this.txtDestPassword.Name = "txtDestPassword";
            this.txtDestPassword.Size = new System.Drawing.Size(95, 20);
            this.txtDestPassword.TabIndex = 60;
            this.txtDestPassword.Text = "cimic@123";
            this.txtDestPassword.UseSystemPasswordChar = true;
            // 
            // txtDestUserID
            // 
            this.txtDestUserID.Location = new System.Drawing.Point(481, 231);
            this.txtDestUserID.Name = "txtDestUserID";
            this.txtDestUserID.Size = new System.Drawing.Size(107, 20);
            this.txtDestUserID.TabIndex = 59;
            this.txtDestUserID.Text = "svc_spadmin_uat";
            // 
            // cboDestMMSTermSet
            // 
            this.cboDestMMSTermSet.FormattingEnabled = true;
            this.cboDestMMSTermSet.Location = new System.Drawing.Point(148, 329);
            this.cboDestMMSTermSet.Name = "cboDestMMSTermSet";
            this.cboDestMMSTermSet.Size = new System.Drawing.Size(542, 21);
            this.cboDestMMSTermSet.TabIndex = 64;
            // 
            // cboDestMMSGroup
            // 
            this.cboDestMMSGroup.FormattingEnabled = true;
            this.cboDestMMSGroup.Location = new System.Drawing.Point(148, 293);
            this.cboDestMMSGroup.Name = "cboDestMMSGroup";
            this.cboDestMMSGroup.Size = new System.Drawing.Size(542, 21);
            this.cboDestMMSGroup.TabIndex = 63;
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
            this.cboDestEnvironment.Location = new System.Drawing.Point(148, 257);
            this.cboDestEnvironment.Name = "cboDestEnvironment";
            this.cboDestEnvironment.Size = new System.Drawing.Size(542, 21);
            this.cboDestEnvironment.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Source SP Site";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Source MMS Group";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Source MMS TermSet";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Dest MMS TermSet";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Dest MMS Group";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Dest SP Site";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmTermStoreSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 406);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDestMMSTermSet);
            this.Controls.Add(this.cboDestMMSGroup);
            this.Controls.Add(this.cboDestEnvironment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestDomain);
            this.Controls.Add(this.txtDestPassword);
            this.Controls.Add(this.txtDestUserID);
            this.Controls.Add(this.btn_Sync);
            this.Controls.Add(this.cboMMSTermSet);
            this.Controls.Add(this.cboMMSGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.cboEnvironment);
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
        private System.Windows.Forms.ComboBox cboMMSGroup;
        private System.Windows.Forms.ComboBox cboMMSTermSet;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDestDomain;
        public System.Windows.Forms.TextBox txtDestPassword;
        public System.Windows.Forms.TextBox txtDestUserID;
        private System.Windows.Forms.ComboBox cboDestMMSTermSet;
        private System.Windows.Forms.ComboBox cboDestMMSGroup;
        private System.Windows.Forms.ComboBox cboDestEnvironment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

