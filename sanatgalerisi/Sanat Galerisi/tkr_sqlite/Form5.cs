using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkr_sqlite
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
	    	private void  Temizle()
	    	{
			richTextBox1.Clear();
			richTextBox1.Visible = true;
	    	}

		private void button2_Click(object sender, EventArgs e)
        {
			cicekbox.Visible = false;
			
			try
			{
				int id = Convert.ToInt32(textBox1.Text);
				string eserad = textBox2.Text;
				Form1.con.Open();
				Form1.cmd.Connection = Form1.con;
				Form1.cmd.CommandText = "Select * from eserler where ID= '" + id + "'  ";
				Form1.okuyucu = Form1.cmd.ExecuteReader();
				Form1.okuyucu.Read();
				textBox1.Text = Form1.okuyucu["ID"].ToString();
				textBox2.Text = Form1.okuyucu["EserAd"].ToString();
				if (id == 1)
				{
					ciglik.Visible = false;
					yildizligece.Visible = true;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = false;
					venusundogusu.Visible = false;
					belleginazmi.Visible = false;
					opucuk.Visible = false;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = false;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "Yıldızlı Gece, Hollandalı art izlenimci ressam Vincent van Gogh tarafından yapılan yağlı" + "boya tablo. Haziran 1889'da yaptığı tabloda ressam, sanatoryumdaki odasının doğuya bakan pencereden görünen " + "Saint-Rémy-de-Provence köyünün gün doğuşundan hemen önceki görünüşünü resmetmiştir." +
					"Tür: Peyzaj; Sergilendiği yer: Museum Of Modern Art";
				}
				else if (id == 2)
				{
					ciglik.Visible = true;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = false;
					venusundogusu.Visible = false;
					belleginazmi.Visible = false;
					opucuk.Visible = false;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = false;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "Çığlık, Norveçli ressam Edvard Munch tarafından yapılan 1893 tarihli tablo. Eserin Norveççe adı Skrik, ilk kez sergilendiği Almanca adı ise Der Schrei der Natur'dur. Tablodaki ıstırap çeken yüz, sanatın en ikonik imgelerinden biri haline gelmiştir ve insanın kaygısını sembolize ettiği düşünülmektedir. " +
					"Tür: Yağlıboya ve pastel; Sergilendiği yer: Norveç Ulusal Müzesi";
				}
				else if (id == 3)
				{
					ciglik.Visible = false;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = true;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = false;
					venusundogusu.Visible = false;
					belleginazmi.Visible = false;
					opucuk.Visible = false;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = false;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "İnci Küpeli Kız, Hollandalı ressam Johannes Vermeer'in başyapıtlarından biri olan tablodur. Adından anlaşılacağı gibi odak noktası bir inci küpedir. Eser, 1902'den beri Lahey'de, Mauritshuis'te sergilenmektedir ve çeşitli edebî tedavilere konu olmuştur." +
						"Tür: Tronie; Sergilendiği yer: Rijksmuseum Amsterdam (2023)";
				}
				else if (id == 4)
				{
					ciglik.Visible = false;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = true;
					monalisa.Visible = false;
					venusundogusu.Visible = false;
					belleginazmi.Visible = false;
					opucuk.Visible = false;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = false;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "Adem'in Yaratılışı, Sistine Şapeli'nin tavanındaki ünlü bir fresktir. Michelangelo tarafından 1511 dolaylarında yapılmıştır. Tüm zamanların en çok replikası yapılan dinî resimlerinden biridir." +
						"Türler: Christian art, Tarih resmi; Sergilendiği yer: Sistina Şapeli, Konu: Âdem";
				}
				else if (id == 5)
				{
					ciglik.Visible = false;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = true;
					venusundogusu.Visible = false;
					belleginazmi.Visible = false;
					opucuk.Visible = false;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = false;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "Mona Lisa, İtalya'nın Floransa şehrindeki Rönesans sırasında Leonardo da Vinci tarafından kavak bir pano üzerine Sfumato tekniği ile resmedilmiş 16. yüzyıl yağlı boya portresidir. Resim hâlen Paris'teki Louvre Müzesi'nde Francesco del Giocondo'nun karısı, Lisa Gherardini Portresi başlığı altında sergilenmektedir." +
						"Türler: Portre, Portre resim; Sergilendiği yer: Louvre Müzesi ";
				}
				else if (id == 6)
				{
					ciglik.Visible = false;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = false;
					venusundogusu.Visible = true;
					belleginazmi.Visible = false;
					opucuk.Visible = false;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = false;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "Venüs'ün Doğuşu, İtalyan ressam Sandro Botticelli'nin 1482–1486 yılları arasında tuval üzerine tempera ile çizdiği tablodur. Tabloda, Venüs'ün ergen bir kadın olarak denizden doğarak kıyıya çıkışı betimlenir. Dünyanın en bilinen resimlerinden biri olan tablo, Floransa'daki Uffizi'de sergilenmektedir." +
						"Tür: Tarih resmi; Sergilendiği yer: Uffizi";
				}
				else if (id == 7)
				{
					ciglik.Visible = false;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = false;
					venusundogusu.Visible = false;
					belleginazmi.Visible = true;
					opucuk.Visible = false;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = false;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "Belleğin Azmi ya da Eriyen Saatler, İspanyol sanatçı Salvador Dalí tarafından 1931 yılında yapılan ve en bilinen eserlerinden biri olan tablo. 1932 yılında 250 Amerikan doları karşılığında satılan tablo, 1934 yılından bu yana New York'taki National Museum of Art'ta sergilenmeketdir." +
						"Tür: Alegori; Sergilendiği yer: Museum Of Modern Art";
				}
				else if (id == 8)
				{
					ciglik.Visible = false;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = false;
					venusundogusu.Visible = false;
					belleginazmi.Visible = false;
					opucuk.Visible = true;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = false;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "Öpücük Avusturyalı Sembolist ressam Gustav Klimt tarafından altın varak, gümüş ve platin içeren bir tuval üzerine yapılmış bir yağlı boya eseridir. 1907 ve 1908 yıllarında, akademisyenlerin “Altın Dönem” dediği dönemde yapılmış ve 1908'de Liebespaar başlığı altında sergilenmiş." +
						"Tür: Tür Resmi; Sergilendiği yer: Österreichische Galerie Belvedere";
				}
				else if (id == 9)
				{
					ciglik.Visible = false;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = false;
					venusundogusu.Visible = false;
					belleginazmi.Visible = false;
					opucuk.Visible = false;
					corbakonserveleri.Visible = true;
					sonaksamyemegi.Visible = false;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "Campbell'in çorba konserveleri Andy Warhol tarafından 1962 yılında üretilmiş bir sanat eseridir. Her biri 50,8 x 40,6 cm. boyutunda olan ve üzerine yapıldığı dönemde Campbell Soup Company (Campbell Çorba Şirketi) tarafından piyasaya sürülmüş çorba konserveleri çeşitlerinin resmedildiği 32 tuvalden oluşur. Otuz iki resmin her biri, gölgesel olmayan tarzda, yarı mekanik bir baskıresim yöntemi olan serigrafi ile yapılmıştır. Campbell's Soup Cans resimlerinin popüler kültür temasına dayanması ABD'de pop sanatının önemli bir sanat hareketi olmasına öncülük etmiştir." +
						"Tür: Pop; Sergilendiği yer: Museum Of Modern Art";
				}
				else if (id == 10)
				{
					ciglik.Visible = false;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = false;
					venusundogusu.Visible = false;
					belleginazmi.Visible = false;
					opucuk.Visible = false;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = true;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "Son Akşam Yemeği ya da Son Yemek, 15. yüzyılda Milano'da Leonardo da Vinci tarafından Duke Lodovico Sforza'nın isteği üzerine yapılmış fresktir. Hristiyan inanışına göre, İsa Mesih'in Romalı askerlerce tutuklanmasından bir gün önce havarileriyle yediği son akşam yemeğini ifade eder." +
						"Türler: Christian art, Tarih resmi; Sergilendiği yer: Santa Maria delle Grazie";
				}
				else if (id == 11)
				{					
					ciglik.Visible = false;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = false;
					venusundogusu.Visible = false;
					belleginazmi.Visible = false;
					opucuk.Visible = false;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = false;
					guernica.Visible = true;
					arnoflininevlenmesi.Visible = false;
					Temizle();

					richTextBox1.Text = "Guernica, Pablo Picasso tarafından 1937'de yapılan, İspanya İç Savaşı sırasında Nazi Almanyası'na ait 28 bombardıman uçağının 26 Nisan 1937'de İspanya'daki Guernica şehrini bombalamasını anlatan, 7,76 m eninde ve 3,49 m yüksekliğinde anıtsal tablodur. " +
						"Konu: Savaş, İspanya İç Savaşı, Azap; Sergilendiği yerler: Kraliçe Sofia Ulusal Sanat Müzesi";
				}
				else if (id == 12)
				{
					ciglik.Visible = false;
					yildizligece.Visible = false;
					incikupelikkiz.Visible = false;
					ademinyaratilisi.Visible = false;
					monalisa.Visible = false;
					venusundogusu.Visible = false;
					belleginazmi.Visible = false;
					opucuk.Visible = false;
					corbakonserveleri.Visible = false;
					sonaksamyemegi.Visible = false;
					guernica.Visible = false;
					arnoflininevlenmesi.Visible = true;
					Temizle();

					richTextBox1.Text = "Arnolfini'nin Evlenmesi, ressam Jan van Eyck'e ait, 1434 yılında yapılan yağlı boya tablo. Güzellik, karmaşık ikonografi, geometrik dikey perspektif ve aynanın kullanılmasıyla resim alanının genişlemesi nedeniyle, Batı sanatındaki özgün ve karmaşık tablolardan birisi olarak kabul görülür." +
						"Konu : evlilik; Sergilendiği Yer: National Gallery";
				}
				Form1.okuyucu.Close();
				Form1.con.Close();
			}
			catch
			{
				MessageBox.Show("Girdiğiniz ID kayıtlı değil.");
				Form1.okuyucu.Close();
				Form1.con.Close();
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
			//Kapandığında 2. kez bağlantı kuramadığı için Close yerine Hide kullandım
		}

		private void Form5_Load(object sender, EventArgs e)
		{
			textBox2.Enabled = false;

		}
	}
}
