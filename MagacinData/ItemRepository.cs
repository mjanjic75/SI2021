using MagacinData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinData
{
    public class ItemRepository
    {
        private string connString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=MagacinDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Item> GetAllItems()
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;
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
    }
}
