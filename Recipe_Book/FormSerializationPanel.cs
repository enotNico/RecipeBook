using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Recipe_Book
{
    public partial class FormSerializationPanel : Form

    {
        public FormSerializationPanel()
        {
            InitializeComponent();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            DBXml.SerealizeAction();
            MessageBox.Show("Дані збережені в файл RecipeBookData.xml");
        }

        private void btDeserialization_Click(object sender, EventArgs e)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string importFile = currentDir + "\\RecipeBookData.xml";
            if (!File.Exists(importFile))
            {
                MessageBox.Show("Не знайдено файл RecipeBookData.xml. Якщо він у вас наявний, вставте його в одну директорію з застосуванням!","Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            XmlReader xmlReader = XmlReader.Create("RecipeBookData.xml");
            DataContractSerializer dcSerializer = new DataContractSerializer(typeof(DBXml));
            try
            {
                DBXml db = (DBXml) dcSerializer.ReadObject(xmlReader);
            }
            catch {
                return;
            }
            finally
            {
                xmlReader.Close();
            }
        }
    }
}
