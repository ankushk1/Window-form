using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherStudent
{
    enum GridColumnEdit { Edit ,Delete};
    public partial class TeacherDetails : Form
    {
        public int id = 0;
        Tabs obj = new Tabs();
        public TeacherDetails()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            BindingSource bind = new BindingSource();
            bind.DataSource = Tabs.store;

            dataGridtechr.DataSource = bind;
            dataGridtechr.Columns["Id"].Visible = false;

        }
        private void Button1_Click(object sender, EventArgs e)
        {
          obj.Show();
          this.Hide();
        }

        private void mbox()
        {
            string message = "Do you want to Delete";
            string title = "Delete Data";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;


            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Tabs.store.RemoveAll(i => i.Id == id);

                dataGridtechr.DataSource = false;
                BindGrid();
            }
            else if (result == DialogResult.No)
            {

            }
        }
        private void DataGridtechr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridtechr.Rows[e.RowIndex].Cells["Id"].Value);

                if (dataGridtechr.Columns[e.ColumnIndex].Name == GridColumnEdit.Edit.ToString())
                {
                    Tabs obj = new Tabs(id);

                    this.Hide();

                }
                else if (dataGridtechr.Columns[e.ColumnIndex].Name == GridColumnEdit.Delete.ToString())
                {

                    mbox();

                }
            }
            catch
            {

            }
        }
    }
}
