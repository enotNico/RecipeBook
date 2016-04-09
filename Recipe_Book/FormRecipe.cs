using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recipe_Book
{
    public partial class FormRecipe : Form
    {
        public FormRecipe()
        {
            InitializeComponent();
        }

        private void FormRecipe_Load(object sender, EventArgs e)
        {
            cbRecAuthor.DataSource = Author.Authors;
            lbSelectProd.DataSource = Product.Items.Values.ToList();
            if (cbRecAuthor.SelectedItem == null && lbSelectProd.Items.Count == 0)
            {
                MessageBox.Show("Не додано жодного автора та жодного продукта! Внесіть будь-ласка ці дані для додавання своїх рецептів",
                    "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbRecAuthor.SelectedItem == null)
                MessageBox.Show("Жодного автора не додано. Внесіть будь-ласка свої дані як автора для додавання свої рецептів!",
                    "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (lbSelectProd.Items.Count == 0)
            {
                MessageBox.Show("Додайте будь-ласка продукти для додавання свої рецептів!", "Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            RefreshLbRezept();
            ClearRControls();
        }

        private void RefreshLbRezept()
        {
            lbRezept.DataSource = null;
            lbRezept.DataSource = Recipe.Items.Values.ToList();
        }

        private void btReAdd_Click(object sender, EventArgs e)
        {
            if (tbRecName.Text == "" || tbRecipe.Text == "" || cbRecAuthor.SelectedItem == null ||
                lbSelectProd.SelectedItems == null){
                    MessageBox.Show("Заповніть всі поля!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Recipe rec = new Recipe();
            rec.Name = tbRecName.Text;
            rec.RAuthor = (Author)cbRecAuthor.SelectedItem;
            rec.Description = tbRecipe.Text;

            foreach (var products in lbSelectProd.SelectedItems)
                new ProductRecipe(rec, (Product) products);

            RefreshLbRezept();
            ClearRControls();
        }

        private void btReDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Recipe.Items.Remove(((Recipe) lbRezept.SelectedItem).Id);
            }
            catch
            {
                MessageBox.Show("Виділіть у списку рецепт, який бажаєте видалити!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            RefreshLbRezept();
            ClearRControls();
        }

        private void btReEdit_Click(object sender, EventArgs e)
        {
            if (tbRecName.Text == "" || tbRecipe.Text == "" || cbRecAuthor.SelectedItem == null ||
                lbSelectProd.SelectedItems == null)
            {
                MessageBox.Show("Заповніть всі поля!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Recipe forEditRecipe = (Recipe) lbRezept.SelectedItem;

                forEditRecipe.Name = tbRecName.Text;
                forEditRecipe.Description = tbRecipe.Text;
                forEditRecipe.RAuthor = (Author) cbRecAuthor.SelectedItem;

                foreach (var pr in forEditRecipe.RecipeProducts)
                    ProductRecipe.Items.Remove(pr.Id);

                foreach (var productItem in lbSelectProd.SelectedItems)
                    new ProductRecipe(forEditRecipe, (Product) productItem);
            }
            catch
            {
                MessageBox.Show("Виберіть рецепт, який бажаєте редагувати!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RefreshLbRezept();
            ClearRControls();
        }

        private void lbRezept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRezept.SelectedItem == null)
                return;
            Recipe selectedRecipe = (Recipe) lbRezept.SelectedItem;
            tbRecName.Text = selectedRecipe.Name;
            tbRecipe.Text = selectedRecipe.Description;
            cbRecAuthor.SelectedItem = selectedRecipe.RAuthor;
            lbSelectProd.SelectedItems.Clear();
            foreach (var sproducts in selectedRecipe.Products)
                lbSelectProd.SelectedItems.Add(sproducts);
        }

        private void ClearRControls()
        {
            tbRecName.Text = "";
            tbRecipe.Text = "";
            cbRecAuthor.SelectedIndex = -1;
            lbSelectProd.SelectedItems.Clear();
            lbRezept.SelectedItem = null;
        }

        private void lLClearControls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearRControls();
        }

        private void btShowDetailRecipe_Click(object sender, EventArgs e)
        {
            if (lbRezept.SelectedItem == null)
            {
                MessageBox.Show("Виберіть рецепт, який бажаєте переглянути!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Recipe selectedRecipe = (Recipe)lbRezept.SelectedItem;
            FormRecipeViewer formRecipeViewer = new FormRecipeViewer(selectedRecipe.Name, selectedRecipe.Description, selectedRecipe.RAuthor, selectedRecipe.Products);
            formRecipeViewer.ShowDialog();
        }
    }
}
