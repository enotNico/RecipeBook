namespace Recipe_Book
{
    partial class FormRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecipe));
            this.labelTop = new System.Windows.Forms.Label();
            this.tbRecName = new System.Windows.Forms.TextBox();
            this.cbRecAuthor = new System.Windows.Forms.ComboBox();
            this.tbRecipe = new System.Windows.Forms.TextBox();
            this.lbSelectProd = new System.Windows.Forms.ListBox();
            this.SelectProd = new System.Windows.Forms.Label();
            this.labelRecipe = new System.Windows.Forms.Label();
            this.labelRecAuthor = new System.Windows.Forms.Label();
            this.labelRecName = new System.Windows.Forms.Label();
            this.panelChangeInfo = new System.Windows.Forms.Panel();
            this.lLClearControls = new System.Windows.Forms.LinkLabel();
            this.btReDelete = new System.Windows.Forms.Button();
            this.btReEdit = new System.Windows.Forms.Button();
            this.btReAdd = new System.Windows.Forms.Button();
            this.lbRezept = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btShowDetailRecipe = new System.Windows.Forms.Button();
            this.panelChangeInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.BackColor = System.Drawing.Color.Transparent;
            this.labelTop.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTop.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTop.Location = new System.Drawing.Point(380, 16);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(101, 33);
            this.labelTop.TabIndex = 10;
            this.labelTop.Text = "Рецепти";
            // 
            // tbRecName
            // 
            this.tbRecName.Location = new System.Drawing.Point(215, 77);
            this.tbRecName.Name = "tbRecName";
            this.tbRecName.Size = new System.Drawing.Size(302, 20);
            this.tbRecName.TabIndex = 0;
            // 
            // cbRecAuthor
            // 
            this.cbRecAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecAuthor.FormattingEnabled = true;
            this.cbRecAuthor.Location = new System.Drawing.Point(215, 116);
            this.cbRecAuthor.Name = "cbRecAuthor";
            this.cbRecAuthor.Size = new System.Drawing.Size(302, 21);
            this.cbRecAuthor.TabIndex = 1;
            // 
            // tbRecipe
            // 
            this.tbRecipe.Location = new System.Drawing.Point(215, 156);
            this.tbRecipe.Multiline = true;
            this.tbRecipe.Name = "tbRecipe";
            this.tbRecipe.Size = new System.Drawing.Size(302, 302);
            this.tbRecipe.TabIndex = 2;
            // 
            // lbSelectProd
            // 
            this.lbSelectProd.FormattingEnabled = true;
            this.lbSelectProd.Location = new System.Drawing.Point(15, 77);
            this.lbSelectProd.Name = "lbSelectProd";
            this.lbSelectProd.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSelectProd.Size = new System.Drawing.Size(194, 368);
            this.lbSelectProd.TabIndex = 3;
            // 
            // SelectProd
            // 
            this.SelectProd.AutoSize = true;
            this.SelectProd.BackColor = System.Drawing.Color.Transparent;
            this.SelectProd.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectProd.Location = new System.Drawing.Point(12, 59);
            this.SelectProd.Name = "SelectProd";
            this.SelectProd.Size = new System.Drawing.Size(199, 15);
            this.SelectProd.TabIndex = 5;
            this.SelectProd.Text = "Виберіть продукти які будуть в страві";
            // 
            // labelRecipe
            // 
            this.labelRecipe.AutoSize = true;
            this.labelRecipe.BackColor = System.Drawing.Color.Transparent;
            this.labelRecipe.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecipe.Location = new System.Drawing.Point(330, 138);
            this.labelRecipe.Name = "labelRecipe";
            this.labelRecipe.Size = new System.Drawing.Size(73, 15);
            this.labelRecipe.TabIndex = 7;
            this.labelRecipe.Text = "Опис рецепту";
            // 
            // labelRecAuthor
            // 
            this.labelRecAuthor.AutoSize = true;
            this.labelRecAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelRecAuthor.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecAuthor.Location = new System.Drawing.Point(330, 98);
            this.labelRecAuthor.Name = "labelRecAuthor";
            this.labelRecAuthor.Size = new System.Drawing.Size(82, 15);
            this.labelRecAuthor.TabIndex = 8;
            this.labelRecAuthor.Text = "Автор рецепту";
            // 
            // labelRecName
            // 
            this.labelRecName.AutoSize = true;
            this.labelRecName.BackColor = System.Drawing.Color.Transparent;
            this.labelRecName.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecName.Location = new System.Drawing.Point(329, 59);
            this.labelRecName.Name = "labelRecName";
            this.labelRecName.Size = new System.Drawing.Size(78, 15);
            this.labelRecName.TabIndex = 9;
            this.labelRecName.Text = "Назва рецепту";
            // 
            // panelChangeInfo
            // 
            this.panelChangeInfo.BackgroundImage = global::Recipe_Book.Properties.Resources.oldKar;
            this.panelChangeInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChangeInfo.Controls.Add(this.lLClearControls);
            this.panelChangeInfo.Controls.Add(this.btReDelete);
            this.panelChangeInfo.Controls.Add(this.btReEdit);
            this.panelChangeInfo.Controls.Add(this.btReAdd);
            this.panelChangeInfo.Controls.Add(this.labelRecName);
            this.panelChangeInfo.Controls.Add(this.labelRecAuthor);
            this.panelChangeInfo.Controls.Add(this.labelRecipe);
            this.panelChangeInfo.Controls.Add(this.tbRecName);
            this.panelChangeInfo.Controls.Add(this.cbRecAuthor);
            this.panelChangeInfo.Controls.Add(this.SelectProd);
            this.panelChangeInfo.Controls.Add(this.tbRecipe);
            this.panelChangeInfo.Controls.Add(this.lbSelectProd);
            this.panelChangeInfo.Location = new System.Drawing.Point(11, 52);
            this.panelChangeInfo.Name = "panelChangeInfo";
            this.panelChangeInfo.Size = new System.Drawing.Size(533, 520);
            this.panelChangeInfo.TabIndex = 11;
            // 
            // lLClearControls
            // 
            this.lLClearControls.ActiveLinkColor = System.Drawing.Color.Lime;
            this.lLClearControls.AutoSize = true;
            this.lLClearControls.BackColor = System.Drawing.Color.Transparent;
            this.lLClearControls.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLClearControls.LinkColor = System.Drawing.Color.Olive;
            this.lLClearControls.Location = new System.Drawing.Point(62, 445);
            this.lLClearControls.Name = "lLClearControls";
            this.lLClearControls.Size = new System.Drawing.Size(101, 15);
            this.lLClearControls.TabIndex = 13;
            this.lLClearControls.TabStop = true;
            this.lLClearControls.Text = "Очистити всі поля";
            this.lLClearControls.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLClearControls_LinkClicked);
            // 
            // btReDelete
            // 
            this.btReDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btReDelete.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btReDelete.Location = new System.Drawing.Point(15, 464);
            this.btReDelete.Name = "btReDelete";
            this.btReDelete.Size = new System.Drawing.Size(128, 45);
            this.btReDelete.TabIndex = 12;
            this.btReDelete.Text = "Видалити рецепт";
            this.btReDelete.UseVisualStyleBackColor = false;
            this.btReDelete.Click += new System.EventHandler(this.btReDelete_Click);
            // 
            // btReEdit
            // 
            this.btReEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btReEdit.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btReEdit.Location = new System.Drawing.Point(389, 464);
            this.btReEdit.Name = "btReEdit";
            this.btReEdit.Size = new System.Drawing.Size(128, 45);
            this.btReEdit.TabIndex = 11;
            this.btReEdit.Text = "Редагувати рецепт";
            this.btReEdit.UseVisualStyleBackColor = false;
            this.btReEdit.Click += new System.EventHandler(this.btReEdit_Click);
            // 
            // btReAdd
            // 
            this.btReAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btReAdd.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btReAdd.Location = new System.Drawing.Point(149, 464);
            this.btReAdd.Name = "btReAdd";
            this.btReAdd.Size = new System.Drawing.Size(234, 45);
            this.btReAdd.TabIndex = 10;
            this.btReAdd.Text = "Додати рецепт до списку";
            this.btReAdd.UseVisualStyleBackColor = false;
            this.btReAdd.Click += new System.EventHandler(this.btReAdd_Click);
            // 
            // lbRezept
            // 
            this.lbRezept.FormattingEnabled = true;
            this.lbRezept.Location = new System.Drawing.Point(15, 115);
            this.lbRezept.Name = "lbRezept";
            this.lbRezept.Size = new System.Drawing.Size(236, 355);
            this.lbRezept.TabIndex = 12;
            this.lbRezept.SelectedIndexChanged += new System.EventHandler(this.lbRezept_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Recipe_Book.Properties.Resources.старая_бумага_14920112;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btShowDetailRecipe);
            this.panel2.Controls.Add(this.lbRezept);
            this.panel2.Location = new System.Drawing.Point(561, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 520);
            this.panel2.TabIndex = 13;
            // 
            // btShowDetailRecipe
            // 
            this.btShowDetailRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.btShowDetailRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btShowDetailRecipe.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btShowDetailRecipe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btShowDetailRecipe.Location = new System.Drawing.Point(15, 464);
            this.btShowDetailRecipe.Name = "btShowDetailRecipe";
            this.btShowDetailRecipe.Size = new System.Drawing.Size(236, 45);
            this.btShowDetailRecipe.TabIndex = 14;
            this.btShowDetailRecipe.Text = "Переглянути рецепт детальніше";
            this.btShowDetailRecipe.UseVisualStyleBackColor = false;
            this.btShowDetailRecipe.Click += new System.EventHandler(this.btShowDetailRecipe_Click);
            // 
            // FormRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Recipe_Book.Properties.Resources.kak_zakonservirovat_borshh_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChangeInfo);
            this.Controls.Add(this.labelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рецепти";
            this.Load += new System.EventHandler(this.FormRecipe_Load);
            this.panelChangeInfo.ResumeLayout(false);
            this.panelChangeInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.TextBox tbRecName;
        private System.Windows.Forms.ComboBox cbRecAuthor;
        private System.Windows.Forms.TextBox tbRecipe;
        private System.Windows.Forms.ListBox lbSelectProd;
        private System.Windows.Forms.Label SelectProd;
        private System.Windows.Forms.Label labelRecipe;
        private System.Windows.Forms.Label labelRecAuthor;
        private System.Windows.Forms.Label labelRecName;
        private System.Windows.Forms.Panel panelChangeInfo;
        private System.Windows.Forms.ListBox lbRezept;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btReDelete;
        private System.Windows.Forms.Button btReEdit;
        private System.Windows.Forms.Button btReAdd;
        private System.Windows.Forms.LinkLabel lLClearControls;
        private System.Windows.Forms.Button btShowDetailRecipe;
    }
}