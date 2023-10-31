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
    public partial class VehicleSave : Form
    {
        public VehicleSave()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveBrand.TextLength < 1 || saveModel.TextLength < 1 || savePlate.TextLength < 1 || saveOwner.TextLength < 1)
            {
                MessageBox.Show("Kayıt bilgileri boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string select_sql = "SELECT * FROM vehicles WHERE vehiclePlate = '" + savePlate.Text + "'";
                    MySqlCommand select_cmd = new MySqlCommand(select_sql, Connection.conn);
                    MySqlDataReader rdr = select_cmd.ExecuteReader();                    
                    //                                       
                    if (rdr.Read())
                    {
                        MessageBox.Show("Bu aracın kaydı daha öncesinde girilmiş.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rdr.Close();
                    }
                    else
                    {
                        rdr.Close();
                        string sql = "INSERT INTO vehicles (vehicleBrand, vehicleModel, vehiclePlate, vehicleOwner) VALUES ('" + saveBrand.Text + "','" + saveModel.Text + "', '" + savePlate.Text + "', '" + saveOwner.Text + "')";                        
                        MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(cmd.LastInsertedId.ToString());
                        if (true) 
                        {
                            int vehicle_id = (int)cmd.LastInsertedId;
                            string garage_sql = "SELECT * FROM garage WHERE vehicle = -1";
                            MySqlCommand garage_cmd = new MySqlCommand(garage_sql, Connection.conn);
                            MySqlDataReader garage_rdr = garage_cmd.ExecuteReader();
                            //                        
                            if (garage_rdr.Read())
                            {                                
                                string update_sql = "UPDATE garage SET vehicle = " + vehicle_id + " WHERE id = " + garage_rdr[0] + "";
                                garage_rdr.Close();
                                MySqlCommand update_cmd = new MySqlCommand(update_sql, Connection.conn);
                                update_cmd.ExecuteNonQuery();
                                string log_sql = "INSERT INTO logs SET log_type = 0, user = '"+Functions.AdminUsername+"', plate = '"+savePlate.Text+"', date = "+ DateTime.Now + "";                        
                                MySqlCommand log_cmd = new MySqlCommand(log_sql, Connection.conn);
                                log_cmd.ExecuteNonQuery();
                                string mng_sql = "UPDATE management SET cash = cash + 200";
                                MySqlCommand mng_cmd = new MySqlCommand(mng_sql, Connection.conn);
                                mng_cmd.ExecuteNonQuery();
                                MessageBox.Show("Araç başarıyla otopark içerisine kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }  
                            else
                            {
                                string delete_sql = "DELETE FROM vehicles WHERE vehiclePlate = '"+savePlate.Text+"'";
                                MySqlCommand delete_cmd = new MySqlCommand(delete_sql, Connection.conn);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Garaj içerisinde boş yer kalmadığı için araç garaja alınmadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }                                                                        
                    }                                       
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası oluştu. (VS-1) "+ex+"", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void VehicleSave_Load(object sender, EventArgs e)
        {
            if (Functions.AdminLevel == 2)
            {
                pictureBox1.ImageLocation = "https://clipart-library.com/2023/Admin-Profile-PNG-Clipart.png";
            }
            else
            {
                pictureBox1.ImageLocation = "https://clipart-library.com/2023/Admin-Profile-Vector-PNG-Clipart.png";
            }
            saveAdminLabel.Text = "Hoşgeldin, " + Functions.AdminUsername + "";
        }
    }
}
