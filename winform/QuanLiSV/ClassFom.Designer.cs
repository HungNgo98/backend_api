
namespace QuanLiSV
{
    partial class ClassFom
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
            this.txt_CLass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.dtgvDataClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataClass)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CLass
            // 
            this.txt_CLass.Location = new System.Drawing.Point(179, 44);
            this.txt_CLass.Name = "txt_CLass";
            this.txt_CLass.Size = new System.Drawing.Size(96, 20);
            this.txt_CLass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lớp học";
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(392, 43);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(99, 20);
            this.btnAddClass.TabIndex = 3;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // dtgvDataClass
            // 
            this.dtgvDataClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDataClass.Location = new System.Drawing.Point(75, 174);
            this.dtgvDataClass.Name = "dtgvDataClass";
            this.dtgvDataClass.Size = new System.Drawing.Size(476, 94);
            this.dtgvDataClass.TabIndex = 0;
            this.dtgvDataClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvData_CellContentClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CLass);
            this.Controls.Add(this.dtgvDataClass);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_CLass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.DataGridView dtgvDataClass;
    }
}