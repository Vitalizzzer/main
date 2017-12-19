namespace Library
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.pbxPic = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.checkBoxOpenTable = new System.Windows.Forms.CheckBox();
            this.toolTipOpenTable = new System.Windows.Forms.ToolTip(this.components);
            this.lblShowAll = new System.Windows.Forms.Label();
            this.lblWishList = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblMilitary = new System.Windows.Forms.Label();
            this.lblPoetry = new System.Windows.Forms.Label();
            this.lblDrama = new System.Windows.Forms.Label();
            this.lblAdventures = new System.Windows.Forms.Label();
            this.lblBiography = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblSciFi = new System.Windows.Forms.Label();
            this.lblChild = new System.Windows.Forms.Label();
            this.lblEducational = new System.Windows.Forms.Label();
            this.lblReligious = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.AcceptsReturn = true;
            this.txtNote.AcceptsTab = true;
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BackColor = System.Drawing.Color.Honeydew;
            this.txtNote.Font = new System.Drawing.Font("Lucida Calligraphy", 12F);
            this.txtNote.ForeColor = System.Drawing.Color.Black;
            this.txtNote.Location = new System.Drawing.Point(490, 21);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(592, 709);
            this.txtNote.TabIndex = 22;
            this.txtNote.Visible = false;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_WriteToFile);
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.Honeydew;
            this.txtAuthor.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtAuthor.Location = new System.Drawing.Point(104, 20);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(358, 33);
            this.txtAuthor.TabIndex = 22;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Honeydew;
            this.txtTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(104, 56);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(358, 33);
            this.txtTitle.TabIndex = 23;
            // 
            // cmbGenre
            // 
            this.cmbGenre.BackColor = System.Drawing.Color.Honeydew;
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenre.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(104, 93);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGenre.MaxDropDownItems = 10;
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(358, 32);
            this.cmbGenre.TabIndex = 26;
            this.cmbGenre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbGenre_DropDown);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Lucida Calligraphy", 9.75F);
            this.dateTime.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.dateTime.CustomFormat = "dd.MM.yyyy";
            this.dateTime.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(105, 129);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(357, 33);
            this.dateTime.TabIndex = 28;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Honeydew;
            this.txtInfo.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.Black;
            this.txtInfo.Location = new System.Drawing.Point(104, 167);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(262, 129);
            this.txtInfo.TabIndex = 29;
            // 
            // pbxPic
            // 
            this.pbxPic.BackColor = System.Drawing.Color.Honeydew;
            this.pbxPic.BackgroundImage = global::Library.Properties.Resources.no_choose_image;
            this.pbxPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPic.Location = new System.Drawing.Point(373, 167);
            this.pbxPic.Name = "pbxPic";
            this.pbxPic.Size = new System.Drawing.Size(88, 129);
            this.pbxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPic.TabIndex = 34;
            this.pbxPic.TabStop = false;
            this.pbxPic.Click += new System.EventHandler(this.pbxPic_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(11, 167);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(57, 24);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.Text = "Info:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(5, 23);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(91, 24);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(8, 130);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 24);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(8, 93);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(74, 24);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 56);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblAddBook);
            this.groupBox1.Controls.Add(this.checkBoxOpenTable);
            this.groupBox1.Controls.Add(this.pbxPic);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblGenre);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.cmbGenre);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 363);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Book";
            // 
            // lblAddBook
            // 
            this.lblAddBook.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBook.Image = global::Library.Properties.Resources.AddBook0;
            this.lblAddBook.Location = new System.Drawing.Point(138, 309);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(310, 40);
            this.lblAddBook.TabIndex = 36;
            this.lblAddBook.Text = "Add Book";
            this.lblAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddBook.Click += new System.EventHandler(this.lblAddBook_Click);
            this.lblAddBook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblAddBook_MouseDown);
            this.lblAddBook.MouseLeave += new System.EventHandler(this.LblAddBook_MouseLeave);
            this.lblAddBook.MouseHover += new System.EventHandler(this.LblAddBook_MouseHover);
            // 
            // checkBoxOpenTable
            // 
            this.checkBoxOpenTable.AutoSize = true;
            this.checkBoxOpenTable.Checked = true;
            this.checkBoxOpenTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpenTable.Font = new System.Drawing.Font("Lucida Calligraphy", 12F);
            this.checkBoxOpenTable.ForeColor = System.Drawing.Color.White;
            this.checkBoxOpenTable.Location = new System.Drawing.Point(16, 318);
            this.checkBoxOpenTable.Name = "checkBoxOpenTable";
            this.checkBoxOpenTable.Size = new System.Drawing.Size(124, 25);
            this.checkBoxOpenTable.TabIndex = 35;
            this.checkBoxOpenTable.Text = "Open Table";
            this.checkBoxOpenTable.UseVisualStyleBackColor = true;
            this.checkBoxOpenTable.MouseHover += new System.EventHandler(this.CheckBoxOpenTable_MouseHover);
            // 
            // lblShowAll
            // 
            this.lblShowAll.BackColor = System.Drawing.Color.Transparent;
            this.lblShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShowAll.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAll.ForeColor = System.Drawing.Color.Transparent;
            this.lblShowAll.Image = global::Library.Properties.Resources.ShowAllOrig;
            this.lblShowAll.Location = new System.Drawing.Point(22, 659);
            this.lblShowAll.Name = "lblShowAll";
            this.lblShowAll.Size = new System.Drawing.Size(210, 30);
            this.lblShowAll.TabIndex = 38;
            this.lblShowAll.Text = "Show All Books";
            this.lblShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowAll.Click += new System.EventHandler(this.lblShowAll_Click);
            this.lblShowAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblShowAll_MouseDown);
            this.lblShowAll.MouseLeave += new System.EventHandler(this.LblShowAll_MouseLeave);
            this.lblShowAll.MouseHover += new System.EventHandler(this.LblShowAll_MouseHover);
            // 
            // lblWishList
            // 
            this.lblWishList.BackColor = System.Drawing.Color.Transparent;
            this.lblWishList.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWishList.ForeColor = System.Drawing.Color.Transparent;
            this.lblWishList.Image = global::Library.Properties.Resources.ShowAllOrig;
            this.lblWishList.Location = new System.Drawing.Point(265, 659);
            this.lblWishList.Name = "lblWishList";
            this.lblWishList.Size = new System.Drawing.Size(210, 30);
            this.lblWishList.TabIndex = 39;
            this.lblWishList.Text = "Wish List";
            this.lblWishList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWishList.Click += new System.EventHandler(this.lblWishList_Click);
            this.lblWishList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblWishList_MouseDown);
            this.lblWishList.MouseLeave += new System.EventHandler(this.LblWishList_MouseLeave);
            this.lblWishList.MouseHover += new System.EventHandler(this.LblWishList_MouseHover);
            // 
            // lblExport
            // 
            this.lblExport.BackColor = System.Drawing.Color.Transparent;
            this.lblExport.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExport.ForeColor = System.Drawing.Color.Transparent;
            this.lblExport.Image = global::Library.Properties.Resources.ExportAllBooksOrig;
            this.lblExport.Location = new System.Drawing.Point(32, 694);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(430, 40);
            this.lblExport.TabIndex = 40;
            this.lblExport.Text = "Export All Books";
            this.lblExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExport.Click += new System.EventHandler(this.lblExport_Click);
            this.lblExport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblExport_MouseDown);
            this.lblExport.MouseLeave += new System.EventHandler(this.LblExport_MouseLeave);
            this.lblExport.MouseHover += new System.EventHandler(this.LblExport_MouseHover);
            // 
            // lblMilitary
            // 
            this.lblMilitary.BackColor = System.Drawing.Color.Transparent;
            this.lblMilitary.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilitary.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblMilitary.Image = global::Library.Properties.Resources.Book9_1;
            this.lblMilitary.Location = new System.Drawing.Point(13, 599);
            this.lblMilitary.Name = "lblMilitary";
            this.lblMilitary.Size = new System.Drawing.Size(200, 50);
            this.lblMilitary.TabIndex = 41;
            this.lblMilitary.Text = "Military Literature";
            this.lblMilitary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMilitary.Click += new System.EventHandler(this.lblMilitary_Click);
            this.lblMilitary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblMilitary_MouseDown);
            this.lblMilitary.MouseLeave += new System.EventHandler(this.LblMilitary_MouseLeave);
            this.lblMilitary.MouseHover += new System.EventHandler(this.LblMilitary_MouseHover);
            // 
            // lblPoetry
            // 
            this.lblPoetry.BackColor = System.Drawing.Color.Transparent;
            this.lblPoetry.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoetry.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblPoetry.Image = global::Library.Properties.Resources.Book10_1;
            this.lblPoetry.Location = new System.Drawing.Point(283, 599);
            this.lblPoetry.Name = "lblPoetry";
            this.lblPoetry.Size = new System.Drawing.Size(200, 50);
            this.lblPoetry.TabIndex = 42;
            this.lblPoetry.Text = "Poetry";
            this.lblPoetry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPoetry.Click += new System.EventHandler(this.lblPoetry_Click);
            this.lblPoetry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblPoetry_MouseDown);
            this.lblPoetry.MouseLeave += new System.EventHandler(this.LblPoetry_MouseLeave);
            this.lblPoetry.MouseHover += new System.EventHandler(this.LblPoetry_MouseHover);
            // 
            // lblDrama
            // 
            this.lblDrama.BackColor = System.Drawing.Color.Transparent;
            this.lblDrama.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrama.ForeColor = System.Drawing.Color.Bisque;
            this.lblDrama.Image = global::Library.Properties.Resources.Book1_1;
            this.lblDrama.Location = new System.Drawing.Point(13, 385);
            this.lblDrama.Name = "lblDrama";
            this.lblDrama.Size = new System.Drawing.Size(200, 40);
            this.lblDrama.TabIndex = 43;
            this.lblDrama.Text = "Drama";
            this.lblDrama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDrama.Click += new System.EventHandler(this.lblDrama_Click);
            this.lblDrama.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblDrama_MouseDown);
            this.lblDrama.MouseLeave += new System.EventHandler(this.LblDrama_MouseLeave);
            this.lblDrama.MouseHover += new System.EventHandler(this.LblDrama_MouseHover);
            // 
            // lblAdventures
            // 
            this.lblAdventures.BackColor = System.Drawing.Color.Transparent;
            this.lblAdventures.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdventures.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblAdventures.Image = global::Library.Properties.Resources.Book6_1;
            this.lblAdventures.Location = new System.Drawing.Point(282, 385);
            this.lblAdventures.Name = "lblAdventures";
            this.lblAdventures.Size = new System.Drawing.Size(200, 40);
            this.lblAdventures.TabIndex = 44;
            this.lblAdventures.Text = "Adventures";
            this.lblAdventures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdventures.Click += new System.EventHandler(this.lblAdventures_Click);
            this.lblAdventures.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblAdventures_MouseDown);
            this.lblAdventures.MouseLeave += new System.EventHandler(this.LblAdventures_MouseLeave);
            this.lblAdventures.MouseHover += new System.EventHandler(this.LblAdventures_MouseHover);
            // 
            // lblBiography
            // 
            this.lblBiography.BackColor = System.Drawing.Color.Transparent;
            this.lblBiography.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiography.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblBiography.Image = global::Library.Properties.Resources.Book3_1;
            this.lblBiography.Location = new System.Drawing.Point(13, 432);
            this.lblBiography.Name = "lblBiography";
            this.lblBiography.Size = new System.Drawing.Size(200, 65);
            this.lblBiography.TabIndex = 45;
            this.lblBiography.Text = "Biography /Historic";
            this.lblBiography.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBiography.Click += new System.EventHandler(this.lblBiography_Click);
            this.lblBiography.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblBiography_MouseDown);
            this.lblBiography.MouseLeave += new System.EventHandler(this.LblBiography_MouseLeave);
            this.lblBiography.MouseHover += new System.EventHandler(this.LblBiography_MouseHover);
            // 
            // lblReference
            // 
            this.lblReference.BackColor = System.Drawing.Color.Transparent;
            this.lblReference.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.Image = global::Library.Properties.Resources.Book5_1;
            this.lblReference.Location = new System.Drawing.Point(283, 432);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(200, 65);
            this.lblReference.TabIndex = 46;
            this.lblReference.Text = "Reference /Guides";
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReference.Click += new System.EventHandler(this.lblReference_Click);
            this.lblReference.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblReference_MouseDown);
            this.lblReference.MouseLeave += new System.EventHandler(this.LblReference_MouseLeave);
            this.lblReference.MouseHover += new System.EventHandler(this.LblReference_MouseHover);
            // 
            // lblSciFi
            // 
            this.lblSciFi.BackColor = System.Drawing.Color.Transparent;
            this.lblSciFi.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSciFi.ForeColor = System.Drawing.Color.Navy;
            this.lblSciFi.Image = global::Library.Properties.Resources.Book4_1;
            this.lblSciFi.Location = new System.Drawing.Point(13, 505);
            this.lblSciFi.Name = "lblSciFi";
            this.lblSciFi.Size = new System.Drawing.Size(200, 40);
            this.lblSciFi.TabIndex = 47;
            this.lblSciFi.Text = "Science Fiction";
            this.lblSciFi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSciFi.Click += new System.EventHandler(this.lblSciFi_Click);
            this.lblSciFi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblSciFi_MouseDown);
            this.lblSciFi.MouseLeave += new System.EventHandler(this.LblSciFi_MouseLeave);
            this.lblSciFi.MouseHover += new System.EventHandler(this.LblSciFi_MouseHover);
            // 
            // lblChild
            // 
            this.lblChild.BackColor = System.Drawing.Color.Transparent;
            this.lblChild.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild.ForeColor = System.Drawing.Color.Orange;
            this.lblChild.Image = global::Library.Properties.Resources.Book0_1;
            this.lblChild.Location = new System.Drawing.Point(283, 504);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(200, 40);
            this.lblChild.TabIndex = 48;
            this.lblChild.Text = "For Children";
            this.lblChild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChild.Click += new System.EventHandler(this.lblChild_Click);
            this.lblChild.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblChild_MouseDown);
            this.lblChild.MouseLeave += new System.EventHandler(this.LblChild_MouseLeave);
            this.lblChild.MouseHover += new System.EventHandler(this.LblChild_MouseHover);
            // 
            // lblEducational
            // 
            this.lblEducational.BackColor = System.Drawing.Color.Transparent;
            this.lblEducational.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducational.ForeColor = System.Drawing.Color.Pink;
            this.lblEducational.Image = global::Library.Properties.Resources.Book2_1;
            this.lblEducational.Location = new System.Drawing.Point(13, 552);
            this.lblEducational.Name = "lblEducational";
            this.lblEducational.Size = new System.Drawing.Size(200, 40);
            this.lblEducational.TabIndex = 49;
            this.lblEducational.Text = "Educational";
            this.lblEducational.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEducational.Click += new System.EventHandler(this.lblEducational_Click);
            this.lblEducational.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblEducational_MouseDown);
            this.lblEducational.MouseLeave += new System.EventHandler(this.LblEducational_MouseLeave);
            this.lblEducational.MouseHover += new System.EventHandler(this.LblEducational_MouseHover);
            // 
            // lblReligious
            // 
            this.lblReligious.BackColor = System.Drawing.Color.Transparent;
            this.lblReligious.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligious.ForeColor = System.Drawing.Color.Crimson;
            this.lblReligious.Image = global::Library.Properties.Resources.Book7_1;
            this.lblReligious.Location = new System.Drawing.Point(283, 552);
            this.lblReligious.Name = "lblReligious";
            this.lblReligious.Size = new System.Drawing.Size(200, 40);
            this.lblReligious.TabIndex = 50;
            this.lblReligious.Text = "Religious";
            this.lblReligious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReligious.Click += new System.EventHandler(this.lblReligious_Click);
            this.lblReligious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblReligious_MouseDown);
            this.lblReligious.MouseLeave += new System.EventHandler(this.LblReligious_MouseLeave);
            this.lblReligious.MouseHover += new System.EventHandler(this.LblReligious_MouseHover);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Library.Properties.Resources.LibraryForm_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 743);
            this.Controls.Add(this.lblReligious);
            this.Controls.Add(this.lblEducational);
            this.Controls.Add(this.lblChild);
            this.Controls.Add(this.lblSciFi);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblBiography);
            this.Controls.Add(this.lblAdventures);
            this.Controls.Add(this.lblDrama);
            this.Controls.Add(this.lblPoetry);
            this.Controls.Add(this.lblMilitary);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.lblWishList);
            this.Controls.Add(this.lblShowAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNote);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LibraryForm";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Button lblAdventures;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.PictureBox pbxPic;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxOpenTable;
        private System.Windows.Forms.ToolTip toolTipOpenTable;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.Label lblShowAll;
        private System.Windows.Forms.Label lblWishList;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblMilitary;
        private System.Windows.Forms.Label lblPoetry;
        private System.Windows.Forms.Label lblDrama;
        private System.Windows.Forms.Label lblAdventures;
        private System.Windows.Forms.Label lblBiography;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblSciFi;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.Label lblEducational;
        private System.Windows.Forms.Label lblReligious;
       // private System.Windows.Forms.Label lblAdventures;
    }
}

