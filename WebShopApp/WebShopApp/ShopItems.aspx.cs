using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopApp.Models;

namespace WebShopApp
{
    public partial class ShopItems : System.Web.UI.Page
    {

        private string connString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=ShopItemsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshShopItemsList();
        }

        public void RefreshShopItemsList()
        {
            List<ShopItem> listOfShopItems = GetAllShopItems();
            ListBox_ShopItems.Items.Clear();
            foreach (ShopItem shopItem in listOfShopItems)
            {
                ListBox_ShopItems.Items.Add(String.Format("{0}. {1} – {2} – {3} – {4}: {5}",
                    shopItem.Id, shopItem.ShopItemName, shopItem.ShopitemDescription,
                    shopItem.ShopItemCathegory, shopItem.ShopItemPrice, shopItem.ShopItemDiscount));
            }
        }


        public List<ShopItem> GetAllShopItems()
        {
            using (SqlConnection sqlConnetion = new SqlConnection(this.connString))
            {
                sqlConnetion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnetion;
                sqlCommand.CommandText = "SELECT * FROM ShopItems";

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                List<ShopItem> listOfShopItems = new List<ShopItem>();

                while (dataReader.Read())
                {
                    ShopItem shopItem = new ShopItem();
                    shopItem.Id = dataReader.GetInt32(0);
                    shopItem.ShopItemName = dataReader.GetString(1);
                    shopItem.ShopitemDescription = dataReader.GetString(2);
                    shopItem.ShopItemCathegory = dataReader.GetString(3);
                    shopItem.ShopItemPrice = dataReader.GetDecimal(4);
                    shopItem.ShopItemDiscount = dataReader.GetBoolean(5);

                    listOfShopItems.Add(shopItem);
                }
                return listOfShopItems;
            }
        }

    }
}