using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    internal class Functions
    {
        public static bool AdminLogin = false;
        public static string AdminUsername = "";
        public static int AdminLevel;
        public static int AdminLoginType = -1;        

        public static void UpdateAdminLogin()
        {
            if (Functions.AdminLevel == 2)
            {
                Main.pictureBox1.ImageLocation = "https://clipart-library.com/2023/Admin-Profile-PNG-Clipart.png";
                Main.toolStripMenuItem3.Visible = true;
                Main.toolStripMenuItem4.Visible = true;
                Main.mainManagementPanel.Visible = true;
            }
            else
            {
                Main.pictureBox1.ImageLocation = "https://clipart-library.com/2023/Admin-Profile-Vector-PNG-Clipart.png";
            }
            Main.mainAdminLabel.Text = "Hoşgeldin, " + Functions.AdminUsername;            
        }
        public static string RandomPassword()
        {
            int length = 20;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
