using MySql.Data.MySqlClient;
namespace Magazyn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;");
        private void Form1_Load(object sender, EventArgs e)
        {
            login.Text = "admin";
            haslo.Text = "admin1";

            //pracownicy
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "CREATE DATABASE IF NOT EXISTS `pracownicy`";
            int resultp = command.ExecuteNonQuery();
            if (resultp > 0)
            {
                con.ChangeDatabase("pracownicy");
                command.CommandText = "CREATE TABLE `haselka` (`Login` TEXT NOT NULL , `Has³o` TEXT NOT NULL ) ENGINE = InnoDB; INSERT INTO `haselka`(`Login`, `Has³o`) VALUES ('admin','admin1')";
                command.ExecuteNonQuery();
            }
            con.Close();
            //magazyn
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `magazyn`";
            int resultm = cmd.ExecuteNonQuery();
            if (resultm > 0)
            {
                con.ChangeDatabase("magazyn");
                cmd.CommandText = "CREATE TABLE `przedmioty` (`item_ID` int(11) NOT NULL,`nazwa` text NOT NULL,`iloœæ` int(11) NOT NULL,`producent` text NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4; ";
                cmd.ExecuteNonQuery();
            }
            con.Close();
            //zamowienia
            con.Open();
            MySqlCommand cmdzam = con.CreateCommand();
            cmdzam.CommandText = "CREATE DATABASE IF NOT EXISTS `zamowienia`";
            cmdzam.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (login.Text != "" && haslo.Text != "")
                {
                    con.Open();
                    MySqlDataReader row;
                    MySqlCommand command = con.CreateCommand();
                    con.ChangeDatabase("pracownicy");
                    command.CommandText = "select login,has³o from haselka WHERE Login ='" + login.Text + "' AND Has³o ='" + haslo.Text + "'";
                    row = command.ExecuteReader(); ;
                    if (row.HasRows)
                    {
                        Form2 f = new Form2();
                        f.Show();
                        con.Close();
                        //f.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }
    }
}