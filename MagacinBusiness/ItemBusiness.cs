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
    }
}
