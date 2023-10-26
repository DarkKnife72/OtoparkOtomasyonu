using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void useraddButton_Click(object sender, EventArgs e)
        {
            if (userAddLevel.TextLength < 1 || useraddUsername.TextLength < 1)
            {
                MessageBox.Show("Kayıt bilgileri doldurulmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userAddLevel.Text != "1" && userAddLevel.Text != "2")
                {
                    MessageBox.Show("Yönetici seviyesi 1 ile 2 arasında olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string password = Functions.RandomPassword();
                        string sql = "INSERT INTO admin_accounts (username, password, level) VALUES ('" + useraddUsername.Text + "','" + password + "', '" + userAddLevel.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Hesap başarıyla eklendi. Şifre: " + password + "", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Veritabanı hatası oluştu (UA-1).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            if (Functions.AdminLevel != 2)
            {
                MessageBox.Show("Bu sayfayı görüntülemek için lütfen yönetici ile görüşünüz.", "Yetersiz Yetki", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
