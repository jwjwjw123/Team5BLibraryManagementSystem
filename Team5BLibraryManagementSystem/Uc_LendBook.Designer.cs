﻿namespace Team5BLibraryManagementSystem
{
    partial class Uc_LendBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.date_Due = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_Issue = new System.Windows.Forms.DateTimePicker();
            this.textbox_BookID = new System.Windows.Forms.TextBox();
            this.textbox_MemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butLend = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(165, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Memember ID";
            // 
            // date_Due
            // 
            this.date_Due.Enabled = false;
            this.date_Due.Location = new System.Drawing.Point(282, 176);
            this.date_Due.Name = "date_Due";
            this.date_Due.Size = new System.Drawing.Size(200, 21);
            this.date_Due.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(165, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(165, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Date Of Issue";
            // 
            // date_Issue
            // 
            this.date_Issue.Enabled = false;
            this.date_Issue.Location = new System.Drawing.Point(282, 137);
            this.date_Issue.Name = "date_Issue";
            this.date_Issue.Size = new System.Drawing.Size(200, 21);
            this.date_Issue.TabIndex = 3;
            this.date_Issue.ValueChanged += new System.EventHandler(this.date_Issue_ValueChanged);
            // 
            // textbox_BookID
            // 
            this.textbox_BookID.Location = new System.Drawing.Point(282, 98);
            this.textbox_BookID.Name = "textbox_BookID";
            this.textbox_BookID.Size = new System.Drawing.Size(100, 21);
            this.textbox_BookID.TabIndex = 2;
            // 
            // textbox_MemberID
            // 
            this.textbox_MemberID.Location = new System.Drawing.Point(282, 59);
            this.textbox_MemberID.Name = "textbox_MemberID";
            this.textbox_MemberID.Size = new System.Drawing.Size(100, 21);
            this.textbox_MemberID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(165, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Book ID";
            // 
            // butLend
            // 
            this.butLend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butLend.Location = new System.Drawing.Point(282, 215);
            this.butLend.Name = "butLend";
            this.butLend.Size = new System.Drawing.Size(75, 23);
            this.butLend.TabIndex = 5;
            this.butLend.Text = "Lend";
            this.butLend.UseVisualStyleBackColor = true;
            this.butLend.Click += new System.EventHandler(this.butLend_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(164, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 24);
            this.label9.TabIndex = 66;
            this.label9.Text = "Member Registration Form";
            // 
            // Uc_LendBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_Due);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_Issue);
            this.Controls.Add(this.textbox_BookID);
            this.Controls.Add(this.textbox_MemberID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butLend);
            this.Name = "Uc_LendBook";
            this.Size = new System.Drawing.Size(588, 310);
            this.Load += new System.EventHandler(this.Uc_LendBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_Due;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_Issue;
        private System.Windows.Forms.TextBox textbox_BookID;
        private System.Windows.Forms.TextBox textbox_MemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butLend;
        private System.Windows.Forms.Label label9;
    }
}
