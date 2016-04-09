namespace Recipe_Book
{
    partial class FormSerializationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerializationPanel));
            this.btExport = new System.Windows.Forms.Button();
            this.btDeserialization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btExport
            // 
            this.btExport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btExport.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExport.Location = new System.Drawing.Point(9, 12);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(248, 60);
            this.btExport.TabIndex = 0;
            this.btExport.Text = "Експортувати дані в XML файл";
            this.btExport.UseVisualStyleBackColor = false;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btDeserialization
            // 
            this.btDeserialization.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btDeserialization.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeserialization.Location = new System.Drawing.Point(9, 87);
            this.btDeserialization.Name = "btDeserialization";
            this.btDeserialization.Size = new System.Drawing.Size(248, 60);
            this.btDeserialization.TabIndex = 1;
            this.btDeserialization.Text = "Імпортувати дані в програму з XML файлу";
            this.btDeserialization.UseVisualStyleBackColor = false;
            this.btDeserialization.Click += new System.EventHandler(this.btDeserialization_Click);
            // 
            // FormSerializationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Recipe_Book.Properties.Resources.pri_khranenii_produktov_v_kholodilnike;
            this.ClientSize = new System.Drawing.Size(262, 160);
            this.Controls.Add(this.btDeserialization);
            this.Controls.Add(this.btExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSerializationPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Імпорт та експорт даних";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btDeserialization;
    }
}