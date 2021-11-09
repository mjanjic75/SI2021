using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopApp.Models
{
    public class ShopItem
    {
        public int Id { get; set; }
        public string ShopItemName { get; set; }
        public string ShopitemDescription { get; set; }
        public string ShopItemCathegory { get; set; }
        public decimal ShopItemPrice { get; set; }
        public bool ShopItemDiscount { get; set; }
    }
}