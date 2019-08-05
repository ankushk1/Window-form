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
   
    public partial class Tabs : Form
    {
        
        public static int AutoincIDTeachr = 0;
        public int id1 = 0;
        frmAddStudentDetails obj = new frmAddStudentDetails();
        public static int ia = 0;

        public Tabs()
        {
            InitializeComponent();
            BindGrid1();
        }
        public static List<Teacher> store = new List<Teacher>();
       
        public Tabs(int id)
        {
            ia = id;
            InitializeComponent();
            this.Disp();

        }
        public void ChangeTab(int tabIndex)
        {
            tabControl1.SelectedIndex = tabIndex;
        }
        private void Disp() 
        {
            Teacher editing = store.Where(i => i.Id == ia).FirstOrDefault();
            textBox1.Text = editing.Name;
            //textBoxID.Text = editing.Id.ToString();
            textBox3.Text = editing.Department;
            textBox4.Text = editing.Subject;


            this.Show();
        }

        private void BindGrid1()
        {
            BindingSource bind = new BindingSource();
            bind.DataSource = frmAddStudentDetails.storee;
           
            dataGridstud.DataSource = bind;

            dataGridstud.Columns["Id"].Visible = false;
            
        }
        private void EmptyBox()
        {
            textBox1.Text = null;
            //textBoxID.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
           
        }
        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {
            
  
        }
        private void mbox1()
        {
            string message = "Do you want to Delete";
            string title = "Delete Data";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;


            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                frmAddStudentDetails.storee.RemoveAll(i => i.Id == id1);

                dataGridstud.DataSource = false;
                BindGrid1();
            }
            else if (result == DialogResult.No)
            {

            }
        }
        private void DataGridstud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id1 = Convert.ToInt32(dataGridstud.Rows[e.RowIndex].Cells["Id"].Value);

                if (dataGridstud.Columns[e.ColumnIndex].Name == GridColumnEdit.Edit.ToString())
                {

                    frmAddStudentDetails obj = new frmAddStudentDetails(id1);


                    this.Hide();


                }
                else if (dataGridstud.Columns[e.ColumnIndex].Name == GridColumnEdit.Delete.ToString())
                {
                    mbox1();
                }
            }
            catch
            {

            }



        }
       

        public void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {

                AutoincIDTeachr++;
                var storeData = store.Where(i => i.Id == ia).FirstOrDefault();
                store.Remove(storeData);
                Teacher columns = new Teacher();
                columns.Name = textBox1.Text;
                columns.Id = AutoincIDTeachr;
                columns.Department = textBox3.Text;
                columns.Subject = textBox4.Text;


                store.Add(columns);

                EmptyBox();

                TeacherDetails obj = new TeacherDetails();
                obj.Show();
                ia = 0;
            }
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            obj.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void DataGridstud_DoubleClick(object sender, EventArgs e)
        {
           
          
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            TeacherDetails obj = new TeacherDetails();
            obj.Show();
            this.Hide();
        }

       
    }
}
