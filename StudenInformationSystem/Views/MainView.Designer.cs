﻿namespace StudenInformationSystem.Views
{
    partial class MainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTagline = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.DGVStudents = new Guna.UI.WinForms.GunaDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTOStudentInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTNShow = new Guna.UI.WinForms.GunaButton();
            this.BTNDelete = new Guna.UI.WinForms.GunaButton();
            this.BTNEdit = new Guna.UI.WinForms.GunaButton();
            this.BTNAdd = new Guna.UI.WinForms.GunaButton();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTOStudentInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTop.Controls.Add(this.labelTagline);
            this.panelTop.Controls.Add(this.labelAdmin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1147, 66);
            this.panelTop.TabIndex = 6;
            // 
            // labelTagline
            // 
            this.labelTagline.AutoSize = true;
            this.labelTagline.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagline.ForeColor = System.Drawing.Color.White;
            this.labelTagline.Location = new System.Drawing.Point(16, 34);
            this.labelTagline.Name = "labelTagline";
            this.labelTagline.Size = new System.Drawing.Size(144, 22);
            this.labelTagline.TabIndex = 0;
            this.labelTagline.Text = "SMS Management";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.labelAdmin.Location = new System.Drawing.Point(16, 10);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(63, 22);
            this.labelAdmin.TabIndex = 1;
            this.labelAdmin.Text = "ADMIN";
            // 
            // DGVStudents
            // 
            this.DGVStudents.AllowUserToAddRows = false;
            this.DGVStudents.AllowUserToDeleteRows = false;
            this.DGVStudents.AllowUserToResizeColumns = false;
            this.DGVStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStudents.AutoGenerateColumns = false;
            this.DGVStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVStudents.BackgroundColor = System.Drawing.Color.White;
            this.DGVStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStudents.ColumnHeadersHeight = 30;
            this.DGVStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.DGVStudents.DataSource = this.dTOStudentInformationBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStudents.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVStudents.EnableHeadersVisualStyles = false;
            this.DGVStudents.GridColor = System.Drawing.Color.White;
            this.DGVStudents.Location = new System.Drawing.Point(20, 145);
            this.DGVStudents.Name = "DGVStudents";
            this.DGVStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVStudents.RowHeadersVisible = false;
            this.DGVStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStudents.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVStudents.RowTemplate.Height = 30;
            this.DGVStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStudents.Size = new System.Drawing.Size(1108, 557);
            this.DGVStudents.TabIndex = 0;
            this.DGVStudents.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVStudents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVStudents.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVStudents.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.DGVStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DGVStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVStudents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVStudents.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVStudents.ThemeStyle.ReadOnly = false;
            this.DGVStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVStudents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVStudents.ThemeStyle.RowsStyle.Height = 30;
            this.DGVStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            this.creditsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTOStudentInformationBindingSource
            // 
            this.dTOStudentInformationBindingSource.DataSource = typeof(StudenInformationSystem.Models.DTOs.DTOStudentInformation);
            // 
            // BTNShow
            // 
            this.BTNShow.AnimationHoverSpeed = 0.07F;
            this.BTNShow.AnimationSpeed = 0.03F;
            this.BTNShow.BackColor = System.Drawing.Color.Transparent;
            this.BTNShow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNShow.BorderColor = System.Drawing.Color.Black;
            this.BTNShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNShow.FocusedColor = System.Drawing.Color.Empty;
            this.BTNShow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNShow.ForeColor = System.Drawing.Color.White;
            this.BTNShow.Image = ((System.Drawing.Image)(resources.GetObject("BTNShow.Image")));
            this.BTNShow.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNShow.Location = new System.Drawing.Point(320, 86);
            this.BTNShow.Name = "BTNShow";
            this.BTNShow.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.BTNShow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNShow.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNShow.OnHoverImage = null;
            this.BTNShow.OnPressedColor = System.Drawing.Color.Black;
            this.BTNShow.Radius = 20;
            this.BTNShow.Size = new System.Drawing.Size(169, 42);
            this.BTNShow.TabIndex = 11;
            this.BTNShow.Text = "Show Information";
            // 
            // BTNDelete
            // 
            this.BTNDelete.AnimationHoverSpeed = 0.07F;
            this.BTNDelete.AnimationSpeed = 0.03F;
            this.BTNDelete.BackColor = System.Drawing.Color.Transparent;
            this.BTNDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNDelete.BorderColor = System.Drawing.Color.Black;
            this.BTNDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNDelete.FocusedColor = System.Drawing.Color.Empty;
            this.BTNDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDelete.ForeColor = System.Drawing.Color.White;
            this.BTNDelete.Image = ((System.Drawing.Image)(resources.GetObject("BTNDelete.Image")));
            this.BTNDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNDelete.Location = new System.Drawing.Point(219, 86);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.BTNDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNDelete.OnHoverImage = null;
            this.BTNDelete.OnPressedColor = System.Drawing.Color.Black;
            this.BTNDelete.Radius = 20;
            this.BTNDelete.Size = new System.Drawing.Size(95, 42);
            this.BTNDelete.TabIndex = 10;
            this.BTNDelete.Text = "Delete";
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNEdit
            // 
            this.BTNEdit.AnimationHoverSpeed = 0.07F;
            this.BTNEdit.AnimationSpeed = 0.03F;
            this.BTNEdit.BackColor = System.Drawing.Color.Transparent;
            this.BTNEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNEdit.BorderColor = System.Drawing.Color.Black;
            this.BTNEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNEdit.FocusedColor = System.Drawing.Color.Empty;
            this.BTNEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEdit.ForeColor = System.Drawing.Color.White;
            this.BTNEdit.Image = ((System.Drawing.Image)(resources.GetObject("BTNEdit.Image")));
            this.BTNEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNEdit.Location = new System.Drawing.Point(118, 86);
            this.BTNEdit.Name = "BTNEdit";
            this.BTNEdit.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.BTNEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNEdit.OnHoverImage = null;
            this.BTNEdit.OnPressedColor = System.Drawing.Color.Black;
            this.BTNEdit.Radius = 20;
            this.BTNEdit.Size = new System.Drawing.Size(95, 42);
            this.BTNEdit.TabIndex = 9;
            this.BTNEdit.Text = "Edit";
            this.BTNEdit.Click += new System.EventHandler(this.BTNEdit_Click);
            // 
            // BTNAdd
            // 
            this.BTNAdd.AnimationHoverSpeed = 0.07F;
            this.BTNAdd.AnimationSpeed = 0.03F;
            this.BTNAdd.BackColor = System.Drawing.Color.Transparent;
            this.BTNAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNAdd.BorderColor = System.Drawing.Color.Black;
            this.BTNAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNAdd.FocusedColor = System.Drawing.Color.Empty;
            this.BTNAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAdd.ForeColor = System.Drawing.Color.White;
            this.BTNAdd.Image = ((System.Drawing.Image)(resources.GetObject("BTNAdd.Image")));
            this.BTNAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNAdd.Location = new System.Drawing.Point(17, 86);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.BTNAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNAdd.OnHoverImage = null;
            this.BTNAdd.OnPressedColor = System.Drawing.Color.Black;
            this.BTNAdd.Radius = 20;
            this.BTNAdd.Size = new System.Drawing.Size(95, 42);
            this.BTNAdd.TabIndex = 8;
            this.BTNAdd.Text = "Add";
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1147, 722);
            this.Controls.Add(this.DGVStudents);
            this.Controls.Add(this.BTNShow);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNEdit);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTOStudentInformationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTagline;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI.WinForms.GunaButton BTNAdd;
        private Guna.UI.WinForms.GunaButton BTNEdit;
        private Guna.UI.WinForms.GunaButton BTNDelete;
        private Guna.UI.WinForms.GunaButton BTNShow;
        private Guna.UI.WinForms.GunaDataGridView DGVStudents;
        private System.Windows.Forms.BindingSource dTOStudentInformationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
    }
}