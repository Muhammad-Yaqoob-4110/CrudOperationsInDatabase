namespace LabTask01
{
    partial class StartUp
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
            this.btnStudentData = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnResultData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentData
            // 
            this.btnStudentData.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentData.Location = new System.Drawing.Point(251, 76);
            this.btnStudentData.Name = "btnStudentData";
            this.btnStudentData.Size = new System.Drawing.Size(304, 94);
            this.btnStudentData.TabIndex = 16;
            this.btnStudentData.Text = "Students Data";
            this.btnStudentData.UseVisualStyleBackColor = true;
            this.btnStudentData.Click += new System.EventHandler(this.btnStudentData_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.Location = new System.Drawing.Point(251, 176);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(304, 94);
            this.btnCourse.TabIndex = 17;
            this.btnCourse.Text = "Course Data";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnResultData
            // 
            this.btnResultData.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultData.Location = new System.Drawing.Point(251, 276);
            this.btnResultData.Name = "btnResultData";
            this.btnResultData.Size = new System.Drawing.Size(304, 94);
            this.btnResultData.TabIndex = 18;
            this.btnResultData.Text = "Result Data";
            this.btnResultData.UseVisualStyleBackColor = true;
            this.btnResultData.Click += new System.EventHandler(this.btnResultData_Click);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResultData);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnStudentData);
            this.Name = "StartUp";
            this.Text = "StartUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentData;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnResultData;
    }
}