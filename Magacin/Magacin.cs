using MagacinBusiness;
using MagacinData;
using Shared.Interfaces;
using Shared.Models;
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
        private readonly IItemBusiness itemBusiness;

        public Magacin(IItemBusiness _itemBusiness)
        {
            itemBusiness = _itemBusiness;
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
                listBoxItems.Items.Add(item.Id + ". " + item.Name + ":\t" + item.Price + "\t-\t" + item.Discount);
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

        private void listBoxItems_MouseDoubleClick(object sender, EventArgs e)
        {
            // Metoda koja dvoklikom miša na podatak u listBox-u odgovarajuće vrednosti artikla unosi u textBox-ove
            // za potrebe ažuriranja/izmene podataka o artiklu ili dodavanja novog artikla (da se ne bi prekucavali podaci koji su isti ili slični
            // Kako je za ažuriranje ili brisanje podatka potreban Id, dodato je zaključano polje u koje se unosi.
            // To polje se može staviti i iza nekog od tastera tako da se ne vidi, ali je tako najjednostavnije proslediti Id vrednost
            // selektovanog artikla u listBox-u metodama za ažuriranje ili brisanje
            if (listBoxItems.SelectedItem != null)
            {
                Item item = new Item();
                string selectedRow = listBoxItems.SelectedItem.ToString();
                // Substring metoda ima 2 varijante, sa jednim ili dva parametra
                // Sa jednim parametrom podrazumeva deo stringa od prvog do zadatog karaktera (ne uključujući taj karakter)
                // Sa dva parametra podrazumeva podstring od karaktera zadatog prvim parametrom, dužine zadate drugim parametrom
                textBox_itemId.Text = selectedRow.Substring(0, selectedRow.IndexOf(". "));
                textBox_itemName.Text = selectedRow.Substring(selectedRow.IndexOf(".") + 2, selectedRow.IndexOf(":\t") - selectedRow.IndexOf(". ") - 2);
                textBox_itemPrice.Text = selectedRow.Substring(selectedRow.IndexOf(":\t")+2, selectedRow.IndexOf("\t-\t") - selectedRow.IndexOf(":\t") - 1);
                textBox_itemDiscount.Text = selectedRow.Substring(selectedRow.IndexOf("\t-\t") + 3);
            }
        }

        private void button_itemUpdate_Click(object sender, EventArgs e)
        {
            // Podatke za ažuriranje artikla pročitamo iz tekstualnih polja
            // Ako je korisnik dvoklikom izabrao neki artikal iz liste, ti podaci će biti u tekstualnim poljima,
            // u suprotnom ta polja se moraju ručno popuniti.
            // Ovde je potrebno dodati validaciju svako polja, tj. da li je popunjeno odgovarajućim podacima
            Item item = new Item();
            string selectedRow = listBoxItems.SelectedItem.ToString();
            item.Id = int.Parse(textBox_itemId.Text);
            item.Name = textBox_itemName.Text;
            item.Price = decimal.Parse(textBox_itemPrice.Text);
            item.Discount = int.Parse(textBox_itemDiscount.Text);

            string result = this.itemBusiness.UpdateItem(item);

            GetAllItems();

            label_insertConfirm.Text = result;
        }

        private void button_itemDelete_Click(object sender, EventArgs e)
        {
            // Takođe, kao kod ažuriranja, pročitamo Id iz tekstualnog polja (ostali podaci nam nisu potrebni),
            // važi isto kao za ažuriranje, potrebno je izvršiti validaciju tekstualnog polja za Id,
            // odnosno taster za brisanje treba da bude otključan samo ako je u tekstualnom polju prisutna celobrojna vrednost.
            int itemId = int.Parse(textBox_itemId.Text);

            string result = this.itemBusiness.DeleteItem(itemId);

            GetAllItems();

            label_insertConfirm.Text = result;
        }
    }
}
