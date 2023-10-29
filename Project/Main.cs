using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using System.Security.Cryptography;

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

        public void CheckNowVehicle()
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM vehicles", Connection.conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderCell.Value = "Araç NO";
                dataGridView1.Columns[1].HeaderCell.Value = "Araç Markasý";
                dataGridView1.Columns[2].HeaderCell.Value = "Araç Modeli";
                dataGridView1.Columns[3].HeaderCell.Value = "Araç Modeli";
                dataGridView1.Columns[4].HeaderCell.Value = "Araç Sahibi";
            }
            catch
            {
                MessageBox.Show("Veritabaný hatasý oluþtu. (S-1)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CheckNowVehicle();
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