using MagacinData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Models;
using System;
using System.Linq;

namespace MagacinDataTests
{
    [TestClass]
    public class ItemRepositoryTest
    {
        public Item item;
        public ItemRepository itemRepository;

        [TestInitialize]
        public void init()
        {
            item = new Item
            {
                Name = "Heineken 0.5L limenka",
                Price = 99.99m,
                Discount = 0
            };

            itemRepository = new ItemRepository();
        }

        [TestMethod]
        public void GetMagacinItemsTest()
        {
            itemRepository.InsertItem(item);
            Assert.IsNotNull(itemRepository.GetAllItems());
        }

        [TestMethod]
        public void UpdateItemTest()
        {
            // Pošto je pri realnom testiranju baza prazna, prvo dodamo artikal
            itemRepository.InsertItem(item);
            Item newItem = itemRepository.GetAllItems().Where(x => x.Name == item.Name).ToList()[0];
            int result = itemRepository.UpdateItem(newItem);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DeleteItemTest()
        {
            itemRepository.InsertItem(item);
            Item newItem = itemRepository.GetAllItems().Where(x => x.Name == item.Name).ToList()[0];
            Assert.IsTrue(itemRepository.DeleteItem(newItem.Id) > 0);
            // pošto ovde testiramo brisanje, a TestCleanup takođe briše dodati artikal iz baze, moramo ga ponovo dodati,
            // u suprotnom test metoda ne prolazi zbog toga što TestCleanup vraća grešku
            itemRepository.InsertItem(item);
        }

        [TestCleanup]
        public void Clean()
        {
            Item newItem = itemRepository.GetAllItems().Where(x => x.Name == item.Name).ToList()[0];
            itemRepository.DeleteItem(newItem.Id);
        }
        
        // NAPOMENA: ovde smo brisali prvi artikal iz baze koji ima isti Name atribut kao artikal,
        // koji smo dodali na početku u okviru TestInitialize.
        // Kako može postojati više artikala sa istim nazivom, bilo bi preciznije da se koristi Id,
        // međutim pri dodavanju artikla u bazu ne možemo znati koja vrednost je dodeljena za Id atribut.
        // Zato se koristi neka jedinstvena vrednost za taj podatak, u slučaju artikla to može biti bar-kod (numerički ekvivalent),
        // kod studenata je to broj indeksa, kod zaposlenih JMBG, itd.
    }
}
