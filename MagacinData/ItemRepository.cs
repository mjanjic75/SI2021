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
                item.Id = dataReader.GetInt32(0);
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

        public int UpdateItem(Item item)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                // Može SQL upit da se doda i preko parametara, ali za veći broj polja/atributa je...

                string sqlCommand = "UPDATE Items SET Name = @Name, Price = @Price, Discount = @Discount WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sqlCommand,sqlConnection);
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Price", item.Price);
                command.Parameters.AddWithValue("@Discount", item.Discount);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteItem(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Items WHERE Id = " + id;

                return command.ExecuteNonQuery();
            }
        }
    }
}
