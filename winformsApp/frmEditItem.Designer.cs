﻿namespace PhoneBook
{
    partial class frmEditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditItem));
            btnSave = new Button();
            btnCancel = new Button();
            txtBoxNo = new TextBox();
            label3 = new Label();
            txtBoxSurname = new TextBox();
            label2 = new Label();
            txtBoxName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(252, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(152, 334);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtBoxNo
            // 
            txtBoxNo.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNo.Location = new Point(56, 254);
            txtBoxNo.Name = "txtBoxNo";
            txtBoxNo.Size = new Size(257, 36);
            txtBoxNo.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 231);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 12;
            label3.Text = "Telephone No.";
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSurname.Location = new Point(56, 161);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(257, 36);
            txtBoxSurname.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 138);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 10;
            label2.Text = "Surname";
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.Location = new Point(56, 67);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(257, 36);
            txtBoxName.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 44);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // frmEditItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 373);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtBoxNo);
            Controls.Add(label3);
            Controls.Add(txtBoxSurname);
            Controls.Add(label2);
            Controls.Add(txtBoxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEditItem";
            Text = "Edit Item Screen";
            Load += frmEditItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtBoxNo;
        private Label label3;
        private TextBox txtBoxSurname;
        private Label label2;
        private TextBox txtBoxName;
        private Label label1;
    }
}