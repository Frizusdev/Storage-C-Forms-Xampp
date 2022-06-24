using MySql.Data.MySqlClient;
namespace Magazyn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=pracownicy");

        private void Form1_Load(object sender, EventArgs e)
        {
            login.Text = "admin";
            haslo.Text = "admin1";
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