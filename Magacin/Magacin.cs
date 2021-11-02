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
                listBoxItems.Items.Add(item.Name + ":\t" + item.Price + "\t-\t" + item.Discount);
            }
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_itemInsert_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            item.Name = textBox_itemName.Text;
            item.Price = Convert.ToDecimal(textBox_itemPrice.Text);
            item.Discount = Convert.ToInt32(textBox_itemDiscount.Text);

            label_insertConfirm.Text = this.itemBusiness.InsertItem(item);

            // textBox_itemName.Text = "";
            textBox_itemPrice.Text = "";
            textBox_itemDiscount.Text = "";

            // Može da se koristi i Clear() metoda:
            textBox_itemName.Clear();

            GetAllItems();
        }
    }
}
