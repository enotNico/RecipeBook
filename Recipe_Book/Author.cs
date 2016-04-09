using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Recipe_Book
{
    [Serializable]
    [DataContract]
    public class Author
    {
        public static List<Author> Authors = new List<Author>();

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LName { get; set; }
        [DataMember]
        public string PName { get; set; }
        [DataMember]
        public string Oblast { get; set; }
        [DataMember]
        public string NPunct { get; set; }
        [DataMember]
        public DateTime Birth { get; set; }
        [DataMember]
        public string AImage { get; set; }
        
        public Author() { }

        public Author(string name, string lname, string pname, string oblast, string npunct, DateTime birth, string image)
        {
            Name = name;
            LName = lname;
            PName = pname;
            Oblast = oblast;
            NPunct = npunct;
            Birth = birth;
            AImage = image;

            Authors.Add(this);
        }

        ~Author()
        {
            try
            {
                foreach (string path in DeleteFilesList)
                {
                    File.Delete(path);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Не можу видалити файли зображень, оскільки вони використовуються іншими процесами!",
                    "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                return;
            }

            catch
            {
                MessageBox.Show("Сталася помилка під час видалення файлів!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public override string ToString()
        {
            return LName + " " + Name + " " + PName;
        }

        private static string CreatingImageName()
        {
            Guid fileName;
            fileName = Guid.NewGuid();
            return fileName.ToString() + ".jpg";
        }

        public static string CopyImageFile(string path)
        {
            string CurrentDir = Directory.GetCurrentDirectory();
            string mcd = CurrentDir + "\\images";
            if (!Directory.Exists(mcd))
            {
                try
                {
                    Directory.CreateDirectory(mcd);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Немає дозволу для створення папки в якій будуть знаходтися зображення!", "Помилка!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            string nfile = Path.GetFileName(path);
            string toCopy = Path.Combine(mcd, CreatingImageName());
            try {
            File.Copy(path, toCopy);
                } catch {
                    MessageBox.Show("Сталася помилка під час копіювання файлів зображень!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            return toCopy;
        }

        private static List<string> DeleteFilesList = new List<string>();
        public static void AddToDeleteFile(string st)
        {
            DeleteFilesList.Add(st);
        }
    }
}