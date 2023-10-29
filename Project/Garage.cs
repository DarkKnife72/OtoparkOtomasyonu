using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.Devices;
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
    public partial class Garage : Form
    {
        public Garage()
        {
            InitializeComponent();
        }

        private void Garage_Load(object sender, EventArgs e)
        {            
            /* Sadece butonları oluşturma kısmı internetten yardım alınarak yapıldı. */
            int AddedButton_Height = 0;
            int LeftSpace = 0, TopSpace = 0;            

            string sql = "SELECT * FROM garage";
            MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int[] garage_vehicle = new int[20];
            int count = 0;
            while (rdr.Read())
            {
                garage_vehicle[count] = (int)rdr[1];
                count++;
            }
            rdr.Close();
            for (int i = 0; i <= 19; i++)
            {
                Button btn;
                int vehicle = garage_vehicle[i];
                if (vehicle != -1)
                {
                    string select_sql = "SELECT * FROM vehicles WHERE id = " + vehicle + "";
                    MySqlCommand select_cmd = new MySqlCommand(select_sql, Connection.conn);
                    MySqlDataReader select_rdr = select_cmd.ExecuteReader();
                    if (select_rdr.Read())
                    {                        
                        btn = new Button()
                        {
                            Height = 100,
                            Width = 120,
                            Text = "Dolu Sıra - " + (select_rdr[3]).ToString(),
                            Name = "btn_" + (vehicle).ToString(),
                            BackColor = Color.Red,
                        };
                        select_rdr.Close();
                        int now_i_id = i;
                        btn.Click += (a, b) =>
                        {
                            if (!btn.Text.StartsWith("Boş"))
                            {
                                MessageBox.Show(btn.Text);
                                string vehicle_id = btn.Name.Replace("btn_", "");
                                string delete_sql = "DELETE FROM vehicles WHERE id = " + int.Parse(vehicle_id) + "";                            
                                MySqlCommand delete_cmd = new MySqlCommand(delete_sql, Connection.conn);
                                delete_cmd.ExecuteNonQuery();

                                string update_sql = "UPDATE garage SET vehicle = -1 WHERE vehicle = " + int.Parse(vehicle_id) + "";                            
                                MySqlCommand update_cmd = new MySqlCommand(update_sql, Connection.conn);
                                update_cmd.ExecuteNonQuery();
                                string plate = btn.Text.Replace("Dolu Sıra - ", "");
                                MessageBox.Show(plate);
                                btn.Text = "Boş Sıra - " + now_i_id;
                                btn.Name = "btn_"+now_i_id;
                                btn.BackColor = Color.Green;
                                string log_sql = "INSERT INTO logs SET log_type = 1, user = '" + Functions.AdminUsername + "', plate = '" + plate + "', date = " + DateTime.Now + "";
                                MySqlCommand log_cmd = new MySqlCommand(log_sql, Connection.conn);
                                log_cmd.ExecuteNonQuery();
                                MessageBox.Show("Belirtilen araç otopark içerisinden çıkartıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                            
                        };
                    }
                    else
                    {
                        MessageBox.Show("Veritabanı hatası oluştu. (G-1)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                else
                {
                    btn = new Button()
                    {
                        Height = 100,
                        Width = 120,
                        Text = "Boş Sıra - " + i,
                        Name = "btn_" +i,
                        BackColor = Color.Green,
                    };
                }

                panel1.Controls.Add(btn);

                TopSpace = (btn.Height * (AddedButton_Height / btn.Height));

                AddedButton_Height += btn.Height;

                switch (AddedButton_Height > panel1.Height)
                {
                    case true:
                        TopSpace = 0;

                        LeftSpace += btn.Width;

                        AddedButton_Height = btn.Height;
                        break;
                }
                btn.Location = new Point(LeftSpace + 10, TopSpace + 10);
            }
        }
    }
}
