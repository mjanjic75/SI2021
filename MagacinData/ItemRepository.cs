using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinData
{
    public class ItemRepository : IItemRepository
    {
        public List<Item> GetAllItems()
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = Constants.connString;
            sqlConnection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "SELECT * FROM Items";

            SqlDataReader dataReader = command.ExecuteReader();


            List<Item> listOfItems = new List<Item>();

            while (dataReader.Read())
            {
                Item item = new Item();
                item.Name = dataReader.GetString(1);
                item.Price = dataReader.GetDecimal(2);
                item.Discount = dataReader.GetInt32(3);

                listOfItems.Add(item);
            }

            sqlConnection.Close();

            return listOfItems;
        }

        public int InsertItem(Item item)
        {
            // Postoji lakši način za konektovanje na bazu i automatsko zatvaranje konekcije
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Items VALUES('{0}',{1},{2})",
                    item.Name, item.Price, item.Discount);

                return command.ExecuteNonQuery();
            }

        }
    }
}
