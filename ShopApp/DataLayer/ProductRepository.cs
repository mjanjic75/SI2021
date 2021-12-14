using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductRepository
    {
        private string connString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=ShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Product> GetAllProducts()
        {
            List<Product> productList = new List<Product>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Products";
                               

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Product product = new Product();
                    product.Id = dataReader.GetInt32(0);
                    product.Name = dataReader.GetString(1);
                    product.Description = dataReader.GetString(2);
                    product.ExpiryDate = dataReader.GetDateTime(3);

                    productList.Add(product);
                }
            }

            return productList;
        }

        public int InsertProduct(Product product)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Products VALUES('{0}','{1}','{2}')",
                    product.Name, product.Description, product.ExpiryDate);

                return command.ExecuteNonQuery();
            }
        }
    }
}
