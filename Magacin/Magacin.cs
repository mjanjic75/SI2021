using MagacinBusiness;
using MagacinData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magacin
{
    public partial class Magacin : Form
    {
        private ItemBusiness itemBusiness = new ItemBusiness();

        public Magacin()
        {
            InitializeComponent();
        }

        private void Magacin_Load(object sender, EventArgs e)
        {
            GetAllItems();
        }

        private void GetAllItems()
        {
            listBoxItems.Items.Clear();

            List<Item> listOfItems = this.itemBusiness.GetAllItems();

            foreach (Item item in listOfItems)
            {
                listBoxItems.Items.Add(item.Name + ": " + item.Price + " – " + item.Discount);
            }
        }
    }
}
