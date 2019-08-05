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
    public partial class frmAddStudentDetails : Form
    {
        public static int ib = 0;
        public static int AutoIncIDstud = 0;
       
        public static List<Student> storee = new List<Student>();
       
        public frmAddStudentDetails()
        {
            InitializeComponent();  
        }

        public frmAddStudentDetails(int id1)
        {
            ib = id1;
            

            InitializeComponent();
            this.Disp();

        }

        private void Disp()
        {
            
            Student editing = storee.Where(i => i.Id == ib).FirstOrDefault();
            textBox5.Text = editing.Name;
           
            textBox7.Text = editing.Department;
            textBox8.Text = editing.Subject;


            this.Show();
        }

       
        private void Button1_Click(object sender, EventArgs e)
        {

            if (textBox5.Text != null)
            {

                AutoIncIDstud++;
                var storeData = storee.Where(i => i.Id == ib).FirstOrDefault();
                storee.Remove(storeData);
                Student colmns = new Student();
                colmns.Name = textBox5.Text;
                colmns.Id = AutoIncIDstud;
                colmns.Department = textBox7.Text;
                colmns.Subject = textBox8.Text;

                storee.Add(colmns);

                Tabs obj = new Tabs();
                obj.ChangeTab(1);
                obj.Show();
                this.Hide();
            }
        }

        private void AddStudentDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Tabs obj = new Tabs();
            obj.ChangeTab(1);
            obj.Show();
            
            this.Hide();
        }
    }

}
