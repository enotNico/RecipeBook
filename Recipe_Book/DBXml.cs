using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Serialization;

namespace Recipe_Book
{
    [Serializable]
    [DataContract]
    public class DBXml
    {
        [DataMember]
        public List<Author> Authors
        {
            get { return Author.Authors; }
            set { Author.Authors = value; }
        } 

        [DataMember]
        public Dictionary<Guid, Product> Products 
        {
            get { return Product.Items; }
            set { Product.Items = value; }
        }
        [DataMember]
        public Dictionary<Guid, Recipe> Recipes
        {
            get { return Recipe.Items; }
            set { Recipe.Items = value; }
        }

        [DataMember]
        public Dictionary<Guid, ProductRecipe> ProductRecipes
        {
            get { return ProductRecipe.Items; }
            set { ProductRecipe.Items = value; }
        }

        public static void SerealizeAction()
        {
            XmlWriter xmlWriter = XmlWriter.Create("RecipeBookData.xml");
            DataContractSerializer dcs = new DataContractSerializer(typeof(DBXml));
            dcs.WriteObject(xmlWriter, new DBXml());
            xmlWriter.Close();
        }
    }
}
