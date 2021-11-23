using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegExAppExample
{
    public partial class Form_RegExApp : Form
    {
        public Form_RegExApp()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            // provera da li su polja popunjena, odnosno da li je neko od polja prazno
            if (textBox_Name.Text == "" ||
                textBox_Surname.Text == "" ||
                textBox_Address.Text == "" ||
                textBox_City.Text == "" ||
                textBox_ZIP.Text == "" ||
                textBox_Country.Text == "" ||
                textBox_Phone.Text == "")
            {
                // prikaži poruku da sva polja moraju biti popunjena
                MessageBox.Show("Morate popuniti sva polja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Name.Focus();
                return;
            }

            // Proveriti da li je ime pravilno uneto (prvo slovo veliko, ostala slova mala)
            if (!Regex.Match(textBox_Name.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("Ime nije pravilno uneto!","Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Name.Focus();
                return;
            }

            // Proveriti da li je prezime pravilno uneto (prvo slovo veliko, ostala slova mala)
            if (!Regex.Match(textBox_Surname.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("Prezime nije pravilno uneseno!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Surname.Focus();
                return;
            }

            // Proveriti da li je adresa pravilno uneta (bar jedna cifra 0-9 + bar jedan razmak + bar jedna ILI dve reči)
            if (!Regex.Match(textBox_Address.Text, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Adresa nije pravilno unesena!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Address.Focus();
                return;
            }

            // Proveriti da li je naziv grada pravilno unet (tačno jedna ILI dve reči)
            if (!Regex.Match(textBox_City.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Naziv grada nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_City.Focus();
                return;
            }

            // Proveriti da li je poštanski broj pravilno unet (tačno 5 cifara)
            if (!Regex.Match(textBox_ZIP.Text, @"^\d{5}$").Success)
            {
                MessageBox.Show("Poštanski broj nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_ZIP.Focus();
                return;
            }

            // Proveriti da li je broj telefona pravilno unet (npr. ndd-ndd-dddd, gde je n iz [1-9], d iz [0,9])
            if (!Regex.Match(textBox_Phone.Text, @"^[0][6]\d{1}/[1-9]\d{2,3}-\d{3,4}$").Success)
            {
                MessageBox.Show("Broj telefona nije pravilno unet!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Phone.Focus();
                return;
            }

            // ako su svi podaci uneti pravilno
            MessageBox.Show("Hvala što ste se prijavili!","Information Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
