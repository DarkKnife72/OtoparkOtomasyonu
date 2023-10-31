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

namespace Project
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
            }
            catch
            {
                MessageBox.Show("Veritabanı bağlantısı sağlanamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            if (adminUsername.Text.Length < 1 || adminPassword.Text.Length < 1)
            {
                MessageBox.Show("Kullanıcı adı ve şifre kısmı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string sql = "SELECT * FROM admin_accounts WHERE username = '" + adminUsername.Text + "' AND password = '" + adminPassword.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Functions.AdminLogin = true;
                    Functions.AdminUsername = adminUsername.Text;
                    Functions.AdminLevel = (int)rdr[3];                    
                    rdr.Close();
                    this.Visible = false;
                    Form main_form = new Main();
                    main_form.Show();
                    Functions.UpdateAdminLogin();
                    // admin giriş kapanmıyor bakılacak                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rdr.Close();
                }                
            }
            catch
            {
                MessageBox.Show("Veritabanı hatası oluştu. (ADM-1) ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
