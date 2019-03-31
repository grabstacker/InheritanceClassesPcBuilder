namespace InheritanceProtecionModifiers
{
    partial class btnStatus
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
            this.chkPC = new System.Windows.Forms.CheckBox();
            this.chkMac = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBuildInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCurrentStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkPC
            // 
            this.chkPC.AutoSize = true;
            this.chkPC.Checked = true;
            this.chkPC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPC.Location = new System.Drawing.Point(129, 50);
            this.chkPC.Name = "chkPC";
            this.chkPC.Size = new System.Drawing.Size(40, 17);
            this.chkPC.TabIndex = 0;
            this.chkPC.Text = "PC";
            this.chkPC.UseVisualStyleBackColor = true;
            this.chkPC.CheckedChanged += new System.EventHandler(this.chkPC_CheckedChanged);
            // 
            // chkMac
            // 
            this.chkMac.AutoSize = true;
            this.chkMac.Location = new System.Drawing.Point(294, 50);
            this.chkMac.Name = "chkMac";
            this.chkMac.Size = new System.Drawing.Size(47, 17);
            this.chkMac.TabIndex = 1;
            this.chkMac.Text = "Mac";
            this.chkMac.UseVisualStyleBackColor = true;
            this.chkMac.CheckedChanged += new System.EventHandler(this.chkMac_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Budget";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(117, 125);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 5;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(117, 173);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(100, 20);
            this.txtVersion.TabIndex = 6;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(117, 230);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(100, 20);
            this.txtBudget.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(117, 273);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBuildInfo
            // 
            this.txtBuildInfo.Location = new System.Drawing.Point(399, 143);
            this.txtBuildInfo.Multiline = true;
            this.txtBuildInfo.Name = "txtBuildInfo";
            this.txtBuildInfo.Size = new System.Drawing.Size(292, 153);
            this.txtBuildInfo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Build Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Current Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCurrentStatus
            // 
            this.txtCurrentStatus.Location = new System.Drawing.Point(497, 355);
            this.txtCurrentStatus.Multiline = true;
            this.txtCurrentStatus.Name = "txtCurrentStatus";
            this.txtCurrentStatus.Size = new System.Drawing.Size(201, 72);
            this.txtCurrentStatus.TabIndex = 12;
            // 
            // btnStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCurrentStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuildInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkMac);
            this.Controls.Add(this.chkPC);
            this.Name = "btnStatus";
            this.Text = "PC Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPC;
        private System.Windows.Forms.CheckBox chkMac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBuildInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCurrentStatus;
    }
}

