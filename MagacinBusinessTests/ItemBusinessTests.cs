using MagacinBusiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace MagacinBusinessTests
{
    [TestClass]
    public class ItemBusinessTests
    {
        private Mock<IItemRepository> mockItemRepository = new Mock<IItemRepository>();
        private Item item = new Item
        {
            Name = "Heineken 0.5L limenka",
            Price = 99.99m,
            Discount = 0
        };

        private List<Item> listOfItems = new List<Item>();
        private ItemBusiness itemBusiness;

        public ItemBusinessTests()
        {
            listOfItems.Add(item);
            listOfItems.Add(new Item
            {
                Name = "Vino Pro Corde 0.7L",
                Price = 899m,
                Discount = 10
            });
            listOfItems.Add(new Item
            {
                Name = "Hleb bugget 400g",
                Price = 89.90m,
                Discount = 0
            });
        }



        [TestMethod]
        public void IsItemInserted()
        {
            // Arrange
            mockItemRepository.Setup(x => x.InsertItem(item)).Returns(1);
            this.itemBusiness = new ItemBusiness(mockItemRepository.Object);

            // Act

            var result = itemBusiness.InsertItem(item);

            // Assert

            Assert.AreEqual(result, "Uspešan unos u bazu podataka!");
        }

        [TestMethod]
        public void AreReturnedItemsWithPriceLessThan()
        {
            // Arrange

            mockItemRepository.Setup(x => x.GetAllItems()).Returns(listOfItems);
            this.itemBusiness = new ItemBusiness(mockItemRepository.Object);

            // Act

            var result = itemBusiness.GetItemsWithPriceLessThan(300);

            // Assert

            Assert.AreEqual(2,result.Count);
        }
    }
}
