using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tkr_sqlite
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public DataTable dt;
        public int id;

		public static SQLiteConnection con = new SQLiteConnection("Data Source = C:\\sanatgalerisi\\performansodevi.db;Version = 3");
		public static SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select ID, Sanatci, EserAd, Cizimt from eserler", con);
		public static SQLiteCommand cmd = new SQLiteCommand();
		public static SQLiteDataReader okuyucu;
		public static Form2 frm2 = new Form2();
		public static Form5 frm5 = new Form5();

		private void Temizle()
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
		}
		private void Form2_Load(object sender, EventArgs e)
        {
            Form1.con.Open();
            dt = new DataTable();
            Form1.adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Form1.con.Close(); 
			textBox4.Text = Form1.frm2.dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
			textBox2.Text = Form1.frm2.dataGridView1.CurrentRow.Cells["EserAd"].Value.ToString();				
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string id = textBox4.Text;
				con.Open();
				cmd.Connection = con;				
				cmd.CommandText = "DELETE FROM eserler WHERE ID ='" + id + "' ";
				cmd.ExecuteNonQuery();
				con.Close();
			   Application.Restart();			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form1.con.Open();
			Form1.cmd.Connection = Form1.con;
			Form1.cmd.CommandText = ("INSERT INTO eserler (ID, Sanatci, EserAd, Cizimt) VALUES ('" + Convert.ToInt32(textBox4.Text) + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')");
			Form1.cmd.ExecuteNonQuery();
			Form1.con.Close();
			Application.Restart();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			try
			{
				DialogResult sonuc = MessageBox.Show("Verinin güncellenmesini istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (sonuc == DialogResult.Yes)
				{
					Form1.con.Open();
					Form1.cmd.Connection = Form1.con;
					int ıd = Convert.ToInt32(Form1.frm2.dataGridView1.CurrentRow.Cells["ID"].Value);
					Form1.cmd.CommandText = "UPDATE eserler set Sanatci = '" + textBox1.Text + "', EserAd = '" + textBox2.Text + "', Cizimt = '" + textBox3.Text + "' where ID = '" + ıd + "' ";
					Form1.cmd.ExecuteNonQuery();
					Form1.con.Close();
				    Application.Restart();
				}
			}

			catch
			{
				MessageBox.Show("Girdiğiniz ID geçersiz.");
				Form1.okuyucu.Close();
				Form1.con.Close();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			//Kapandığında 2. kez bağlantı kuramadığı için Close yerine Hide kullandım
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			textBox4.Text = Form1.frm2.dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
			textBox1.Text = Form1.frm2.dataGridView1.CurrentRow.Cells["Sanatci"].Value.ToString();
			textBox2.Text = Form1.frm2.dataGridView1.CurrentRow.Cells["EserAd"].Value.ToString();
			textBox3.Text = Form1.frm2.dataGridView1.CurrentRow.Cells["Cizimt"].Value.ToString();
		}

		private void btnT_Click(object sender, EventArgs e)
		{
			Temizle();
		}
	}
}
