using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LogList : Form
    {
        public LogList()
        {
            InitializeComponent();
        }

        private void LogList_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                string sql = "SELECT * FROM logs WHERE log_type = 0";
                MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int count = 0;
                while (rdr.Read())
                {
                    count++;
                    listBox1.Items.Add("Araç Plakası: " + rdr[3] + " | İşlemi Yapan Kullanıcı: " + rdr[2] + " | Tarih: " + rdr[4] + "");
                }
                if (count == 0)
                {
                    MessageBox.Show("Seçtiğiniz türde kayıt bulunamadı.", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    listBox1.Visible = false;
                    label2.Visible = false;
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = "Garaja Giriş Kayıtları;";
                    listBox1.Visible = true;
                }
                rdr.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                string sql = "SELECT * FROM logs WHERE log_type = 1";
                MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int count = 0;
                while (rdr.Read())
                {
                    count++;
                    listBox1.Items.Add("Araç Plakası: " + rdr[3] + " | İşlemi Yapan Kullanıcı: " + rdr[2] + " | Tarih: " + rdr[4] + "");
                }
                if (count == 0)
                {
                    MessageBox.Show("Seçtiğiniz türde kayıt bulunamadı.", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    listBox1.Visible = false;
                    label2.Visible = false;
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = "Garajdan Çıkış Kayıtları;";
                    listBox1.Visible = true;
                }
                rdr.Close();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu. (L-1)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
