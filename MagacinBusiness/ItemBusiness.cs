using MagacinData;
using MagacinData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinBusiness
{
    public class ItemBusiness
    {
        ItemRepository itemRepository = new ItemRepository();

        public List<Item> GetAllItems()
        {
            return this.itemRepository.GetAllItems();
        }

        public string InsertItem(Item item)
        {
            int rowsAffected = this.itemRepository.InsertItem(item);

            if (rowsAffected > 0)
            {
                return "Uspešan unos u bazu podataka!";
            }
            else
            {
                return "Neuspešan unos, došlo je do greške!";
            }
        }
    }
}
