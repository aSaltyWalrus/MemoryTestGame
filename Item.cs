using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Test_Game
{
    public class Item
    {
        String name, category, path, displayName;
        public Item(String nameIn, String categoryIn)
        {
            if (nameIn.Contains("-")) { name = nameIn.Replace("-", " ").ToLower(); }
            else { name = nameIn.ToLower(); }
            if (categoryIn.Contains("-")) { category = categoryIn.Replace("-", " "); }
            else { category = categoryIn; }
            path = categoryIn + "/" + nameIn;
            if (nameIn.Contains("-")) { displayName = nameIn.Replace("-", "\n"); }
            else { displayName = nameIn; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
    }
}
