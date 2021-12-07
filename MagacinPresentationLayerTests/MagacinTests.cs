using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;

namespace MagacinPresentationLayerTests
{
    [TestClass]
    public class MagacinTests
    {
        [TestMethod]
        public void IsDataRefreshed()
        {
            // Arrange

            List<Item> listOfItems = new List<Item>();
            listOfItems.Add(new Item
            {
                Name = "Red Bull 0.5L",
                Price = 159.90m,
                Discount = 5
            });
            listOfItems.Add(new Item
            {
                Name = "Žele kocka 200g",
                Price = 129.90m,
                Discount = 0
            });
            listOfItems.Add(new Item
            {
                Name = "Štark bananica",
                Price = 14.90m,
                Discount = 0
            });

            var mockItemBusiness = new Mock<IItemBusiness>();
            mockItemBusiness.Setup(s => s.GetAllItems()).Returns(listOfItems);

            var magacinForm = new Magacin.Magacin(mockItemBusiness.Object);
            // ako namespace i klasa imaju isti naziv, onda mora ovako kao u kodu iznad


            // Act

            PrivateObject obj = new PrivateObject(magacinForm);
            obj.Invoke("GetAllItems");

            ListBox listBoxItems = (ListBox)obj.GetFieldOrProperty("listBoxItems");

            // Assert

            Assert.AreEqual(3, listBoxItems.Items.Count);
        }
    }
}
