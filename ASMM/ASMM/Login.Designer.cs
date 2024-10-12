namespace ASMM
{
    partial class Login
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
            this.btcreate = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblcf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcf = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btcreate
            // 
            this.btcreate.Location = new System.Drawing.Point(806, 306);
            this.btcreate.Margin = new System.Windows.Forms.Padding(4);
            this.btcreate.Name = "btcreate";
            this.btcreate.Size = new System.Drawing.Size(194, 69);
            this.btcreate.TabIndex = 14;
            this.btcreate.Text = "Create Account";
            this.btcreate.UseVisualStyleBackColor = true;
            this.btcreate.Visible = false;
            this.btcreate.Click += new System.EventHandler(this.btcreate_Click);
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(806, 216);
            this.btlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(194, 69);
            this.btlogin.TabIndex = 13;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(806, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 69);
            this.button1.TabIndex = 11;
            this.button1.Text = "You do not have an account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblcf
            // 
            this.lblcf.AutoSize = true;
            this.lblcf.Location = new System.Drawing.Point(206, 355);
            this.lblcf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcf.Name = "lblcf";
            this.lblcf.Size = new System.Drawing.Size(110, 20);
            this.lblcf.TabIndex = 7;
            this.lblcf.Text = "ConFormPass";
            this.lblcf.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pass Word";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Name";
            // 
            // txtcf
            // 
            this.txtcf.Location = new System.Drawing.Point(344, 349);
            this.txtcf.Margin = new System.Windows.Forms.Padding(4);
            this.txtcf.Name = "txtcf";
            this.txtcf.PasswordChar = '*';
            this.txtcf.Size = new System.Drawing.Size(423, 26);
            this.txtcf.TabIndex = 12;
            this.txtcf.Visible = false;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(344, 296);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(423, 26);
            this.txtpass.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(344, 216);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(423, 26);
            this.txtname.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 626);
            this.Controls.Add(this.btcreate);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcf);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcreate;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblcf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcf;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
    }
}

