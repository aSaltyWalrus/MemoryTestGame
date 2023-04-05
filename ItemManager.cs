using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Test_Game
{
    public class ItemManager
    {
        Item[] items;
        Random random = new Random();
        public ItemManager(Item[] itemArr)
        {
            items = itemArr;
        }

        public Item[] Items
        {
            get { return items; }
            set { items = value; }
        }

        public Item[] randomizeItems()
        {
            return this.Items.OrderBy(x => random.Next()).ToArray();
        }

        public Item[] orderItems()
        {
            Array.Sort(items, (x, y) => String.Compare(x.Path, y.Path));
            return items;
        }

        public Item[] randomizeItemsInCategory(int categorySize)
        {
            Item[] outputArr = new Item[categorySize*6];
            Item[] randItems = randomizeItems();
            int birdCount = 0, fruitsCount = 0, householdItemCount = 0, landAnimalCount = 0, toolsCount = 0, vehiclesCount = 0;
            foreach (Item item in randItems)
            {

                switch (item.Category)
                {
                    case "bird":
                        if (birdCount < categorySize)
                        {
                            outputArr[birdCount] = item;
                            birdCount++;
                        }
                        break;
                    case "fruit":
                        if (fruitsCount < categorySize)
                        {
                            outputArr[fruitsCount + categorySize] = item;
                            fruitsCount++;
                        }
                        break;
                    case "household item":
                        if (householdItemCount < categorySize)
                        {
                            outputArr[householdItemCount + categorySize*2] = item;
                            householdItemCount++;
                        }
                        break;
                    case "land animal":
                        if (landAnimalCount < categorySize)
                        {
                            outputArr[landAnimalCount + categorySize * 3] = item;
                            landAnimalCount++;
                        }
                        break;
                    case "tool":
                        if (toolsCount < categorySize)
                        {
                            outputArr[toolsCount + categorySize * 4] = item;
                            toolsCount++;
                        }
                        break;
                    case "vehicle":
                        if (vehiclesCount < categorySize)
                        {
                            outputArr[vehiclesCount + categorySize * 5] = item;
                            vehiclesCount++;
                        }
                        break;
                }

            }
            return outputArr;
        }
    }
}
