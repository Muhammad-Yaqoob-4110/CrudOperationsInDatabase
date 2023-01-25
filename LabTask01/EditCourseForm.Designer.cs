namespace LabTask01
{
    partial class EditCourseForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.tbCourse_Name = new System.Windows.Forms.TextBox();
            this.tbStudent_Name = new System.Windows.Forms.TextBox();
            this.tbTeacher_Name = new System.Windows.Forms.TextBox();
            this.tbSemester = new System.Windows.Forms.TextBox();
            this.tbCourse_ID = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblCourse_Name = new System.Windows.Forms.Label();
            this.lblStudent_Name = new System.Windows.Forms.Label();
            this.lblTeacher_Name = new System.Windows.Forms.Label();
            this.lblCourse_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(79, 359);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(222, 50);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCourse.Location = new System.Drawing.Point(505, 359);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(222, 50);
            this.btnEditCourse.TabIndex = 39;
            this.btnEditCourse.Text = "Edit Course Info";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btneditStudent_Click);
            // 
            // tbCourse_Name
            // 
            this.tbCourse_Name.Location = new System.Drawing.Point(316, 115);
            this.tbCourse_Name.Name = "tbCourse_Name";
            this.tbCourse_Name.Size = new System.Drawing.Size(411, 20);
            this.tbCourse_Name.TabIndex = 38;
            // 
            // tbStudent_Name
            // 
            this.tbStudent_Name.Location = new System.Drawing.Point(316, 165);
            this.tbStudent_Name.Name = "tbStudent_Name";
            this.tbStudent_Name.Size = new System.Drawing.Size(411, 20);
            this.tbStudent_Name.TabIndex = 37;
            // 
            // tbTeacher_Name
            // 
            this.tbTeacher_Name.Location = new System.Drawing.Point(316, 221);
            this.tbTeacher_Name.Name = "tbTeacher_Name";
            this.tbTeacher_Name.Size = new System.Drawing.Size(411, 20);
            this.tbTeacher_Name.TabIndex = 36;
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(316, 273);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(411, 20);
            this.tbSemester.TabIndex = 35;
            // 
            // tbCourse_ID
            // 
            this.tbCourse_ID.Location = new System.Drawing.Point(316, 64);
            this.tbCourse_ID.Name = "tbCourse_ID";
            this.tbCourse_ID.Size = new System.Drawing.Size(411, 20);
            this.tbCourse_ID.TabIndex = 33;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(73, 263);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(104, 33);
            this.lblSemester.TabIndex = 31;
            this.lblSemester.Text = "Semester";
            // 
            // lblCourse_Name
            // 
            this.lblCourse_Name.AutoSize = true;
            this.lblCourse_Name.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse_Name.Location = new System.Drawing.Point(73, 105);
            this.lblCourse_Name.Name = "lblCourse_Name";
            this.lblCourse_Name.Size = new System.Drawing.Size(143, 33);
            this.lblCourse_Name.TabIndex = 30;
            this.lblCourse_Name.Text = "Course_Name";
            // 
            // lblStudent_Name
            // 
            this.lblStudent_Name.AutoSize = true;
            this.lblStudent_Name.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent_Name.Location = new System.Drawing.Point(73, 155);
            this.lblStudent_Name.Name = "lblStudent_Name";
            this.lblStudent_Name.Size = new System.Drawing.Size(157, 33);
            this.lblStudent_Name.TabIndex = 29;
            this.lblStudent_Name.Text = "Student_Name";
            // 
            // lblTeacher_Name
            // 
            this.lblTeacher_Name.AutoSize = true;
            this.lblTeacher_Name.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher_Name.Location = new System.Drawing.Point(73, 211);
            this.lblTeacher_Name.Name = "lblTeacher_Name";
            this.lblTeacher_Name.Size = new System.Drawing.Size(155, 33);
            this.lblTeacher_Name.TabIndex = 28;
            this.lblTeacher_Name.Text = "Teacher_Name";
            // 
            // lblCourse_ID
            // 
            this.lblCourse_ID.AutoSize = true;
            this.lblCourse_ID.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse_ID.Location = new System.Drawing.Point(73, 54);
            this.lblCourse_ID.Name = "lblCourse_ID";
            this.lblCourse_ID.Size = new System.Drawing.Size(108, 33);
            this.lblCourse_ID.TabIndex = 27;
            this.lblCourse_ID.Text = "Course_ID";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.tbCourse_Name);
            this.Controls.Add(this.tbStudent_Name);
            this.Controls.Add(this.tbTeacher_Name);
            this.Controls.Add(this.tbSemester);
            this.Controls.Add(this.tbCourse_ID);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblCourse_Name);
            this.Controls.Add(this.lblStudent_Name);
            this.Controls.Add(this.lblTeacher_Name);
            this.Controls.Add(this.lblCourse_ID);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.TextBox tbCourse_Name;
        private System.Windows.Forms.TextBox tbStudent_Name;
        private System.Windows.Forms.TextBox tbTeacher_Name;
        private System.Windows.Forms.TextBox tbSemester;
        private System.Windows.Forms.TextBox tbCourse_ID;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblCourse_Name;
        private System.Windows.Forms.Label lblStudent_Name;
        private System.Windows.Forms.Label lblTeacher_Name;
        private System.Windows.Forms.Label lblCourse_ID;
    }
}