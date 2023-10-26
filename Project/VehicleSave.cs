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
                        string sqlq = "SELECT * FROM vehicles WHERE vehiclePlate = '" + savePlate.Text + "'";
                        MySqlCommand sqlq_cmd = new MySqlCommand(sqlq, Connection.conn);
                        MySqlDataReader sqlq_rdr = sqlq_cmd.ExecuteReader();
                        if (sqlq_rdr.Read()) 
                        {
                            int vehicle_id = (int)sqlq_rdr[0];
                            sqlq_rdr.Close();
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
                            }                                                        
                        }                                                                        
                    }                    
                    return;
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
