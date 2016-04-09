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
    public class Recipe : Base<Recipe>
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        public Author RAuthor { get; set; }

        public List<Product> Products
        {
            get
            {
                List<Product> rs = new List<Product>();
                foreach(var elem in ProductRecipe.Items.Values)
                    if (elem.Recipe == this)
                        rs.Add(elem.Product);
                return rs;
            }
        }
        public List<ProductRecipe> RecipeProducts
        {
            get
            {
                List<ProductRecipe> rs = new List<ProductRecipe>();
                foreach (var elem in ProductRecipe.Items.Values)
                    if (elem.Recipe == this)
                        rs.Add(elem);
                return rs;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
