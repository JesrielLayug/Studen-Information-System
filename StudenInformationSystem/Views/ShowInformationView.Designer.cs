namespace StudenInformationSystem.Views
{
    partial class ShowInformationView
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTagline = new System.Windows.Forms.Label();
            this.GBInformation = new Guna.UI.WinForms.GunaGroupBox();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.DBEducation = new Guna.UI.WinForms.GunaGroupBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelCredits = new System.Windows.Forms.Label();
            this.labelEnrollmentId = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.GBSubjects = new Guna.UI.WinForms.GunaGroupBox();
            this.listBoxSubject = new System.Windows.Forms.ListBox();
            this.BTNClose = new Guna.UI.WinForms.GunaButton();
            this.ValueStudentId = new System.Windows.Forms.Label();
            this.ValueFirstname = new System.Windows.Forms.Label();
            this.ValueLastname = new System.Windows.Forms.Label();
            this.ValueGender = new System.Windows.Forms.Label();
            this.ValueAge = new System.Windows.Forms.Label();
            this.ValueEnrollmentId = new System.Windows.Forms.Label();
            this.ValueCourse = new System.Windows.Forms.Label();
            this.ValueCredits = new System.Windows.Forms.Label();
            this.ValueSemester = new System.Windows.Forms.Label();
            this.ValueYear = new System.Windows.Forms.Label();
            this.GBInformation.SuspendLayout();
            this.DBEducation.SuspendLayout();
            this.GBSubjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(195, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(237, 29);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "STUDENT INFORMATION";
            // 
            // labelTagline
            // 
            this.labelTagline.AutoSize = true;
            this.labelTagline.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagline.Location = new System.Drawing.Point(152, 57);
            this.labelTagline.Name = "labelTagline";
            this.labelTagline.Size = new System.Drawing.Size(320, 19);
            this.labelTagline.TabIndex = 2;
            this.labelTagline.Text = "Empowering Futures, One Information at a Time.";
            // 
            // GBInformation
            // 
            this.GBInformation.BackColor = System.Drawing.Color.Transparent;
            this.GBInformation.BaseColor = System.Drawing.Color.White;
            this.GBInformation.BorderColor = System.Drawing.Color.Black;
            this.GBInformation.Controls.Add(this.ValueAge);
            this.GBInformation.Controls.Add(this.ValueGender);
            this.GBInformation.Controls.Add(this.ValueLastname);
            this.GBInformation.Controls.Add(this.ValueFirstname);
            this.GBInformation.Controls.Add(this.ValueStudentId);
            this.GBInformation.Controls.Add(this.labelAge);
            this.GBInformation.Controls.Add(this.labelGender);
            this.GBInformation.Controls.Add(this.labelLname);
            this.GBInformation.Controls.Add(this.labelStudentId);
            this.GBInformation.Controls.Add(this.labelFname);
            this.GBInformation.ForeColor = System.Drawing.Color.White;
            this.GBInformation.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GBInformation.Location = new System.Drawing.Point(25, 104);
            this.GBInformation.Name = "GBInformation";
            this.GBInformation.Size = new System.Drawing.Size(279, 229);
            this.GBInformation.TabIndex = 3;
            this.GBInformation.Text = "Basic Information";
            this.GBInformation.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.ForeColor = System.Drawing.Color.Black;
            this.labelFname.Location = new System.Drawing.Point(14, 83);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(81, 19);
            this.labelFname.TabIndex = 0;
            this.labelFname.Text = "Firstname: ";
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.ForeColor = System.Drawing.Color.Black;
            this.labelStudentId.Location = new System.Drawing.Point(15, 49);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(80, 19);
            this.labelStudentId.TabIndex = 1;
            this.labelStudentId.Text = "Student ID:";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.ForeColor = System.Drawing.Color.Black;
            this.labelLname.Location = new System.Drawing.Point(14, 114);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(82, 19);
            this.labelLname.TabIndex = 2;
            this.labelLname.Text = "Lastname: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.ForeColor = System.Drawing.Color.Black;
            this.labelGender.Location = new System.Drawing.Point(15, 147);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(61, 19);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Gender:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.ForeColor = System.Drawing.Color.Black;
            this.labelAge.Location = new System.Drawing.Point(15, 180);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(43, 19);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age: ";
            // 
            // DBEducation
            // 
            this.DBEducation.BackColor = System.Drawing.Color.Transparent;
            this.DBEducation.BaseColor = System.Drawing.Color.White;
            this.DBEducation.BorderColor = System.Drawing.Color.Black;
            this.DBEducation.Controls.Add(this.ValueYear);
            this.DBEducation.Controls.Add(this.ValueSemester);
            this.DBEducation.Controls.Add(this.ValueCredits);
            this.DBEducation.Controls.Add(this.ValueCourse);
            this.DBEducation.Controls.Add(this.ValueEnrollmentId);
            this.DBEducation.Controls.Add(this.labelYear);
            this.DBEducation.Controls.Add(this.labelSemester);
            this.DBEducation.Controls.Add(this.labelCredits);
            this.DBEducation.Controls.Add(this.labelEnrollmentId);
            this.DBEducation.Controls.Add(this.labelCourse);
            this.DBEducation.ForeColor = System.Drawing.Color.White;
            this.DBEducation.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DBEducation.Location = new System.Drawing.Point(25, 348);
            this.DBEducation.Name = "DBEducation";
            this.DBEducation.Size = new System.Drawing.Size(610, 224);
            this.DBEducation.TabIndex = 5;
            this.DBEducation.Text = "Education Information";
            this.DBEducation.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.ForeColor = System.Drawing.Color.Black;
            this.labelYear.Location = new System.Drawing.Point(15, 180);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(38, 19);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Year";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.ForeColor = System.Drawing.Color.Black;
            this.labelSemester.Location = new System.Drawing.Point(15, 147);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(75, 19);
            this.labelSemester.TabIndex = 3;
            this.labelSemester.Text = "Semester:";
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.ForeColor = System.Drawing.Color.Black;
            this.labelCredits.Location = new System.Drawing.Point(14, 114);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(64, 19);
            this.labelCredits.TabIndex = 2;
            this.labelCredits.Text = "Credits: ";
            // 
            // labelEnrollmentId
            // 
            this.labelEnrollmentId.AutoSize = true;
            this.labelEnrollmentId.ForeColor = System.Drawing.Color.Black;
            this.labelEnrollmentId.Location = new System.Drawing.Point(15, 49);
            this.labelEnrollmentId.Name = "labelEnrollmentId";
            this.labelEnrollmentId.Size = new System.Drawing.Size(97, 19);
            this.labelEnrollmentId.TabIndex = 1;
            this.labelEnrollmentId.Text = "Enrollment ID:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.ForeColor = System.Drawing.Color.Black;
            this.labelCourse.Location = new System.Drawing.Point(14, 83);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(59, 19);
            this.labelCourse.TabIndex = 0;
            this.labelCourse.Text = "Course:";
            // 
            // GBSubjects
            // 
            this.GBSubjects.BackColor = System.Drawing.Color.Transparent;
            this.GBSubjects.BaseColor = System.Drawing.Color.White;
            this.GBSubjects.BorderColor = System.Drawing.Color.Gainsboro;
            this.GBSubjects.Controls.Add(this.listBoxSubject);
            this.GBSubjects.ForeColor = System.Drawing.Color.White;
            this.GBSubjects.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GBSubjects.Location = new System.Drawing.Point(319, 104);
            this.GBSubjects.Name = "GBSubjects";
            this.GBSubjects.Size = new System.Drawing.Size(316, 229);
            this.GBSubjects.TabIndex = 6;
            this.GBSubjects.Text = "Subjects Enrolled";
            this.GBSubjects.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // listBoxSubject
            // 
            this.listBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSubject.FormattingEnabled = true;
            this.listBoxSubject.ItemHeight = 19;
            this.listBoxSubject.Location = new System.Drawing.Point(18, 42);
            this.listBoxSubject.MultiColumn = true;
            this.listBoxSubject.Name = "listBoxSubject";
            this.listBoxSubject.Size = new System.Drawing.Size(719, 76);
            this.listBoxSubject.TabIndex = 0;
            // 
            // BTNClose
            // 
            this.BTNClose.AnimationHoverSpeed = 0.07F;
            this.BTNClose.AnimationSpeed = 0.03F;
            this.BTNClose.BackColor = System.Drawing.Color.Transparent;
            this.BTNClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNClose.BorderColor = System.Drawing.Color.Black;
            this.BTNClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNClose.FocusedColor = System.Drawing.Color.Empty;
            this.BTNClose.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNClose.ForeColor = System.Drawing.Color.White;
            this.BTNClose.Image = null;
            this.BTNClose.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNClose.Location = new System.Drawing.Point(212, 596);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.BTNClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNClose.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNClose.OnHoverImage = null;
            this.BTNClose.OnPressedColor = System.Drawing.Color.Black;
            this.BTNClose.Radius = 20;
            this.BTNClose.Size = new System.Drawing.Size(222, 42);
            this.BTNClose.TabIndex = 7;
            this.BTNClose.Text = "Close";
            this.BTNClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // ValueStudentId
            // 
            this.ValueStudentId.AutoSize = true;
            this.ValueStudentId.ForeColor = System.Drawing.Color.Black;
            this.ValueStudentId.Location = new System.Drawing.Point(112, 49);
            this.ValueStudentId.Name = "ValueStudentId";
            this.ValueStudentId.Size = new System.Drawing.Size(44, 19);
            this.ValueStudentId.TabIndex = 5;
            this.ValueStudentId.Text = "value";
            // 
            // ValueFirstname
            // 
            this.ValueFirstname.AutoSize = true;
            this.ValueFirstname.ForeColor = System.Drawing.Color.Black;
            this.ValueFirstname.Location = new System.Drawing.Point(112, 83);
            this.ValueFirstname.Name = "ValueFirstname";
            this.ValueFirstname.Size = new System.Drawing.Size(44, 19);
            this.ValueFirstname.TabIndex = 6;
            this.ValueFirstname.Text = "value";
            // 
            // ValueLastname
            // 
            this.ValueLastname.AutoSize = true;
            this.ValueLastname.ForeColor = System.Drawing.Color.Black;
            this.ValueLastname.Location = new System.Drawing.Point(112, 114);
            this.ValueLastname.Name = "ValueLastname";
            this.ValueLastname.Size = new System.Drawing.Size(44, 19);
            this.ValueLastname.TabIndex = 7;
            this.ValueLastname.Text = "value";
            // 
            // ValueGender
            // 
            this.ValueGender.AutoSize = true;
            this.ValueGender.ForeColor = System.Drawing.Color.Black;
            this.ValueGender.Location = new System.Drawing.Point(112, 147);
            this.ValueGender.Name = "ValueGender";
            this.ValueGender.Size = new System.Drawing.Size(44, 19);
            this.ValueGender.TabIndex = 8;
            this.ValueGender.Text = "value";
            // 
            // ValueAge
            // 
            this.ValueAge.AutoSize = true;
            this.ValueAge.ForeColor = System.Drawing.Color.Black;
            this.ValueAge.Location = new System.Drawing.Point(112, 180);
            this.ValueAge.Name = "ValueAge";
            this.ValueAge.Size = new System.Drawing.Size(44, 19);
            this.ValueAge.TabIndex = 9;
            this.ValueAge.Text = "value";
            // 
            // ValueEnrollmentId
            // 
            this.ValueEnrollmentId.AutoSize = true;
            this.ValueEnrollmentId.ForeColor = System.Drawing.Color.Black;
            this.ValueEnrollmentId.Location = new System.Drawing.Point(118, 49);
            this.ValueEnrollmentId.Name = "ValueEnrollmentId";
            this.ValueEnrollmentId.Size = new System.Drawing.Size(44, 19);
            this.ValueEnrollmentId.TabIndex = 10;
            this.ValueEnrollmentId.Text = "value";
            // 
            // ValueCourse
            // 
            this.ValueCourse.AutoSize = true;
            this.ValueCourse.ForeColor = System.Drawing.Color.Black;
            this.ValueCourse.Location = new System.Drawing.Point(118, 83);
            this.ValueCourse.Name = "ValueCourse";
            this.ValueCourse.Size = new System.Drawing.Size(44, 19);
            this.ValueCourse.TabIndex = 11;
            this.ValueCourse.Text = "value";
            // 
            // ValueCredits
            // 
            this.ValueCredits.AutoSize = true;
            this.ValueCredits.ForeColor = System.Drawing.Color.Black;
            this.ValueCredits.Location = new System.Drawing.Point(118, 114);
            this.ValueCredits.Name = "ValueCredits";
            this.ValueCredits.Size = new System.Drawing.Size(44, 19);
            this.ValueCredits.TabIndex = 12;
            this.ValueCredits.Text = "value";
            // 
            // ValueSemester
            // 
            this.ValueSemester.AutoSize = true;
            this.ValueSemester.ForeColor = System.Drawing.Color.Black;
            this.ValueSemester.Location = new System.Drawing.Point(118, 147);
            this.ValueSemester.Name = "ValueSemester";
            this.ValueSemester.Size = new System.Drawing.Size(44, 19);
            this.ValueSemester.TabIndex = 13;
            this.ValueSemester.Text = "value";
            // 
            // ValueYear
            // 
            this.ValueYear.AutoSize = true;
            this.ValueYear.ForeColor = System.Drawing.Color.Black;
            this.ValueYear.Location = new System.Drawing.Point(118, 180);
            this.ValueYear.Name = "ValueYear";
            this.ValueYear.Size = new System.Drawing.Size(44, 19);
            this.ValueYear.TabIndex = 14;
            this.ValueYear.Text = "value";
            // 
            // ShowInformationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 650);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.GBSubjects);
            this.Controls.Add(this.DBEducation);
            this.Controls.Add(this.GBInformation);
            this.Controls.Add(this.labelTagline);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowInformationView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ShowInformationView_Load);
            this.GBInformation.ResumeLayout(false);
            this.GBInformation.PerformLayout();
            this.DBEducation.ResumeLayout(false);
            this.DBEducation.PerformLayout();
            this.GBSubjects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTagline;
        private Guna.UI.WinForms.GunaGroupBox GBInformation;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAge;
        private Guna.UI.WinForms.GunaGroupBox DBEducation;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.Label labelEnrollmentId;
        private System.Windows.Forms.Label labelCourse;
        private Guna.UI.WinForms.GunaGroupBox GBSubjects;
        private System.Windows.Forms.ListBox listBoxSubject;
        private Guna.UI.WinForms.GunaButton BTNClose;
        private System.Windows.Forms.Label ValueStudentId;
        private System.Windows.Forms.Label ValueFirstname;
        private System.Windows.Forms.Label ValueLastname;
        private System.Windows.Forms.Label ValueGender;
        private System.Windows.Forms.Label ValueAge;
        private System.Windows.Forms.Label ValueEnrollmentId;
        private System.Windows.Forms.Label ValueCourse;
        private System.Windows.Forms.Label ValueCredits;
        private System.Windows.Forms.Label ValueSemester;
        private System.Windows.Forms.Label ValueYear;
    }
}