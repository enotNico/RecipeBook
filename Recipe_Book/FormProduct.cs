using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Recipe_Book
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void RefreshLbProduct()
        {
            lbProduct.DataSource = null;
            lbProduct.DataSource = Product.Items.Values.ToList();
        }

        private void btPrAdd_Click(object sender, EventArgs e)
        {
            if (tbPrName.Text == "" || tbPrPrice.Text == "" || tbAmount.Text == "")
            {
                MessageBox.Show("Введіть всі дані!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Product pr = new Product(tbPrName.Text, double.Parse(tbPrPrice.Text), double.Parse(tbAmount.Text));
            }
            catch
            {
                MessageBox.Show("Введені недопустимі значення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            RefreshLbProduct();
            ClearPControls();
        }

        private void btPrDel_Click(object sender, EventArgs e)
        {
            foreach (var ob in Recipe.Items.Values)
            {
                foreach (var products in ob.Products)
                {
                    if ((Product) lbProduct.SelectedItem == products)
                    {
                        MessageBox.Show("Даний продукт видалити неможливо, оскільки він присутній в рецепті!",
                            "Відмова!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearPControls();
                        return;
                    }
                }
            }
            try
            {
                Product.Items.Remove(((Product) lbProduct.SelectedItem).Id);
            }
                catch
                {
                    MessageBox.Show("Виберіть продукт для видалення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            RefreshLbProduct();
            ClearPControls();
        }

        private void btPrEdit_Click(object sender, EventArgs e)
        {
            if (tbPrName.Text == "" || tbPrPrice.Text == "" || tbAmount.Text == "")
            {
                MessageBox.Show("Введіть всі дані!");
                return;
            }
            foreach (var ob in Recipe.Items.Values)
            {
                foreach (var products in ob.Products)
                {
                    if ((Product) lbProduct.SelectedItem == products)
                    {
                        MessageBox.Show("Даний продукт редагувати неможливо, оскільки він присутній в рецепті!",
                            "Відмова!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearPControls();
                        return;
                    }
                }
            }
            try
            {
                ((Product) lbProduct.SelectedItem).Name = tbPrName.Text;
                ((Product) lbProduct.SelectedItem).Price = double.Parse(tbPrPrice.Text);
                ((Product) lbProduct.SelectedItem).Amount = double.Parse(tbAmount.Text);
            }
            catch
            {
                MessageBox.Show("Виберіть зі списку продукт, який бажаєте редагувати!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            RefreshLbProduct();
            ClearPControls();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            RefreshLbProduct();
            ClearPControls();
        }

        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProduct.SelectedItem == null)
                return;
            tbPrName.Text = ((Product) lbProduct.SelectedItem).Name;
            tbPrPrice.Text = Convert.ToString(((Product) lbProduct.SelectedItem).Price);
            tbAmount.Text = Convert.ToString(((Product) lbProduct.SelectedItem).Amount);
        }

        private void ClearPControls()
        {
            tbPrName.Text = "";
            tbPrPrice.Text = "";
            tbAmount.Text = "";
            lbProduct.SelectedItem = null;
        }

        private void lLClearControls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearPControls();
        }

        private void tbPrPrice_TextChanged(object sender, EventArgs e)
        {
            CheckValidateInput(tbPrPrice);
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            CheckValidateInput(tbAmount);
        }

        private void CheckValidateInput(TextBox tb)
        {
            string pattern = @"^\d*,?\d*$";
            Match mc = Regex.Match(tb.Text, pattern);
            bool isdontwantsym = mc.Success;
            if (!isdontwantsym)
            {
                MessageBox.Show("Введіть числове значення! (Ціле число або натуральне через кому)");
                tb.Text = "";
            }
        }
    }
}