using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Functions.AdminLogin)
            {
                Form admin_login = new AdminLogin();
                admin_login.Show();
                Functions.AdminLoginType = 1;
            }
            else
            {
                Form vehicle_save = new VehicleSave();
                vehicle_save.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!Functions.AdminLogin)
            {
                Form admin_login = new AdminLogin();
                admin_login.Show();
                Functions.AdminLoginType = 2;
            }
            else
            {
                Form garage = new Garage();
                garage.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void TotalCars()
        {
            string sql = "SELECT id FROM vehicles";
            MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int count = 0;
            while (rdr.Read())
            {
                count++;
            }
            mainLabelTotalCars.Text = count.ToString();
            rdr.Close();
        }

        public void TotalStaff()
        {
            string sql = "SELECT id FROM admin_accounts";
            MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int count = 0;
            while (rdr.Read())
            {
                count++;
            }
            mainLabelTotalStaff.Text = count.ToString();
            rdr.Close();
        }

        public void TotalPark()
        {
            string sql = "SELECT vehicle FROM garage WHERE vehicle = -1";
            MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int count = 0;
            while (rdr.Read())
            {
                count++;
            }
            mainLabelTotalPark.Text = count.ToString();
            rdr.Close();
        }

        public void TotalCash()
        {
            string sql = "SELECT cash FROM management";
            MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                mainLabelTotalCash.Text = rdr[0].ToString() + " TL";
                rdr.Close();
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                TotalCars();
                TotalStaff();
                TotalPark();
                TotalCash();                                
            }
            catch
            {
                MessageBox.Show("Veritabaný baðlantýsý saðlanamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form user_add = new UserAdd();
            user_add.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form logs = new LogList();
            logs.Show();
        }
    }
}