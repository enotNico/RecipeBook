using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Book
{
    public partial class FormRecipeViewer : Form
    {
        public FormRecipeViewer(string name, string description, Author rauthor, List<Product> products)
        {
            InitializeComponent();
            this.RName = name;
            this.RDescriptions = description;
            this.RAuthor = rauthor;
            this.Products = products;
        }

        private string RName;
        private string RDescriptions;
        private Author RAuthor;
        private List<Product> Products;

        private void FormRecipeViewer_Load(object sender, EventArgs e)
        {
            labelName.Text = RName;
            this.Name = "Перегляд рецепту: " + RName;
            labelAutLName.Text = RAuthor.LName;
            labelAName.Text = RAuthor.Name;
            labelPNam.Text = RAuthor.PName;
            labelBornDate.Text = RAuthor.Birth.Day + "." + RAuthor.Birth.Month + "." + RAuthor.Birth.Year + ".р";
            labelOblast.Text = RAuthor.Oblast + "ка";
            labelRayon.Text = RAuthor.NPunct;
            tbDescription.Text = RDescriptions;
            pbPhoto.Image = Image.FromFile(RAuthor.AImage);
            labelSumCina.Text = SummPrice() + "грн.";

            foreach (var products in Products)
            {
                lbProducts.Items.Add(products);
            }
        }
        private double SummPrice()
        {
            double summprice = 0;
            foreach (var price in Products)
            {
                summprice += price.Price;
            }
            return summprice;
        }
    }
}