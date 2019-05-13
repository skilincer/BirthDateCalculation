using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doğum_tarihi_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime dt = dateTimePicker1.Value;  // takvim üzerinde işaretlediğimiz gün ay yıl.
            DateTime şimdikizaman = DateTime.Now; // şimdiki olduğumuz zaman alınır
            TimeSpan zaman = şimdikizaman - dt;   // 
            MessageBox.Show("Siz dogduktan sonra " + zaman.Days +" gün geçmis. ");

        
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
