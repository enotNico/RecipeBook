using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recipe_Book.Properties;

namespace Recipe_Book
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        { }

        FormAuthor fA = new FormAuthor();

        private void btAuthor_Click(object sender, EventArgs e)
        {
            fA.ShowDialog();
        }

        FormProduct formProduct = new FormProduct();
        private void btR_Click(object sender, EventArgs e)
        {
            formProduct.ShowDialog();
        }

        FormRecipe formRecipe = new FormRecipe();
        private void btT_Click(object sender, EventArgs e)
        {
            formRecipe.ShowDialog();
        }

        FormAbout fAb = new FormAbout();
        private void btAbout_Click(object sender, EventArgs e)
        {
            fAb.ShowDialog();
        }

        FormSerializationPanel formSerializationPanel = new FormSerializationPanel();
        private void lLSerialization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formSerializationPanel.ShowDialog();
        }
    }
}
