using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace tkr_sqlite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		public static SQLiteConnection con = new SQLiteConnection("Data Source =C:\\Users\\MSI\\Desktop\\sanatgalerisi\\performansodevi.db;Version = 3");
		public static SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select ID, Sanatci, EserAd, Cizimt from eserler", con);
		public static SQLiteCommand cmd = new SQLiteCommand();
		public static SQLiteDataReader okuyucu;

		public static Form2 frm2 = new Form2();
		public static Form5 frm5 = new Form5();

		private void Form1_Load(object sender, EventArgs e)
        {
           // frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            frm2.Show();       			
        }

        private void button3_Click(object sender, EventArgs e)
        {
			DialogResult sonuc = MessageBox.Show("Verinin silinmesini istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (sonuc == DialogResult.Yes)
			{
				con.Open();
				cmd.Connection = con;
				int ıd = Convert.ToInt32(frm2.dataGridView1.CurrentRow.Cells["ID"].Value);
				cmd.CommandText = "Delete from eserler where ID ='" + ıd + "' ";
				cmd.ExecuteNonQuery();
				con.Close();
				Application.Restart();
			}
		}

      
        private void button5_Click(object sender, EventArgs e)
        {
            frm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
