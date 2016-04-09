namespace Recipe_Book
{
    partial class FormAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthor));
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.pbAPhoto = new System.Windows.Forms.PictureBox();
            this.addAutor = new System.Windows.Forms.Button();
            this.delAuthor = new System.Windows.Forms.Button();
            this.editAuthor = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbPName = new System.Windows.Forms.TextBox();
            this.tbOblast = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLname = new System.Windows.Forms.Label();
            this.lbPname = new System.Windows.Forms.Label();
            this.lbOblast = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbOFD = new System.Windows.Forms.Label();
            this.tbOFD = new System.Windows.Forms.TextBox();
            this.btOFD = new System.Windows.Forms.Button();
            this.gbAInfo = new System.Windows.Forms.GroupBox();
            this.lIClearFormItems = new System.Windows.Forms.LinkLabel();
            this.labNPunct = new System.Windows.Forms.Label();
            this.tbNPunct = new System.Windows.Forms.TextBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAPhoto)).BeginInit();
            this.gbAInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(350, 54);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(249, 225);
            this.lbAuthors.TabIndex = 14;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            // 
            // pbAPhoto
            // 
            this.pbAPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAPhoto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbAPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAPhoto.Image = global::Recipe_Book.Properties.Resources.Users_Cook_icon6;
            this.pbAPhoto.Location = new System.Drawing.Point(350, 285);
            this.pbAPhoto.Name = "pbAPhoto";
            this.pbAPhoto.Size = new System.Drawing.Size(249, 170);
            this.pbAPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAPhoto.TabIndex = 15;
            this.pbAPhoto.TabStop = false;
            // 
            // addAutor
            // 
            this.addAutor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addAutor.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAutor.Image = global::Recipe_Book.Properties.Resources.Users_Cook_icon5;
            this.addAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAutor.Location = new System.Drawing.Point(12, 290);
            this.addAutor.Name = "addAutor";
            this.addAutor.Size = new System.Drawing.Size(322, 48);
            this.addAutor.TabIndex = 16;
            this.addAutor.Text = "Додати дані";
            this.addAutor.UseVisualStyleBackColor = false;
            this.addAutor.Click += new System.EventHandler(this.addAutor_Click);
            // 
            // delAuthor
            // 
            this.delAuthor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.delAuthor.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAuthor.Image = global::Recipe_Book.Properties.Resources.Editing_Delete_icon1;
            this.delAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delAuthor.Location = new System.Drawing.Point(12, 349);
            this.delAuthor.Name = "delAuthor";
            this.delAuthor.Size = new System.Drawing.Size(322, 48);
            this.delAuthor.TabIndex = 17;
            this.delAuthor.Text = "Видалити дані";
            this.delAuthor.UseVisualStyleBackColor = false;
            this.delAuthor.Click += new System.EventHandler(this.delAuthor_Click);
            // 
            // editAuthor
            // 
            this.editAuthor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.editAuthor.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAuthor.Image = global::Recipe_Book.Properties.Resources._64x64_black_white_metro_edit_icon;
            this.editAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editAuthor.Location = new System.Drawing.Point(12, 408);
            this.editAuthor.Name = "editAuthor";
            this.editAuthor.Size = new System.Drawing.Size(322, 48);
            this.editAuthor.TabIndex = 18;
            this.editAuthor.Text = "Редагувати дані";
            this.editAuthor.UseVisualStyleBackColor = false;
            this.editAuthor.Click += new System.EventHandler(this.editAuthor_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(113, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 24);
            this.tbName.TabIndex = 0;
            // 
            // tbLName
            // 
            this.tbLName.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLName.Location = new System.Drawing.Point(113, 48);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(200, 24);
            this.tbLName.TabIndex = 1;
            // 
            // tbPName
            // 
            this.tbPName.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPName.Location = new System.Drawing.Point(113, 74);
            this.tbPName.Name = "tbPName";
            this.tbPName.Size = new System.Drawing.Size(200, 24);
            this.tbPName.TabIndex = 2;
            // 
            // tbOblast
            // 
            this.tbOblast.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOblast.Location = new System.Drawing.Point(113, 100);
            this.tbOblast.Multiline = true;
            this.tbOblast.Name = "tbOblast";
            this.tbOblast.Size = new System.Drawing.Size(200, 23);
            this.tbOblast.TabIndex = 3;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(113, 158);
            this.dtpBirth.MaxDate = new System.DateTime(2014, 6, 2, 0, 0, 0, 0);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(200, 24);
            this.dtpBirth.TabIndex = 5;
            this.dtpBirth.Value = new System.DateTime(2014, 5, 14, 1, 25, 29, 0);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.SystemColors.Control;
            this.lbName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbName.Location = new System.Drawing.Point(76, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(28, 15);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Ім\'я";
            // 
            // lbLname
            // 
            this.lbLname.AutoSize = true;
            this.lbLname.BackColor = System.Drawing.SystemColors.Control;
            this.lbLname.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbLname.Location = new System.Drawing.Point(51, 51);
            this.lbLname.Name = "lbLname";
            this.lbLname.Size = new System.Drawing.Size(53, 15);
            this.lbLname.TabIndex = 6;
            this.lbLname.Text = "Прізвище";
            // 
            // lbPname
            // 
            this.lbPname.AutoSize = true;
            this.lbPname.BackColor = System.Drawing.SystemColors.Control;
            this.lbPname.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbPname.Location = new System.Drawing.Point(36, 77);
            this.lbPname.Name = "lbPname";
            this.lbPname.Size = new System.Drawing.Size(68, 15);
            this.lbPname.TabIndex = 7;
            this.lbPname.Text = "По батькові";
            // 
            // lbOblast
            // 
            this.lbOblast.AutoSize = true;
            this.lbOblast.BackColor = System.Drawing.SystemColors.Control;
            this.lbOblast.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbOblast.Location = new System.Drawing.Point(56, 103);
            this.lbOblast.Name = "lbOblast";
            this.lbOblast.Size = new System.Drawing.Size(48, 15);
            this.lbOblast.TabIndex = 8;
            this.lbOblast.Text = "Область";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.BackColor = System.Drawing.SystemColors.Control;
            this.lbBirthday.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbBirthday.Location = new System.Drawing.Point(9, 158);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(95, 15);
            this.lbBirthday.TabIndex = 9;
            this.lbBirthday.Text = "Дата народження";
            // 
            // lbOFD
            // 
            this.lbOFD.AutoSize = true;
            this.lbOFD.BackColor = System.Drawing.SystemColors.Control;
            this.lbOFD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbOFD.Location = new System.Drawing.Point(35, 188);
            this.lbOFD.Name = "lbOFD";
            this.lbOFD.Size = new System.Drawing.Size(69, 15);
            this.lbOFD.TabIndex = 10;
            this.lbOFD.Text = "Фотографія";
            // 
            // tbOFD
            // 
            this.tbOFD.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOFD.Location = new System.Drawing.Point(170, 184);
            this.tbOFD.Name = "tbOFD";
            this.tbOFD.ReadOnly = true;
            this.tbOFD.Size = new System.Drawing.Size(143, 24);
            this.tbOFD.TabIndex = 7;
            // 
            // btOFD
            // 
            this.btOFD.Location = new System.Drawing.Point(113, 184);
            this.btOFD.Name = "btOFD";
            this.btOFD.Size = new System.Drawing.Size(51, 22);
            this.btOFD.TabIndex = 6;
            this.btOFD.Text = "Файл";
            this.btOFD.UseVisualStyleBackColor = true;
            this.btOFD.Click += new System.EventHandler(this.btOFD_Click);
            // 
            // gbAInfo
            // 
            this.gbAInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbAInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbAInfo.Controls.Add(this.lIClearFormItems);
            this.gbAInfo.Controls.Add(this.labNPunct);
            this.gbAInfo.Controls.Add(this.tbNPunct);
            this.gbAInfo.Controls.Add(this.btOFD);
            this.gbAInfo.Controls.Add(this.tbOFD);
            this.gbAInfo.Controls.Add(this.lbOFD);
            this.gbAInfo.Controls.Add(this.lbBirthday);
            this.gbAInfo.Controls.Add(this.lbOblast);
            this.gbAInfo.Controls.Add(this.lbPname);
            this.gbAInfo.Controls.Add(this.lbLname);
            this.gbAInfo.Controls.Add(this.lbName);
            this.gbAInfo.Controls.Add(this.dtpBirth);
            this.gbAInfo.Controls.Add(this.tbOblast);
            this.gbAInfo.Controls.Add(this.tbPName);
            this.gbAInfo.Controls.Add(this.tbLName);
            this.gbAInfo.Controls.Add(this.tbName);
            this.gbAInfo.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAInfo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbAInfo.Location = new System.Drawing.Point(12, 47);
            this.gbAInfo.Name = "gbAInfo";
            this.gbAInfo.Size = new System.Drawing.Size(322, 232);
            this.gbAInfo.TabIndex = 13;
            this.gbAInfo.TabStop = false;
            this.gbAInfo.Text = "Інформація про авторів рецептів";
            // 
            // lIClearFormItems
            // 
            this.lIClearFormItems.AutoSize = true;
            this.lIClearFormItems.BackColor = System.Drawing.SystemColors.Control;
            this.lIClearFormItems.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lIClearFormItems.Location = new System.Drawing.Point(6, 217);
            this.lIClearFormItems.Name = "lIClearFormItems";
            this.lIClearFormItems.Size = new System.Drawing.Size(101, 15);
            this.lIClearFormItems.TabIndex = 20;
            this.lIClearFormItems.TabStop = true;
            this.lIClearFormItems.Text = "Очистити всі поля";
            this.lIClearFormItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lIClearFormItems_LinkClicked);
            // 
            // labNPunct
            // 
            this.labNPunct.AutoSize = true;
            this.labNPunct.BackColor = System.Drawing.SystemColors.Control;
            this.labNPunct.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labNPunct.Location = new System.Drawing.Point(13, 132);
            this.labNPunct.Name = "labNPunct";
            this.labNPunct.Size = new System.Drawing.Size(91, 15);
            this.labNPunct.TabIndex = 14;
            this.labNPunct.Text = "Населений пункт";
            // 
            // tbNPunct
            // 
            this.tbNPunct.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNPunct.Location = new System.Drawing.Point(113, 129);
            this.tbNPunct.Multiline = true;
            this.tbNPunct.Name = "tbNPunct";
            this.tbNPunct.Size = new System.Drawing.Size(200, 23);
            this.tbNPunct.TabIndex = 4;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWelcome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbWelcome.Location = new System.Drawing.Point(108, 5);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(409, 27);
            this.lbWelcome.TabIndex = 19;
            this.lbWelcome.Text = "Керування інформацією про авторів рецептів";
            // 
            // FormAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Recipe_Book.Properties.Resources.paper66;
            this.ClientSize = new System.Drawing.Size(609, 467);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.editAuthor);
            this.Controls.Add(this.delAuthor);
            this.Controls.Add(this.addAutor);
            this.Controls.Add(this.pbAPhoto);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.gbAInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Керування авторами рецептів";
            this.Load += new System.EventHandler(this.FormAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAPhoto)).EndInit();
            this.gbAInfo.ResumeLayout(false);
            this.gbAInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.PictureBox pbAPhoto;
        private System.Windows.Forms.Button addAutor;
        private System.Windows.Forms.Button delAuthor;
        private System.Windows.Forms.Button editAuthor;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbPName;
        private System.Windows.Forms.TextBox tbOblast;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.Label lbPname;
        private System.Windows.Forms.Label lbOblast;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbOFD;
        private System.Windows.Forms.TextBox tbOFD;
        private System.Windows.Forms.Button btOFD;
        public System.Windows.Forms.GroupBox gbAInfo;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label labNPunct;
        private System.Windows.Forms.TextBox tbNPunct;
        private System.Windows.Forms.LinkLabel lIClearFormItems;
    }
}