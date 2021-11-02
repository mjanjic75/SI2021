using MagacinData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinData
{
    public class ItemRepository
    {
        public List<Item> GetAllItems()
        {
            List<Item> listOfItems = new List<Item>();

            for (int i = 0; i < 5; i++)
            {
                Item item = new Item();
                item.Name = String.Format("Artikal {0}", i);
                item.Price = 100.00m;
                item.Discount = 0;

                listOfItems.Add(item);
            }

            return listOfItems;
        }
    }
}
