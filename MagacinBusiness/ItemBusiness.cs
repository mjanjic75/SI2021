using MagacinData;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinBusiness
{
    public class ItemBusiness : IItemBusiness
    {
        private readonly IItemRepository itemRepository;

        public ItemBusiness(IItemRepository _itemRepository)
        {
            itemRepository = _itemRepository;
        }

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

        public List<Item> GetItemsWithPriceLessThan(decimal price)
        {
            return this.itemRepository.GetAllItems().Where(i => i.Price <= price).ToList();
        }

        public string UpdateItem(Item item)
        {
            int rowsAffected = this.itemRepository.UpdateItem(item);

            if (rowsAffected > 0)
            {
                return "Uspešna izmena u bazi podataka!";
            }
            else
            {
                return "Neuspešna izmena, došlo je do greške!";
            }
        }

        public string DeleteItem(int id)
        {
            int rowsAffected = this.itemRepository.DeleteItem(id);

            if (rowsAffected > 0)
            {
                return "Uspešno obrisan podatak iz baze podataka!";
            }
            else
            {
                return "Brisanje nije uspelo, došlo je do greške!";
            }
        }
    }
}
