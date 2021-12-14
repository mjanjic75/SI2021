using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationDesktop
{
    public partial class ShopApp : Form
    {
        readonly ProductBusiness productBusiness = new ProductBusiness();
        public ShopApp()
        {
            InitializeComponent();
        }

        private void ShopApp_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxProducts.Items.Clear();
            foreach (Product product in productBusiness.GetProducts())
            {
                string itemData = string.Format("{0}. {1}", product.Id, product.Name);
                listBoxProducts.Items.Add(itemData);

                // Može jednostavnije:
                // listBoxProducts.Items.Add($"{product.Id}. {product.Name}");
            }
        }

        private void buttonInsertProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
                ExpiryDate = dateTimePickerProduct.Value
            };

            productBusiness.InsertProduct(product);

            RefreshList();

            textBoxName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            dateTimePickerProduct.Value = DateTime.Now;
        }
    }
}
