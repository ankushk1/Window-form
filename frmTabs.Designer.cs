namespace TeacherStudent
{
    partial class Tabs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TeacherDetails = new System.Windows.Forms.TabPage();
            this.Back = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Addstudent = new System.Windows.Forms.TabPage();
            this.dataGridstud = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.cbx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.TeacherDetails.SuspendLayout();
            this.Addstudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridstud)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TeacherDetails);
            this.tabControl1.Controls.Add(this.Addstudent);
            this.tabControl1.Location = new System.Drawing.Point(28, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 373);
            this.tabControl1.TabIndex = 1;
            // 
            // TeacherDetails
            // 
            this.TeacherDetails.Controls.Add(this.Back);
            this.TeacherDetails.Controls.Add(this.Select);
            this.TeacherDetails.Controls.Add(this.textBox4);
            this.TeacherDetails.Controls.Add(this.textBox3);
            this.TeacherDetails.Controls.Add(this.textBox1);
            this.TeacherDetails.Controls.Add(this.label4);
            this.TeacherDetails.Controls.Add(this.label3);
            this.TeacherDetails.Controls.Add(this.label1);
            this.TeacherDetails.Location = new System.Drawing.Point(4, 22);
            this.TeacherDetails.Name = "TeacherDetails";
            this.TeacherDetails.Padding = new System.Windows.Forms.Padding(3);
            this.TeacherDetails.Size = new System.Drawing.Size(677, 347);
            this.TeacherDetails.TabIndex = 0;
            this.TeacherDetails.Text = "Teacherdetails";
            this.TeacherDetails.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(140, 256);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 9;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(12, 256);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(75, 23);
            this.Select.TabIndex = 8;
            this.Select.Text = "Submit";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departmnet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Addstudent
            // 
            this.Addstudent.Controls.Add(this.dataGridstud);
            this.Addstudent.Controls.Add(this.button2);
            this.Addstudent.Location = new System.Drawing.Point(4, 22);
            this.Addstudent.Name = "Addstudent";
            this.Addstudent.Padding = new System.Windows.Forms.Padding(3);
            this.Addstudent.Size = new System.Drawing.Size(677, 347);
            this.Addstudent.TabIndex = 1;
            this.Addstudent.Text = "Addstudent";
            this.Addstudent.UseVisualStyleBackColor = true;
            this.Addstudent.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // dataGridstud
            // 
            this.dataGridstud.AllowUserToAddRows = false;
            this.dataGridstud.AllowUserToOrderColumns = true;
            this.dataGridstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridstud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbx,
            this.Edit,
            this.Delete});
            this.dataGridstud.Location = new System.Drawing.Point(28, 132);
            this.dataGridstud.Name = "dataGridstud";
            this.dataGridstud.RowHeadersVisible = false;
            this.dataGridstud.Size = new System.Drawing.Size(607, 160);
            this.dataGridstud.TabIndex = 1;
            this.dataGridstud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridstud_CellContentClick);
            this.dataGridstud.DoubleClick += new System.EventHandler(this.DataGridstud_DoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add student Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // cbx
            // 
            this.cbx.HeaderText = "Select";
            this.cbx.Name = "cbx";
            this.cbx.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Tabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tabs";
            this.Text = "Tabs";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.TeacherDetails.ResumeLayout(false);
            this.TeacherDetails.PerformLayout();
            this.Addstudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridstud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TeacherDetails;
        private System.Windows.Forms.TabPage Addstudent;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridstud;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbx;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}