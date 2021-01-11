
namespace QuanLiSV
{
    partial class StudentForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSeaarch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DtgvStudent = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.classroomDataSet2 = new QuanLiSV.ClassroomDataSet2();
            this.classroomDataSet = new QuanLiSV.ClassroomDataSet();
            this.classroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classroomTableAdapter = new QuanLiSV.ClassroomDataSetTableAdapters.ClassroomTableAdapter();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new QuanLiSV.ClassroomDataSetTableAdapters.StudentTableAdapter();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbnamestudentform = new System.Windows.Forms.TextBox();
            this.tbagetudentform = new System.Windows.Forms.TextBox();
            this.tbclasstudentform = new System.Windows.Forms.TextBox();
            this.tbsextudentform = new System.Windows.Forms.TextBox();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new QuanLiSV.ClassroomDataSet2TableAdapters.StudentTableAdapter();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(266, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSeaarch
            // 
            this.btnSeaarch.Location = new System.Drawing.Point(420, 25);
            this.btnSeaarch.Name = "btnSeaarch";
            this.btnSeaarch.Size = new System.Drawing.Size(75, 23);
            this.btnSeaarch.TabIndex = 1;
            this.btnSeaarch.Text = "Tìm kiếm";
            this.btnSeaarch.UseVisualStyleBackColor = true;
            this.btnSeaarch.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(693, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(693, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DtgvStudent
            // 
            this.DtgvStudent.AutoGenerateColumns = false;
            this.DtgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn});
            this.DtgvStudent.DataSource = this.studentBindingSource4;
            this.DtgvStudent.Location = new System.Drawing.Point(62, 224);
            this.DtgvStudent.Name = "DtgvStudent";
            this.DtgvStudent.Size = new System.Drawing.Size(442, 203);
            this.DtgvStudent.TabIndex = 2;
            this.DtgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvStudent_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // studentBindingSource4
            // 
            this.studentBindingSource4.DataMember = "Student";
            this.studentBindingSource4.DataSource = this.classroomDataSet2;
            // 
            // classroomDataSet2
            // 
            this.classroomDataSet2.DataSetName = "ClassroomDataSet2";
            this.classroomDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classroomDataSet
            // 
            this.classroomDataSet.DataSetName = "ClassroomDataSet";
            this.classroomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classroomBindingSource
            // 
            this.classroomBindingSource.DataMember = "Classroom";
            this.classroomBindingSource.DataSource = this.classroomDataSet;
            // 
            // classroomTableAdapter
            // 
            this.classroomTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.classroomDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.classroomDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hiển thị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sex";
            // 
            // tbnamestudentform
            // 
            this.tbnamestudentform.Location = new System.Drawing.Point(100, 93);
            this.tbnamestudentform.Name = "tbnamestudentform";
            this.tbnamestudentform.Size = new System.Drawing.Size(148, 20);
            this.tbnamestudentform.TabIndex = 11;
            // 
            // tbagetudentform
            // 
            this.tbagetudentform.Location = new System.Drawing.Point(100, 140);
            this.tbagetudentform.Name = "tbagetudentform";
            this.tbagetudentform.Size = new System.Drawing.Size(148, 20);
            this.tbagetudentform.TabIndex = 12;
            // 
            // tbclasstudentform
            // 
            this.tbclasstudentform.Location = new System.Drawing.Point(377, 93);
            this.tbclasstudentform.Name = "tbclasstudentform";
            this.tbclasstudentform.Size = new System.Drawing.Size(148, 20);
            this.tbclasstudentform.TabIndex = 13;
            // 
            // tbsextudentform
            // 
            this.tbsextudentform.Location = new System.Drawing.Point(377, 140);
            this.tbsextudentform.Name = "tbsextudentform";
            this.tbsextudentform.Size = new System.Drawing.Size(148, 20);
            this.tbsextudentform.TabIndex = 14;
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            this.studentBindingSource2.DataSource = this.classroomDataSet;
            // 
            // studentBindingSource3
            // 
            this.studentBindingSource3.DataMember = "Student";
            this.studentBindingSource3.DataSource = this.classroomDataSet;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(693, 202);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 15;
            this.btnrefresh.Text = "Tải lại";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.tbsextudentform);
            this.Controls.Add(this.tbclasstudentform);
            this.Controls.Add(this.tbagetudentform);
            this.Controls.Add(this.tbnamestudentform);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DtgvStudent);
            this.Controls.Add(this.btnSeaarch);
            this.Controls.Add(this.txtSearch);
            this.Name = "StudentForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSeaarch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DtgvStudent;
        private ClassroomDataSet classroomDataSet;
        private System.Windows.Forms.BindingSource classroomBindingSource;
        private ClassroomDataSetTableAdapters.ClassroomTableAdapter classroomTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ClassroomDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbnamestudentform;
        private System.Windows.Forms.TextBox tbagetudentform;
        private System.Windows.Forms.TextBox tbclasstudentform;
        private System.Windows.Forms.TextBox tbsextudentform;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.BindingSource studentBindingSource3;
        private ClassroomDataSet2 classroomDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource4;
        private ClassroomDataSet2TableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnrefresh;
    }
}