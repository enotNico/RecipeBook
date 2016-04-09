using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading;

namespace Recipe_Book
{
    [Serializable]
    [DataContract]
    public class Product : Base<Product>
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public double Amount { get; set; }

        public List<Recipe> Recipes 
        {
            get
            {
                List<Recipe> rs = new List<Recipe>();
                foreach (var elem in ProductRecipe.Items.Values)
                    if (elem.Product == this)
                        rs.Add(elem.Recipe);
                return rs;
            }  
        }
        public List<ProductRecipe> RecipeProducts
        {
            get
            {
                List<ProductRecipe> rs = new List<ProductRecipe>();
                foreach (var elem in ProductRecipe.Items.Values)
                    if (elem.Product == this)
                        rs.Add(elem);
                return rs;
            }
        }

        public Product(string PName, double PPrice, double PAmount)
        {
            Name = PName;
            Price = PPrice;
            Amount = PAmount;
        }

        public override string ToString()
        {
            return Name + " [" + Price + "грн." + " | " + Amount + "]";
        }
    }
}
