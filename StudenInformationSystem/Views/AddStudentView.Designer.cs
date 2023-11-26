namespace StudenInformationSystem.Views
{
    partial class AddStudentView
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
            this.groupBoxBasicInformation = new System.Windows.Forms.GroupBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.CBGender = new Guna.UI.WinForms.GunaComboBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.TBAge = new Guna.UI.WinForms.GunaTextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.TBLastname = new Guna.UI.WinForms.GunaTextBox();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.TBFirstname = new Guna.UI.WinForms.GunaTextBox();
            this.BTNSubmit = new Guna.UI.WinForms.GunaButton();
            this.groupBoxAcademic = new System.Windows.Forms.GroupBox();
            this.TBCourse = new Guna.UI.WinForms.GunaTextBox();
            this.labelyear = new System.Windows.Forms.Label();
            this.TBYear = new Guna.UI.WinForms.GunaTextBox();
            this.labelsemester = new System.Windows.Forms.Label();
            this.TBSemester = new Guna.UI.WinForms.GunaTextBox();
            this.labelcredits = new System.Windows.Forms.Label();
            this.TBCredits = new Guna.UI.WinForms.GunaTextBox();
            this.labelcourse = new System.Windows.Forms.Label();
            this.TBSubject = new Guna.UI.WinForms.GunaTextBox();
            this.BTNAddSubject = new Guna.UI.WinForms.GunaButton();
            this.labelEnterSubject = new System.Windows.Forms.Label();
            this.BTNCancel = new Guna.UI.WinForms.GunaButton();
            this.ListBoxSubjects = new System.Windows.Forms.ListBox();
            this.BTNClearSubjects = new Guna.UI.WinForms.GunaButton();
            this.groupBoxBasicInformation.SuspendLayout();
            this.groupBoxAcademic.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(402, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(237, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "STUDENT INFORMATION";
            // 
            // labelTagline
            // 
            this.labelTagline.AutoSize = true;
            this.labelTagline.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagline.Location = new System.Drawing.Point(361, 45);
            this.labelTagline.Name = "labelTagline";
            this.labelTagline.Size = new System.Drawing.Size(320, 19);
            this.labelTagline.TabIndex = 1;
            this.labelTagline.Text = "Empowering Futures, One Information at a Time.";
            // 
            // groupBoxBasicInformation
            // 
            this.groupBoxBasicInformation.Controls.Add(this.labelGender);
            this.groupBoxBasicInformation.Controls.Add(this.CBGender);
            this.groupBoxBasicInformation.Controls.Add(this.labelAge);
            this.groupBoxBasicInformation.Controls.Add(this.TBAge);
            this.groupBoxBasicInformation.Controls.Add(this.labelLastname);
            this.groupBoxBasicInformation.Controls.Add(this.TBLastname);
            this.groupBoxBasicInformation.Controls.Add(this.labelFirstname);
            this.groupBoxBasicInformation.Controls.Add(this.TBFirstname);
            this.groupBoxBasicInformation.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBasicInformation.Location = new System.Drawing.Point(29, 90);
            this.groupBoxBasicInformation.Name = "groupBoxBasicInformation";
            this.groupBoxBasicInformation.Size = new System.Drawing.Size(316, 359);
            this.groupBoxBasicInformation.TabIndex = 2;
            this.groupBoxBasicInformation.TabStop = false;
            this.groupBoxBasicInformation.Text = " Basic Information ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(51, 270);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(57, 19);
            this.labelGender.TabIndex = 7;
            this.labelGender.Text = "Gender";
            // 
            // CBGender
            // 
            this.CBGender.BackColor = System.Drawing.Color.Transparent;
            this.CBGender.BaseColor = System.Drawing.Color.White;
            this.CBGender.BorderColor = System.Drawing.Color.Silver;
            this.CBGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGender.FocusedColor = System.Drawing.Color.Empty;
            this.CBGender.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGender.ForeColor = System.Drawing.Color.Black;
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prepared not to say"});
            this.CBGender.Location = new System.Drawing.Point(55, 292);
            this.CBGender.Name = "CBGender";
            this.CBGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CBGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CBGender.Radius = 10;
            this.CBGender.Size = new System.Drawing.Size(210, 28);
            this.CBGender.TabIndex = 6;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(51, 191);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(35, 19);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age";
            // 
            // TBAge
            // 
            this.TBAge.BackColor = System.Drawing.Color.Transparent;
            this.TBAge.BaseColor = System.Drawing.Color.White;
            this.TBAge.BorderColor = System.Drawing.Color.Silver;
            this.TBAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBAge.FocusedBaseColor = System.Drawing.Color.White;
            this.TBAge.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TBAge.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBAge.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAge.Location = new System.Drawing.Point(55, 213);
            this.TBAge.Name = "TBAge";
            this.TBAge.PasswordChar = '\0';
            this.TBAge.Radius = 10;
            this.TBAge.SelectedText = "";
            this.TBAge.Size = new System.Drawing.Size(93, 39);
            this.TBAge.TabIndex = 4;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(51, 116);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(74, 19);
            this.labelLastname.TabIndex = 3;
            this.labelLastname.Text = "Lastname";
            // 
            // TBLastname
            // 
            this.TBLastname.BackColor = System.Drawing.Color.Transparent;
            this.TBLastname.BaseColor = System.Drawing.Color.White;
            this.TBLastname.BorderColor = System.Drawing.Color.Silver;
            this.TBLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBLastname.FocusedBaseColor = System.Drawing.Color.White;
            this.TBLastname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TBLastname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBLastname.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLastname.Location = new System.Drawing.Point(55, 138);
            this.TBLastname.Name = "TBLastname";
            this.TBLastname.PasswordChar = '\0';
            this.TBLastname.Radius = 10;
            this.TBLastname.SelectedText = "";
            this.TBLastname.Size = new System.Drawing.Size(210, 39);
            this.TBLastname.TabIndex = 2;
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Location = new System.Drawing.Point(51, 41);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(73, 19);
            this.labelFirstname.TabIndex = 1;
            this.labelFirstname.Text = "Firstname";
            // 
            // TBFirstname
            // 
            this.TBFirstname.BackColor = System.Drawing.Color.Transparent;
            this.TBFirstname.BaseColor = System.Drawing.Color.White;
            this.TBFirstname.BorderColor = System.Drawing.Color.Silver;
            this.TBFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBFirstname.FocusedBaseColor = System.Drawing.Color.White;
            this.TBFirstname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TBFirstname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBFirstname.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFirstname.Location = new System.Drawing.Point(55, 63);
            this.TBFirstname.Name = "TBFirstname";
            this.TBFirstname.PasswordChar = '\0';
            this.TBFirstname.Radius = 10;
            this.TBFirstname.SelectedText = "";
            this.TBFirstname.Size = new System.Drawing.Size(210, 39);
            this.TBFirstname.TabIndex = 0;
            // 
            // BTNSubmit
            // 
            this.BTNSubmit.AnimationHoverSpeed = 0.07F;
            this.BTNSubmit.AnimationSpeed = 0.03F;
            this.BTNSubmit.BackColor = System.Drawing.Color.Transparent;
            this.BTNSubmit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNSubmit.BorderColor = System.Drawing.Color.Black;
            this.BTNSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNSubmit.FocusedColor = System.Drawing.Color.Empty;
            this.BTNSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSubmit.ForeColor = System.Drawing.Color.White;
            this.BTNSubmit.Image = null;
            this.BTNSubmit.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNSubmit.Location = new System.Drawing.Point(858, 483);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.BTNSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNSubmit.OnHoverImage = null;
            this.BTNSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.BTNSubmit.Radius = 10;
            this.BTNSubmit.Size = new System.Drawing.Size(133, 42);
            this.BTNSubmit.TabIndex = 3;
            this.BTNSubmit.Text = "Submit";
            this.BTNSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNSubmit.Click += new System.EventHandler(this.BTNSubmit_Click);
            // 
            // groupBoxAcademic
            // 
            this.groupBoxAcademic.Controls.Add(this.TBCourse);
            this.groupBoxAcademic.Controls.Add(this.labelyear);
            this.groupBoxAcademic.Controls.Add(this.TBYear);
            this.groupBoxAcademic.Controls.Add(this.labelsemester);
            this.groupBoxAcademic.Controls.Add(this.TBSemester);
            this.groupBoxAcademic.Controls.Add(this.labelcredits);
            this.groupBoxAcademic.Controls.Add(this.TBCredits);
            this.groupBoxAcademic.Controls.Add(this.labelcourse);
            this.groupBoxAcademic.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAcademic.Location = new System.Drawing.Point(365, 90);
            this.groupBoxAcademic.Name = "groupBoxAcademic";
            this.groupBoxAcademic.Size = new System.Drawing.Size(316, 359);
            this.groupBoxAcademic.TabIndex = 8;
            this.groupBoxAcademic.TabStop = false;
            this.groupBoxAcademic.Text = " Academic Information ";
            // 
            // TBCourse
            // 
            this.TBCourse.BackColor = System.Drawing.Color.Transparent;
            this.TBCourse.BaseColor = System.Drawing.Color.White;
            this.TBCourse.BorderColor = System.Drawing.Color.Silver;
            this.TBCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBCourse.FocusedBaseColor = System.Drawing.Color.White;
            this.TBCourse.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TBCourse.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBCourse.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCourse.Location = new System.Drawing.Point(55, 63);
            this.TBCourse.Name = "TBCourse";
            this.TBCourse.PasswordChar = '\0';
            this.TBCourse.Radius = 10;
            this.TBCourse.SelectedText = "";
            this.TBCourse.Size = new System.Drawing.Size(208, 39);
            this.TBCourse.TabIndex = 8;
            // 
            // labelyear
            // 
            this.labelyear.AutoSize = true;
            this.labelyear.Location = new System.Drawing.Point(51, 270);
            this.labelyear.Name = "labelyear";
            this.labelyear.Size = new System.Drawing.Size(38, 19);
            this.labelyear.TabIndex = 7;
            this.labelyear.Text = "Year";
            // 
            // TBYear
            // 
            this.TBYear.BackColor = System.Drawing.Color.Transparent;
            this.TBYear.BaseColor = System.Drawing.Color.White;
            this.TBYear.BorderColor = System.Drawing.Color.Silver;
            this.TBYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBYear.FocusedBaseColor = System.Drawing.Color.White;
            this.TBYear.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TBYear.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBYear.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBYear.Location = new System.Drawing.Point(55, 292);
            this.TBYear.Name = "TBYear";
            this.TBYear.PasswordChar = '\0';
            this.TBYear.Radius = 10;
            this.TBYear.SelectedText = "";
            this.TBYear.Size = new System.Drawing.Size(208, 39);
            this.TBYear.TabIndex = 6;
            // 
            // labelsemester
            // 
            this.labelsemester.AutoSize = true;
            this.labelsemester.Location = new System.Drawing.Point(51, 191);
            this.labelsemester.Name = "labelsemester";
            this.labelsemester.Size = new System.Drawing.Size(71, 19);
            this.labelsemester.TabIndex = 5;
            this.labelsemester.Text = "Semester";
            // 
            // TBSemester
            // 
            this.TBSemester.BackColor = System.Drawing.Color.Transparent;
            this.TBSemester.BaseColor = System.Drawing.Color.White;
            this.TBSemester.BorderColor = System.Drawing.Color.Silver;
            this.TBSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBSemester.FocusedBaseColor = System.Drawing.Color.White;
            this.TBSemester.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TBSemester.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBSemester.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSemester.Location = new System.Drawing.Point(55, 213);
            this.TBSemester.Name = "TBSemester";
            this.TBSemester.PasswordChar = '\0';
            this.TBSemester.Radius = 10;
            this.TBSemester.SelectedText = "";
            this.TBSemester.Size = new System.Drawing.Size(210, 39);
            this.TBSemester.TabIndex = 4;
            // 
            // labelcredits
            // 
            this.labelcredits.AutoSize = true;
            this.labelcredits.Location = new System.Drawing.Point(51, 116);
            this.labelcredits.Name = "labelcredits";
            this.labelcredits.Size = new System.Drawing.Size(56, 19);
            this.labelcredits.TabIndex = 3;
            this.labelcredits.Text = "Credits";
            // 
            // TBCredits
            // 
            this.TBCredits.BackColor = System.Drawing.Color.Transparent;
            this.TBCredits.BaseColor = System.Drawing.Color.White;
            this.TBCredits.BorderColor = System.Drawing.Color.Silver;
            this.TBCredits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBCredits.FocusedBaseColor = System.Drawing.Color.White;
            this.TBCredits.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TBCredits.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBCredits.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCredits.Location = new System.Drawing.Point(55, 138);
            this.TBCredits.Name = "TBCredits";
            this.TBCredits.PasswordChar = '\0';
            this.TBCredits.Radius = 10;
            this.TBCredits.SelectedText = "";
            this.TBCredits.Size = new System.Drawing.Size(210, 39);
            this.TBCredits.TabIndex = 2;
            // 
            // labelcourse
            // 
            this.labelcourse.AutoSize = true;
            this.labelcourse.Location = new System.Drawing.Point(51, 41);
            this.labelcourse.Name = "labelcourse";
            this.labelcourse.Size = new System.Drawing.Size(55, 19);
            this.labelcourse.TabIndex = 1;
            this.labelcourse.Text = "Course";
            // 
            // TBSubject
            // 
            this.TBSubject.BackColor = System.Drawing.Color.Transparent;
            this.TBSubject.BaseColor = System.Drawing.Color.White;
            this.TBSubject.BorderColor = System.Drawing.Color.Silver;
            this.TBSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBSubject.FocusedBaseColor = System.Drawing.Color.White;
            this.TBSubject.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TBSubject.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBSubject.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSubject.Location = new System.Drawing.Point(712, 122);
            this.TBSubject.Name = "TBSubject";
            this.TBSubject.PasswordChar = '\0';
            this.TBSubject.Radius = 10;
            this.TBSubject.SelectedText = "";
            this.TBSubject.Size = new System.Drawing.Size(214, 39);
            this.TBSubject.TabIndex = 9;
            // 
            // BTNAddSubject
            // 
            this.BTNAddSubject.AnimationHoverSpeed = 0.07F;
            this.BTNAddSubject.AnimationSpeed = 0.03F;
            this.BTNAddSubject.BackColor = System.Drawing.Color.Transparent;
            this.BTNAddSubject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNAddSubject.BorderColor = System.Drawing.Color.Black;
            this.BTNAddSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNAddSubject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNAddSubject.FocusedColor = System.Drawing.Color.Empty;
            this.BTNAddSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddSubject.ForeColor = System.Drawing.Color.White;
            this.BTNAddSubject.Image = null;
            this.BTNAddSubject.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNAddSubject.Location = new System.Drawing.Point(932, 122);
            this.BTNAddSubject.Name = "BTNAddSubject";
            this.BTNAddSubject.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.BTNAddSubject.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNAddSubject.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNAddSubject.OnHoverImage = null;
            this.BTNAddSubject.OnPressedColor = System.Drawing.Color.Black;
            this.BTNAddSubject.Radius = 20;
            this.BTNAddSubject.Size = new System.Drawing.Size(59, 39);
            this.BTNAddSubject.TabIndex = 10;
            this.BTNAddSubject.Text = "Add";
            this.BTNAddSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNAddSubject.Click += new System.EventHandler(this.BTNAddSubject_Click);
            // 
            // labelEnterSubject
            // 
            this.labelEnterSubject.AutoSize = true;
            this.labelEnterSubject.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterSubject.Location = new System.Drawing.Point(709, 97);
            this.labelEnterSubject.Name = "labelEnterSubject";
            this.labelEnterSubject.Size = new System.Drawing.Size(85, 18);
            this.labelEnterSubject.TabIndex = 11;
            this.labelEnterSubject.Text = "Enter Subject";
            // 
            // BTNCancel
            // 
            this.BTNCancel.AnimationHoverSpeed = 0.07F;
            this.BTNCancel.AnimationSpeed = 0.03F;
            this.BTNCancel.BackColor = System.Drawing.Color.Transparent;
            this.BTNCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNCancel.BorderColor = System.Drawing.Color.Black;
            this.BTNCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNCancel.FocusedColor = System.Drawing.Color.Empty;
            this.BTNCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancel.ForeColor = System.Drawing.Color.White;
            this.BTNCancel.Image = null;
            this.BTNCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNCancel.Location = new System.Drawing.Point(712, 483);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.BTNCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNCancel.OnHoverImage = null;
            this.BTNCancel.OnPressedColor = System.Drawing.Color.Black;
            this.BTNCancel.Radius = 10;
            this.BTNCancel.Size = new System.Drawing.Size(140, 42);
            this.BTNCancel.TabIndex = 12;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // ListBoxSubjects
            // 
            this.ListBoxSubjects.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxSubjects.FormattingEnabled = true;
            this.ListBoxSubjects.ItemHeight = 18;
            this.ListBoxSubjects.Location = new System.Drawing.Point(712, 173);
            this.ListBoxSubjects.MultiColumn = true;
            this.ListBoxSubjects.Name = "ListBoxSubjects";
            this.ListBoxSubjects.Size = new System.Drawing.Size(279, 238);
            this.ListBoxSubjects.TabIndex = 13;
            // 
            // BTNClearSubjects
            // 
            this.BTNClearSubjects.AnimationHoverSpeed = 0.07F;
            this.BTNClearSubjects.AnimationSpeed = 0.03F;
            this.BTNClearSubjects.BackColor = System.Drawing.Color.Transparent;
            this.BTNClearSubjects.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNClearSubjects.BorderColor = System.Drawing.Color.Black;
            this.BTNClearSubjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNClearSubjects.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNClearSubjects.FocusedColor = System.Drawing.Color.Empty;
            this.BTNClearSubjects.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNClearSubjects.ForeColor = System.Drawing.Color.White;
            this.BTNClearSubjects.Image = null;
            this.BTNClearSubjects.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNClearSubjects.Location = new System.Drawing.Point(712, 417);
            this.BTNClearSubjects.Name = "BTNClearSubjects";
            this.BTNClearSubjects.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.BTNClearSubjects.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNClearSubjects.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNClearSubjects.OnHoverImage = null;
            this.BTNClearSubjects.OnPressedColor = System.Drawing.Color.Black;
            this.BTNClearSubjects.Size = new System.Drawing.Size(279, 32);
            this.BTNClearSubjects.TabIndex = 14;
            this.BTNClearSubjects.Text = "Clear";
            this.BTNClearSubjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNClearSubjects.Click += new System.EventHandler(this.BTNClearSubjects_Click);
            // 
            // AddStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 545);
            this.Controls.Add(this.BTNClearSubjects);
            this.Controls.Add(this.ListBoxSubjects);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.labelEnterSubject);
            this.Controls.Add(this.BTNAddSubject);
            this.Controls.Add(this.TBSubject);
            this.Controls.Add(this.groupBoxAcademic);
            this.Controls.Add(this.BTNSubmit);
            this.Controls.Add(this.groupBoxBasicInformation);
            this.Controls.Add(this.labelTagline);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddStudentView_Load);
            this.groupBoxBasicInformation.ResumeLayout(false);
            this.groupBoxBasicInformation.PerformLayout();
            this.groupBoxAcademic.ResumeLayout(false);
            this.groupBoxAcademic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTagline;
        private System.Windows.Forms.GroupBox groupBoxBasicInformation;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.GroupBox groupBoxAcademic;
        private System.Windows.Forms.Label labelsemester;
        private System.Windows.Forms.Label labelcredits;
        private System.Windows.Forms.Label labelcourse;
        private System.Windows.Forms.Label labelyear;
        private Guna.UI.WinForms.GunaTextBox TBSubject;
        private Guna.UI.WinForms.GunaButton BTNAddSubject;
        private System.Windows.Forms.Label labelEnterSubject;
        private Guna.UI.WinForms.GunaButton BTNCancel;
        private Guna.UI.WinForms.GunaButton BTNClearSubjects;
        public Guna.UI.WinForms.GunaButton BTNSubmit;
        public Guna.UI.WinForms.GunaTextBox TBFirstname;
        public Guna.UI.WinForms.GunaTextBox TBAge;
        public Guna.UI.WinForms.GunaTextBox TBLastname;
        public Guna.UI.WinForms.GunaComboBox CBGender;
        public Guna.UI.WinForms.GunaTextBox TBSemester;
        public Guna.UI.WinForms.GunaTextBox TBCredits;
        public Guna.UI.WinForms.GunaTextBox TBYear;
        public System.Windows.Forms.ListBox ListBoxSubjects;
        public Guna.UI.WinForms.GunaTextBox TBCourse;
    }
}