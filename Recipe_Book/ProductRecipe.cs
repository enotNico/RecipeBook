using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Runtime.Serialization;
using System.Threading;

namespace Recipe_Book
{
    [Serializable]
    [DataContract]
    public class ProductRecipe : Base<ProductRecipe>
    {
        [DataMember(Name = "RecipeID")]
        private Guid _recipeId;

        public Recipe Recipe 
        {
            get { return Recipe.Items[_recipeId]; }
            set { _recipeId = value.Id; }
        }

        [DataMember(Name = "ProductID")]
        private Guid _productId;

        public Product Product
        {
            get { return Product.Items[_productId]; }
            set { _productId = value.Id; }
        } 
    
        public ProductRecipe(Recipe rezm, Product prod)
        {
            Recipe = rezm;
            Product = prod;
        }
    }
}
