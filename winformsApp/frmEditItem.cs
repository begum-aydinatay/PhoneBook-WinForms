using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class frmEditItem : Form
    {
        public Person EdittedPerson { get; set; }
        public frmEditItem()
        {
            InitializeComponent();
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            if (this.EdittedPerson != null)
            {
                this.txtBoxName.Text = this.EdittedPerson.Name;
                this.txtBoxSurname.Text = this.EdittedPerson.Surname;
                this.txtBoxNo.Text = this.EdittedPerson.TelephoneNo;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.EdittedPerson.Name = this.txtBoxName.Text;
            this.EdittedPerson.Surname = this.txtBoxSurname.Text;
            this.EdittedPerson.TelephoneNo = this.txtBoxNo.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
