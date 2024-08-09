namespace PhoneBook
{
    partial class frmNewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewItem));
            label1 = new Label();
            txtBoxName = new TextBox();
            txtBoxSurname = new TextBox();
            label2 = new Label();
            txtBoxNo = new TextBox();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.Location = new Point(53, 65);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(257, 36);
            txtBoxName.TabIndex = 1;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSurname.Location = new Point(53, 159);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(257, 36);
            txtBoxSurname.TabIndex = 3;
            txtBoxSurname.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 136);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // txtBoxNo
            // 
            txtBoxNo.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNo.Location = new Point(53, 252);
            txtBoxNo.Name = "txtBoxNo";
            txtBoxNo.Size = new Size(257, 36);
            txtBoxNo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 229);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 4;
            label3.Text = "Telephone No.";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(149, 332);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(249, 332);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmNewItem
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
            MaximizeBox = false;
            Name = "frmNewItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Item Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxName;
        private TextBox txtBoxSurname;
        private Label label2;
        private TextBox txtBoxNo;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
    }
}