namespace Recipe_Book
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.tbPrName = new System.Windows.Forms.TextBox();
            this.lbProduct = new System.Windows.Forms.ListBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.panelNote = new System.Windows.Forms.Panel();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.lLClearControls = new System.Windows.Forms.LinkLabel();
            this.tbPrPrice = new System.Windows.Forms.TextBox();
            this.btPrAdd = new System.Windows.Forms.Button();
            this.btPrDel = new System.Windows.Forms.Button();
            this.btPrEdit = new System.Windows.Forms.Button();
            this.panelBoard.SuspendLayout();
            this.panelNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPrName
            // 
            this.tbPrName.Location = new System.Drawing.Point(14, 70);
            this.tbPrName.Name = "tbPrName";
            this.tbPrName.Size = new System.Drawing.Size(148, 20);
            this.tbPrName.TabIndex = 0;
            // 
            // lbProduct
            // 
            this.lbProduct.FormattingEnabled = true;
            this.lbProduct.Location = new System.Drawing.Point(18, 81);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(169, 290);
            this.lbProduct.TabIndex = 1;
            this.lbProduct.SelectedIndexChanged += new System.EventHandler(this.lbProduct_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(11, 48);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(86, 15);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Назва продукту";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPrice.Location = new System.Drawing.Point(11, 103);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(108, 15);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Ціна продукту (грн.)";
            // 
            // panelBoard
            // 
            this.panelBoard.BackgroundImage = global::Recipe_Book.Properties.Resources.VS_811623;
            this.panelBoard.Controls.Add(this.lbProduct);
            this.panelBoard.Location = new System.Drawing.Point(213, 12);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(203, 390);
            this.panelBoard.TabIndex = 5;
            // 
            // panelNote
            // 
            this.panelNote.BackgroundImage = global::Recipe_Book.Properties.Resources.notepad_1083254_m1;
            this.panelNote.Controls.Add(this.tbAmount);
            this.panelNote.Controls.Add(this.labelAmount);
            this.panelNote.Controls.Add(this.lLClearControls);
            this.panelNote.Controls.Add(this.tbPrPrice);
            this.panelNote.Controls.Add(this.lbName);
            this.panelNote.Controls.Add(this.lbPrice);
            this.panelNote.Controls.Add(this.tbPrName);
            this.panelNote.Location = new System.Drawing.Point(12, 12);
            this.panelNote.Name = "panelNote";
            this.panelNote.Size = new System.Drawing.Size(180, 240);
            this.panelNote.TabIndex = 6;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(14, 179);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(148, 20);
            this.tbAmount.TabIndex = 8;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(11, 157);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(106, 15);
            this.labelAmount.TabIndex = 7;
            this.labelAmount.Text = "Кількість продукту";
            // 
            // lLClearControls
            // 
            this.lLClearControls.AutoSize = true;
            this.lLClearControls.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLClearControls.Location = new System.Drawing.Point(11, 216);
            this.lLClearControls.Name = "lLClearControls";
            this.lLClearControls.Size = new System.Drawing.Size(86, 15);
            this.lLClearControls.TabIndex = 6;
            this.lLClearControls.TabStop = true;
            this.lLClearControls.Text = "Очистити поля";
            this.lLClearControls.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLClearControls_LinkClicked);
            // 
            // tbPrPrice
            // 
            this.tbPrPrice.Location = new System.Drawing.Point(14, 124);
            this.tbPrPrice.Name = "tbPrPrice";
            this.tbPrPrice.Size = new System.Drawing.Size(148, 20);
            this.tbPrPrice.TabIndex = 5;
            this.tbPrPrice.TextChanged += new System.EventHandler(this.tbPrPrice_TextChanged);
            // 
            // btPrAdd
            // 
            this.btPrAdd.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPrAdd.Location = new System.Drawing.Point(12, 258);
            this.btPrAdd.Name = "btPrAdd";
            this.btPrAdd.Size = new System.Drawing.Size(180, 44);
            this.btPrAdd.TabIndex = 7;
            this.btPrAdd.Text = "Додати продукт";
            this.btPrAdd.UseVisualStyleBackColor = true;
            this.btPrAdd.Click += new System.EventHandler(this.btPrAdd_Click);
            // 
            // btPrDel
            // 
            this.btPrDel.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPrDel.Location = new System.Drawing.Point(12, 308);
            this.btPrDel.Name = "btPrDel";
            this.btPrDel.Size = new System.Drawing.Size(180, 44);
            this.btPrDel.TabIndex = 8;
            this.btPrDel.Text = "Видалити продукт";
            this.btPrDel.UseVisualStyleBackColor = true;
            this.btPrDel.Click += new System.EventHandler(this.btPrDel_Click);
            // 
            // btPrEdit
            // 
            this.btPrEdit.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPrEdit.Location = new System.Drawing.Point(12, 358);
            this.btPrEdit.Name = "btPrEdit";
            this.btPrEdit.Size = new System.Drawing.Size(180, 44);
            this.btPrEdit.TabIndex = 9;
            this.btPrEdit.Text = "Редагувати продукт";
            this.btPrEdit.UseVisualStyleBackColor = true;
            this.btPrEdit.Click += new System.EventHandler(this.btPrEdit_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Recipe_Book.Properties.Resources.products_01;
            this.ClientSize = new System.Drawing.Size(424, 407);
            this.Controls.Add(this.btPrEdit);
            this.Controls.Add(this.btPrDel);
            this.Controls.Add(this.btPrAdd);
            this.Controls.Add(this.panelNote);
            this.Controls.Add(this.panelBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продукти";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.panelBoard.ResumeLayout(false);
            this.panelNote.ResumeLayout(false);
            this.panelNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrName;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Panel panelNote;
        private System.Windows.Forms.Button btPrAdd;
        private System.Windows.Forms.Button btPrDel;
        private System.Windows.Forms.Button btPrEdit;
        private System.Windows.Forms.TextBox tbPrPrice;
        private System.Windows.Forms.LinkLabel lLClearControls;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label labelAmount;
    }
}