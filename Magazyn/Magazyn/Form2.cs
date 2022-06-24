using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Magazyn
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=magazyn");
        MySqlConnection conzam = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=zamowienia");

        void pobierzdaneprzedmiotow()
        {
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM przedmioty ";
            try
            {
                con.Open();
                command.ExecuteNonQuery();
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void pobierzdanezamowienia()
        {
            MySqlCommand command = conzam.CreateCommand();
            command.CommandText = $"SELECT * FROM {tablename.Text} ";
            try
            {
                conzam.Open();
                command.ExecuteNonQuery();
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conzam.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conzam.Close();
            }
        }

        void dodajprzedmiot()
        {
            if (name.Text != "" && quantity.Text != "" && producent.Text != "")
            {
                MySqlCommand command = con.CreateCommand();
                command.CommandText = $"INSERT INTO `przedmioty`(`nazwa`, `ilość`, `producent`) VALUES('{name.Text}', '{quantity.Text}', '{producent.Text}')";

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void usunprzedmiot()
        {
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "DELETE FROM `przedmioty` WHERE item_ID = " + id.Text + "";

            try
            {
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void edytujprzedmiot()
        {
            MySqlCommand command = con.CreateCommand();
            command.CommandText = $"UPDATE `przedmioty` SET `nazwa`='{name.Text}',`ilość`='{quantity.Text}',`producent`='{producent.Text}' WHERE item_ID = '{id.Text}'";

            try
            {
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void dodajzamowienie()
        {
            if (tablename.Text != "" && checkBox1.Checked)
            {
                MySqlCommand command = conzam.CreateCommand();
                command.CommandText = $"CREATE TABLE `{tablename.Text}` (`nr` INT NOT NULL AUTO_INCREMENT , `nazwa_przedmiotu` TEXT NOT NULL , `ilość` DOUBLE NOT NULL , PRIMARY KEY (`nr`)) ENGINE = InnoDB; ";
                try
                {
                    conzam.Open();
                    command.ExecuteNonQuery();
                    conzam.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conzam.Close();
                }
            }
        }

        void dodajpozycje()
        {
            if (name.Text != "" && quantity.Text != "")
            {
                MySqlCommand command = conzam.CreateCommand();
                command.CommandText = $"INSERT INTO `{tablename.Text}`( `nazwa_przedmiotu`, `ilość`) VALUES ('{name.Text}','{quantity.Text}')";
                try
                {
                    conzam.Open();
                    command.ExecuteNonQuery();
                    conzam.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conzam.Close();
                }
            }
        }

        void listazamowien()
        {
                MySqlCommand command = conzam.CreateCommand();
                command.CommandText = $"SHOW TABLES FROM zamowienia;";
                try
                {
                conzam.Open();
                command.ExecuteNonQuery();
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conzam.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conzam.Close();
            }
        }

        void usunzamowienie()
        {
            MySqlCommand command = conzam.CreateCommand();
            command.CommandText = $"DROP TABLE {tablename.Text}";
            try
            {
                conzam.Open();
                command.ExecuteNonQuery();
                conzam.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conzam.Close();
            }
        }
        void usunpozycje()
        {
            MySqlCommand command = conzam.CreateCommand();
            command.CommandText = $"DELETE FROM `{tablename.Text}` WHERE nr = {id.Text}";
            try
            {
                conzam.Open();
                command.ExecuteNonQuery();
                conzam.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conzam.Close();
            }
        }
        void edytujpozycje()
        {
            MySqlCommand command = conzam.CreateCommand();
            command.CommandText = $"UPDATE {tablename.Text} SET `nazwa_przedmiotu`='{name.Text}',`ilość`='{quantity.Text}' WHERE nr ={id.Text}";

            try
            {
                conzam.Open();
                command.ExecuteNonQuery();
                conzam.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conzam.Close();
            }
        }

        void nazwatabeli()
        {
            MySqlCommand command = conzam.CreateCommand();
            command.CommandText = $"RENAME TABLE {tablename.Text} TO {textBox1.Text}";

            try
            {
                conzam.Open();
                command.ExecuteNonQuery();
                conzam.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conzam.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pobierzdaneprzedmiotow();
            label3.Visible = true;
            producent.Visible = true;
            tablename.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
        }
        private void additem_Click(object sender, EventArgs e)
        {
            dodajprzedmiot();
            pobierzdaneprzedmiotow();
        }
        private void addorder_Click(object sender, EventArgs e)
        {
            dodajzamowienie();
            pobierzdanezamowienia();
        }

        private void dedlitem_Click(object sender, EventArgs e)
        {
            usunprzedmiot();
            pobierzdaneprzedmiotow();
        }

        private void addpos_Click(object sender, EventArgs e)
        {
            dodajpozycje();
            pobierzdanezamowienia();
        }

        private void edititem_Click(object sender, EventArgs e)
        {
            edytujprzedmiot();
            pobierzdaneprzedmiotow();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                listazamowien();
                label.Text = "Przedmioty";
                label1.Text = "Nr";
                label3.Visible = false;
                producent.Visible = false;
                tablename.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                pobierzdaneprzedmiotow();
                label.Text = "Zamowienia";
                label1.Text = "ID Przedmiotu";
                label3.Visible = true;
                producent.Visible = true;
                tablename.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void showorder_Click(object sender, EventArgs e)
        {
            pobierzdanezamowienia();
        }

        private void delorder_Click(object sender, EventArgs e)
        {
            usunzamowienie();
            listazamowien();
        }

        private void editorder_Click(object sender, EventArgs e)
        {
            nazwatabeli();
            listazamowien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            { listazamowien(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usunpozycje();
            pobierzdanezamowienia();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edytujpozycje();
            pobierzdanezamowienia();
        }
    }
}
