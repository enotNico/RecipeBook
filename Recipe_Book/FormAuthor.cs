using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Recipe_Book.Properties;

namespace Recipe_Book
{
    public partial class FormAuthor : Form
    {
        public FormAuthor()
        {
            InitializeComponent();
        }
        OpenFileDialog OFD = new OpenFileDialog();

        private void FormAuthor_Load(object sender, EventArgs e)
        {
            LbAuthorRefresh();
            ClearControls();
        }
        private void btOFD_Click(object sender, EventArgs e)
        {
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                OFD.Multiselect = false;
                OFD.Filter = "Images (*.jpg; *.png)|*.jpg; *.png;";
                tbOFD.Text = OFD.FileName;
            } 
        }

        private void LbAuthorRefresh()
        {
            lbAuthors.DataSource = null;
            lbAuthors.DataSource = Author.Authors;
        }

        private Author aut;

        private void addAutor_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbLName.Text == "" || tbPName.Text == "" || tbOblast.Text == "" ||
                tbNPunct.Text == "" || tbOFD.Text == "")
            {
                MessageBox.Show("Вкажіть будь ласка свої дані!", "Увага!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            string Img = Author.CopyImageFile(tbOFD.Text);

            aut = new Author(tbName.Text, tbLName.Text, tbPName.Text, tbOblast.Text, tbNPunct.Text, dtpBirth.Value, Img);
            LbAuthorRefresh();
            ClearControls();
        }

        private void delAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var authors in Recipe.Items.Values)
                {
                    if ((Author) lbAuthors.SelectedItem == authors.RAuthor)
                    {
                        MessageBox.Show("Даного автора видалити неможливо, оскільки є рецепти які створені ним!",
                            "Відмова!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    ClearControls();
                    return;
                } 
                string DelPath = ((Author)lbAuthors.SelectedItem).AImage;
                Author.Authors.Remove((Author) lbAuthors.SelectedItem);
                Author.AddToDeleteFile(DelPath);
            }
            catch
            {
                MessageBox.Show("Виділіть зі списку автора, якого бажаєте видалити!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LbAuthorRefresh(); 
            ClearControls();
        }

        private void editAuthor_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbLName.Text == "" || tbPName.Text == "" || tbOblast.Text == "" ||
                tbNPunct.Text == "" || tbOFD.Text == "")
            {
                MessageBox.Show("Вкажіть будь ласка свої дані!", "Увага!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            foreach (var authors in Recipe.Items.Values)
            {
                if ((Author)lbAuthors.SelectedItem == authors.RAuthor)
                    MessageBox.Show("Даного автора редагувати неможливо, оскільки є рецепти які створені ним!", "Відмова!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearControls();
                return;
            }
            try
            {
                ((Author) lbAuthors.SelectedItem).Name = tbName.Text;
                ((Author) lbAuthors.SelectedItem).LName = tbLName.Text;
                ((Author) lbAuthors.SelectedItem).PName = tbPName.Text;
                ((Author) lbAuthors.SelectedItem).Oblast = tbOblast.Text;
                ((Author) lbAuthors.SelectedItem).NPunct = tbNPunct.Text;
                ((Author) lbAuthors.SelectedItem).Birth = dtpBirth.Value;
                string DelImageFile = ((Author)lbAuthors.SelectedItem).AImage;
                Author.AddToDeleteFile(DelImageFile);
                string EditImgPath = Author.CopyImageFile(tbOFD.Text);
                ((Author) lbAuthors.SelectedItem).AImage = EditImgPath;

                LbAuthorRefresh();
                ClearControls();
            }
            catch
            {
                MessageBox.Show("Виділіть будь-ласка автора зі списку, дані якого бажаєте відредагувати!","Увага!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAuthors.SelectedItem == null)
                return;
            tbName.Text = ((Author)lbAuthors.SelectedItem).Name;
            tbLName.Text = ((Author)lbAuthors.SelectedItem).LName;
            tbPName.Text = ((Author)lbAuthors.SelectedItem).PName;
            tbOblast.Text = ((Author)lbAuthors.SelectedItem).Oblast;
            tbNPunct.Text = ((Author)lbAuthors.SelectedItem).NPunct;
            dtpBirth.Value = ((Author)lbAuthors.SelectedItem).Birth;
            tbOFD.Text = ((Author)lbAuthors.SelectedItem).AImage;
            try
            {
                pbAPhoto.Image = Image.FromFile(((Author) lbAuthors.SelectedItem).AImage);
            }
            catch
            {
                pbAPhoto.Image = Resources.Users_Cook_icon6;
            }
        }

        private void ClearControls()
        {
            tbLName.Text = "";
            tbName.Text = "";
            tbPName.Text = "";
            tbOblast.Text = "";
            tbNPunct.Text = "";
            tbOFD.Text = "";
            dtpBirth.Value = dtpBirth.MaxDate;
            pbAPhoto.Image = Resources.Users_Cook_icon6;
            lbAuthors.SelectedItem = null;
        }

        private void lIClearFormItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearControls();
        }
    }
}
