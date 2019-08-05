namespace TeacherStudent
{
    partial class TeacherDetails
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
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.dataGridtechr = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtechr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDetails
            // 
            this.btnAddDetails.Location = new System.Drawing.Point(300, 88);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(119, 32);
            this.btnAddDetails.TabIndex = 0;
            this.btnAddDetails.Text = "Add Teacher details";
            this.btnAddDetails.UseVisualStyleBackColor = true;
            this.btnAddDetails.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridtechr
            // 
            this.dataGridtechr.AllowUserToAddRows = false;
            this.dataGridtechr.AllowUserToOrderColumns = true;
            this.dataGridtechr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtechr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridtechr.Location = new System.Drawing.Point(55, 193);
            this.dataGridtechr.Name = "dataGridtechr";
            this.dataGridtechr.ReadOnly = true;
            this.dataGridtechr.RowHeadersVisible = false;
            this.dataGridtechr.Size = new System.Drawing.Size(658, 178);
            this.dataGridtechr.TabIndex = 1;
            this.dataGridtechr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridtechr_CellContentClick);
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
            // TeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridtechr);
            this.Controls.Add(this.btnAddDetails);
            this.Name = "TeacherDetails";
            this.Text = "TeacherDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtechr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddDetails;
        public System.Windows.Forms.DataGridView dataGridtechr;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

