namespace ASMM
{
    partial class Employee
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
            this.button6 = new System.Windows.Forms.Button();
            this.btseach = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtautho = new System.Windows.Forms.TextBox();
            this.txtpost = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(1388, 755);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 30);
            this.button6.TabIndex = 57;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btseach
            // 
            this.btseach.BackColor = System.Drawing.Color.White;
            this.btseach.Location = new System.Drawing.Point(144, 271);
            this.btseach.Name = "btseach";
            this.btseach.Size = new System.Drawing.Size(345, 58);
            this.btseach.TabIndex = 56;
            this.btseach.Text = "Search";
            this.btseach.UseVisualStyleBackColor = false;
            this.btseach.Click += new System.EventHandler(this.btseach_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(144, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(349, 65);
            this.button4.TabIndex = 55;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(144, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(349, 65);
            this.button3.TabIndex = 54;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(144, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(349, 65);
            this.button2.TabIndex = 53;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(942, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Authority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(748, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1113, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(527, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Employee Code";
            // 
            // txtautho
            // 
            this.txtautho.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtautho.Location = new System.Drawing.Point(891, 463);
            this.txtautho.Name = "txtautho";
            this.txtautho.Size = new System.Drawing.Size(186, 26);
            this.txtautho.TabIndex = 46;
            // 
            // txtpost
            // 
            this.txtpost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtpost.Location = new System.Drawing.Point(689, 463);
            this.txtpost.Name = "txtpost";
            this.txtpost.Size = new System.Drawing.Size(186, 26);
            this.txtpost.TabIndex = 45;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtname.Location = new System.Drawing.Point(1083, 463);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(186, 26);
            this.txtname.TabIndex = 44;
            // 
            // txtcode
            // 
            this.txtcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtcode.Location = new System.Drawing.Point(497, 463);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(186, 26);
            this.txtcode.TabIndex = 43;
            // 
            // dtgrv
            // 
            this.dtgrv.BackgroundColor = System.Drawing.Color.Gray;
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.GridColor = System.Drawing.SystemColors.Desktop;
            this.dtgrv.Location = new System.Drawing.Point(530, 40);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.RowHeadersWidth = 62;
            this.dtgrv.RowTemplate.Height = 28;
            this.dtgrv.Size = new System.Drawing.Size(666, 365);
            this.dtgrv.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(144, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 65);
            this.button1.TabIndex = 47;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 783);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btseach);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtautho);
            this.Controls.Add(this.txtpost);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.button1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btseach;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtautho;
        private System.Windows.Forms.TextBox txtpost;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.Button button1;
    }
}