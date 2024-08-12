using System.Data;

namespace PhoneBook
{
    public partial class MainScreen : Form
    {
        private DataSet ds = new DataSet();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void listItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblLastOperationInfo_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void menuNewItem_Click(object sender, EventArgs e)
        {
            frmNewItem newItem = new frmNewItem();
            DialogResult res = newItem.ShowDialog();

            if (res == DialogResult.OK) // they pressed Save
            {
                Person newPerson = newItem.NewPerson;

                DataTable dt = this.dataGridView.DataSource as DataTable;

                DataRow dr = dt.NewRow();
                dr[0] = newPerson.Id;
                dr[1] = newPerson.Name;
                dr[2] = newPerson.Surname;
                dr[3] = newPerson.TelephoneNo;

                dt.Rows.Add(dr);
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable("Contacts");

            //DataColumn dcId = new DataColumn("ID");
            //DataColumn dcName = new DataColumn("Name");
            //DataColumn dcSurname = new DataColumn("Surname");
            //DataColumn dcPhoneNo = new DataColumn("Telephone No.");

            //dt.Columns.Add(dcId);
            //dt.Columns.Add(dcName);
            //dt.Columns.Add(dcSurname);
            //dt.Columns.Add(dcPhoneNo);

            //ds.Tables.Add(dt);

            //this.dataGridView.DataSource = dt;

            ds.Tables.Clear();
            ds.ReadXml(Application.StartupPath + "\\" + "data.xml", XmlReadMode.ReadSchema);

            if(ds.Tables.Count > 0)
            {
                this.dataGridView.DataSource = ds.Tables[0];
            }
        }

        private void menuEditItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.CurrentRow != null)
            {
                frmEditItem editItem = new frmEditItem();

                editItem.EdittedPerson = new Person();
                editItem.EdittedPerson.Name = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
                editItem.EdittedPerson.Surname = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
                editItem.EdittedPerson.TelephoneNo = this.dataGridView.CurrentRow.Cells[3].Value.ToString();

                DialogResult res = editItem.ShowDialog();

                if (res == DialogResult.OK)
                {
                    DataRow dr = (this.dataGridView.CurrentRow.DataBoundItem as DataRowView).Row;
                    dr[1] = editItem.EdittedPerson.Name;
                    dr[2] = editItem.EdittedPerson.Surname;
                    dr[3] = editItem.EdittedPerson.TelephoneNo;
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.CurrentRow != null)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete the selected item?", "Delete Item", MessageBoxButtons.YesNoCancel);

                if (res == DialogResult.Yes)
                {
                    DataRow dr = (this.dataGridView.CurrentRow.DataBoundItem as DataRowView).Row;

                    dr.Delete();
                }
            }


        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            ds.WriteXml(Application.StartupPath + "\\" + "data.xml", XmlWriteMode.WriteSchema);
        }
    }
}
