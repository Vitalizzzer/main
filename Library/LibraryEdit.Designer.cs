namespace Library
{
    partial class LibraryEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryEdit));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEditInfo = new System.Windows.Forms.TextBox();
            this.dateTimeEdit = new System.Windows.Forms.DateTimePicker();
            this.cmbEditGenre = new System.Windows.Forms.ComboBox();
            this.txtEditTitle = new System.Windows.Forms.TextBox();
            this.txtEditAuthor = new System.Windows.Forms.TextBox();
            this.pbxPicEdit = new System.Windows.Forms.PictureBox();
            this.lblSaveChangesEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(14, 179);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(57, 24);
            this.lblInfo.TabIndex = 45;
            this.lblInfo.Text = "Info:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(14, 141);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 24);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "Date:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.Location = new System.Drawing.Point(14, 98);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(74, 24);
            this.lblGenre.TabIndex = 37;
            this.lblGenre.Text = "Genre:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.Location = new System.Drawing.Point(14, 16);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(91, 24);
            this.lblAuthor.TabIndex = 36;
            this.lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(14, 57);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 24);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Title:";
            // 
            // txtEditInfo
            // 
            this.txtEditInfo.BackColor = System.Drawing.Color.Honeydew;
            this.txtEditInfo.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditInfo.ForeColor = System.Drawing.Color.Black;
            this.txtEditInfo.Location = new System.Drawing.Point(113, 176);
            this.txtEditInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditInfo.Multiline = true;
            this.txtEditInfo.Name = "txtEditInfo";
            this.txtEditInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditInfo.Size = new System.Drawing.Size(262, 129);
            this.txtEditInfo.TabIndex = 44;
            // 
            // dateTimeEdit
            // 
            this.dateTimeEdit.CalendarFont = new System.Drawing.Font("Lucida Calligraphy", 9.75F);
            this.dateTimeEdit.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.dateTimeEdit.CustomFormat = "dd.MM.yyyy";
            this.dateTimeEdit.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEdit.Location = new System.Drawing.Point(113, 135);
            this.dateTimeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeEdit.Name = "dateTimeEdit";
            this.dateTimeEdit.Size = new System.Drawing.Size(357, 33);
            this.dateTimeEdit.TabIndex = 43;
            // 
            // cmbEditGenre
            // 
            this.cmbEditGenre.BackColor = System.Drawing.Color.Honeydew;
            this.cmbEditGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEditGenre.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditGenre.FormattingEnabled = true;
            this.cmbEditGenre.Location = new System.Drawing.Point(113, 95);
            this.cmbEditGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEditGenre.MaxDropDownItems = 10;
            this.cmbEditGenre.Name = "cmbEditGenre";
            this.cmbEditGenre.Size = new System.Drawing.Size(358, 32);
            this.cmbEditGenre.TabIndex = 42;
            this.cmbEditGenre.Click += new System.EventHandler(this.CmbGenre_Click);
            // 
            // txtEditTitle
            // 
            this.txtEditTitle.BackColor = System.Drawing.Color.Honeydew;
            this.txtEditTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTitle.ForeColor = System.Drawing.Color.Black;
            this.txtEditTitle.Location = new System.Drawing.Point(113, 54);
            this.txtEditTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditTitle.Name = "txtEditTitle";
            this.txtEditTitle.Size = new System.Drawing.Size(358, 33);
            this.txtEditTitle.TabIndex = 41;
            // 
            // txtEditAuthor
            // 
            this.txtEditAuthor.BackColor = System.Drawing.Color.Honeydew;
            this.txtEditAuthor.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtEditAuthor.Location = new System.Drawing.Point(113, 13);
            this.txtEditAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditAuthor.Name = "txtEditAuthor";
            this.txtEditAuthor.Size = new System.Drawing.Size(358, 33);
            this.txtEditAuthor.TabIndex = 40;
            // 
            // pbxPicEdit
            // 
            this.pbxPicEdit.BackColor = System.Drawing.Color.Honeydew;
            this.pbxPicEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxPicEdit.BackgroundImage")));
            this.pbxPicEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPicEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPicEdit.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxPicEdit.InitialImage")));
            this.pbxPicEdit.Location = new System.Drawing.Point(382, 176);
            this.pbxPicEdit.Name = "pbxPicEdit";
            this.pbxPicEdit.Size = new System.Drawing.Size(88, 129);
            this.pbxPicEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPicEdit.TabIndex = 46;
            this.pbxPicEdit.TabStop = false;
            this.pbxPicEdit.Click += new System.EventHandler(this.pbxPicEdit_Click);
            // 
            // lblSaveChangesEdit
            // 
            this.lblSaveChangesEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveChangesEdit.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveChangesEdit.ForeColor = System.Drawing.Color.Transparent;
            this.lblSaveChangesEdit.Image = global::Library.Properties.Resources.AddBook0;
            this.lblSaveChangesEdit.Location = new System.Drawing.Point(141, 318);
            this.lblSaveChangesEdit.Name = "lblSaveChangesEdit";
            this.lblSaveChangesEdit.Size = new System.Drawing.Size(310, 40);
            this.lblSaveChangesEdit.TabIndex = 47;
            this.lblSaveChangesEdit.Text = "Save Changes";
            this.lblSaveChangesEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaveChangesEdit.Click += new System.EventHandler(this.lblSaveChangesEdit_Click);
            this.lblSaveChangesEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSaveChanges_MouseDown);
            this.lblSaveChangesEdit.MouseLeave += new System.EventHandler(this.BtnSaveChanges_MouseLeave);
            this.lblSaveChangesEdit.MouseHover += new System.EventHandler(this.LblSaveChanges_MouseHover);
            // 
            // LibraryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 372);
            this.Controls.Add(this.lblSaveChangesEdit);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtEditInfo);
            this.Controls.Add(this.dateTimeEdit);
            this.Controls.Add(this.cmbEditGenre);
            this.Controls.Add(this.txtEditTitle);
            this.Controls.Add(this.txtEditAuthor);
            this.Controls.Add(this.pbxPicEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibraryEdit";
            this.Text = "Edit Book";
            this.Load += new System.EventHandler(this.LibraryEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEditInfo;
        private System.Windows.Forms.DateTimePicker dateTimeEdit;
        private System.Windows.Forms.ComboBox cmbEditGenre;
        private System.Windows.Forms.TextBox txtEditTitle;
        private System.Windows.Forms.TextBox txtEditAuthor;
        private System.Windows.Forms.PictureBox pbxPicEdit;
        private System.Windows.Forms.Label lblSaveChangesEdit;

    }
}