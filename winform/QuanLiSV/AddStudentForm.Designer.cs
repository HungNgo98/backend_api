
namespace QuanLiSV
{
    partial class AddStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbaddname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbaddage = new System.Windows.Forms.TextBox();
            this.tbaddsex = new System.Windows.Forms.TextBox();
            this.tbaddclass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.studentTableAdapter1 = new QuanLiSV.ClassroomDataSet2TableAdapters.StudentTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbaddname
            // 
            this.tbaddname.Location = new System.Drawing.Point(206, 59);
            this.tbaddname.Name = "tbaddname";
            this.tbaddname.Size = new System.Drawing.Size(100, 20);
            this.tbaddname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class";
            // 
            // tbaddage
            // 
            this.tbaddage.Location = new System.Drawing.Point(206, 108);
            this.tbaddage.Name = "tbaddage";
            this.tbaddage.Size = new System.Drawing.Size(100, 20);
            this.tbaddage.TabIndex = 5;
            // 
            // tbaddsex
            // 
            this.tbaddsex.Location = new System.Drawing.Point(599, 59);
            this.tbaddsex.Name = "tbaddsex";
            this.tbaddsex.Size = new System.Drawing.Size(100, 20);
            this.tbaddsex.TabIndex = 6;
            // 
            // tbaddclass
            // 
            this.tbaddclass.Location = new System.Drawing.Point(599, 112);
            this.tbaddclass.Name = "tbaddclass";
            this.tbaddclass.Size = new System.Drawing.Size(100, 20);
            this.tbaddclass.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbaddclass);
            this.Controls.Add(this.tbaddsex);
            this.Controls.Add(this.tbaddage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbaddname);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentForm";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbaddname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbaddage;
        private System.Windows.Forms.TextBox tbaddsex;
        private System.Windows.Forms.TextBox tbaddclass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ClassroomDataSet2TableAdapters.StudentTableAdapter studentTableAdapter1;
    }
}