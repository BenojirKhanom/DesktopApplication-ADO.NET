namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.aspProjectDataSet = new WindowsFormsApp1.AspProjectDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new WindowsFormsApp1.AspProjectDataSetTableAdapters.StudentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aspProjectDataSet1 = new WindowsFormsApp1.AspProjectDataSet1();
            this.studentTableAdapter1 = new WindowsFormsApp1.AspProjectDataSet1TableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aspProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspProjectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "StudentID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "StudentName";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // aspProjectDataSet
            // 
            this.aspProjectDataSet.DataSetName = "AspProjectDataSet";
            this.aspProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.aspProjectDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(68, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 241);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.aspProjectDataSet1;
            // 
            // aspProjectDataSet1
            // 
            this.aspProjectDataSet1.DataSetName = "AspProjectDataSet1";
            this.aspProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(688, 514);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aspProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspProjectDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private AspProjectDataSet aspProjectDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private AspProjectDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AspProjectDataSet1 aspProjectDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private AspProjectDataSet1TableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
    }
}

