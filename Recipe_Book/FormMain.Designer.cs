namespace Recipe_Book
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btAuthor = new System.Windows.Forms.Button();
            this.btR = new System.Windows.Forms.Button();
            this.btT = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.lLSerialization = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btAuthor
            // 
            this.btAuthor.BackgroundImage = global::Recipe_Book.Properties.Resources.pomid;
            resources.ApplyResources(this.btAuthor, "btAuthor");
            this.btAuthor.ForeColor = System.Drawing.Color.GhostWhite;
            this.btAuthor.Name = "btAuthor";
            this.btAuthor.UseVisualStyleBackColor = true;
            this.btAuthor.Click += new System.EventHandler(this.btAuthor_Click);
            // 
            // btR
            // 
            this.btR.BackgroundImage = global::Recipe_Book.Properties.Resources.kap;
            resources.ApplyResources(this.btR, "btR");
            this.btR.ForeColor = System.Drawing.Color.GhostWhite;
            this.btR.Name = "btR";
            this.btR.UseVisualStyleBackColor = true;
            this.btR.Click += new System.EventHandler(this.btR_Click);
            // 
            // btT
            // 
            this.btT.BackgroundImage = global::Recipe_Book.Properties.Resources.huh;
            resources.ApplyResources(this.btT, "btT");
            this.btT.ForeColor = System.Drawing.Color.GhostWhite;
            this.btT.Name = "btT";
            this.btT.UseVisualStyleBackColor = true;
            this.btT.Click += new System.EventHandler(this.btT_Click);
            // 
            // btAbout
            // 
            this.btAbout.BackColor = System.Drawing.Color.Transparent;
            this.btAbout.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btAbout.FlatAppearance.BorderSize = 3;
            this.btAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btAbout, "btAbout");
            this.btAbout.ForeColor = System.Drawing.Color.GhostWhite;
            this.btAbout.Image = global::Recipe_Book.Properties.Resources.Без_імені1;
            this.btAbout.Name = "btAbout";
            this.btAbout.UseVisualStyleBackColor = false;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // lLSerialization
            // 
            this.lLSerialization.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.lLSerialization, "lLSerialization");
            this.lLSerialization.BackColor = System.Drawing.Color.Transparent;
            this.lLSerialization.LinkColor = System.Drawing.Color.Gray;
            this.lLSerialization.Name = "lLSerialization";
            this.lLSerialization.TabStop = true;
            this.lLSerialization.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLSerialization_LinkClicked);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Recipe_Book.Properties.Resources.cookbook1;
            this.Controls.Add(this.lLSerialization);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.btT);
            this.Controls.Add(this.btR);
            this.Controls.Add(this.btAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAuthor;
        private System.Windows.Forms.Button btR;
        private System.Windows.Forms.Button btT;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.LinkLabel lLSerialization;
    }
}

