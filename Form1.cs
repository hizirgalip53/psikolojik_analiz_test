using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psikolojik_Analiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru;
        int toplam = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            soru++;
            button6.Text = "Sonraki";
            button6.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            if (soru == 1)
            {
                textBox1.Text = "1.Eşinizle mükemmel bir akşam size ne çağırıştırıyor?";
                button1.Text = "Bir konsere gitmek";
                button2.Text = "lunapark gitmek";
                button3.Text = "Sinemaya gitmek";
                button4.Text = "Romantik yemek yemek";
                button5.Text = "Arabayla turlamak";
            }
            if (soru == 2)
            {
                textBox1.Text = "2.En sevdiğiniz müzik türü nedir?";
                button1.Text = "Alternatif";
                button2.Text = "Rockn roll";
                button3.Text = "pop";
                button4.Text = "Türkü";
                button5.Text = "Arabesk";
            }
            if (soru == 3)
            {
                textBox1.Text = "3.En sevdiğiniz film türü nedir?";
                button1.Text = "Korku";
                button2.Text = "Komedi";
                button3.Text = "Aksiyon";
                button4.Text = "Romantik";
                button5.Text = "Belgesel";
            }
            if (soru == 4)
            {
                textBox1.Text = "4.Aşağıdaki mesleklerden hangisini seçerdin?";
                button1.Text = "Asker";
                button2.Text = "Doktor";
                button3.Text = "Boksör";
                button4.Text = "Yazılımcı";
                button5.Text = "Bilim adamı";
            }
            if (soru == 5)
            {
                textBox1.Text = "5.Bir saat boş vaktinizi değerlendirmek için hangisi size daha uygun?";
                button1.Text = "Kuran-ı Kerim okumak";
                button2.Text = "Antrenman yapmak";
                button3.Text = "Gezmek";
                button4.Text = "Bilgisayar oynamak";
                button5.Text = "Ders çalışmak";
            }
            if (soru == 6)
            {
                textBox1.Text = "6.Aşağıdaki renklerdedn biriniz seçiniz?";
                button1.Text = "Mavi";
                button2.Text = "Kırmızı";
                button3.Text = "Siyah";
                button4.Text = "Turuncu";
                button5.Text = "Sarı";
            }
            if (soru == 7)
            {
                textBox1.Text = "7.Şuan önünüzde hangi yiyecek olsa dayanamayıp yersiniz?";
                button1.Text = "Kebap";
                button2.Text = "Tantuni";
                button3.Text = "KuruFasulye";
                button4.Text = "Makarna";
                button5.Text = "Balık";
            }
            if (soru == 8)
            {
                textBox1.Text = "8.En sevdiğiniz tatil günü hangisidir?";
                button1.Text = "Kurban";
                button2.Text = "Ramazan";
                button3.Text = "Miraç";
                button4.Text = "Regaip";
                button5.Text = "KadirGecesi";
            }
            if (soru == 9)
            {
                textBox1.Text = "9.Şuan nerde olmak isterdin?";
                button1.Text = "Rizede";
                button2.Text = "İstanbulda";
                button3.Text = "Bahamalarda";
                button4.Text = "Amerikada";
                button5.Text = "Dağlarda";
            }
            if (soru == 10)
            {
                textBox1.Text = "10.Nasıl biriyle vakit geçirmekten hoşlanırsın?";
                button1.Text = "Çlgın";
                button2.Text = "Eğlenceli";
                button3.Text = "Kavgacı";
                button4.Text = "Sakin";
                button5.Text = "Güzel ";
            }
            if (soru == 11)
            {
                label2.Text = toplam.ToString();
                
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam = toplam + 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplam = toplam + 2;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toplam = toplam + 3;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toplam = toplam + 4;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }
      

        private void button5_Click(object sender, EventArgs e)
        {
            toplam = toplam + 5;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (toplam >= 10 && toplam <= 17)
            {
                textBox1.Text = "Siz çok çılgın birisiniz";
            }
            if (toplam >= 18 && toplam <= 26)
            {
                textBox1.Text = "Siz eğlenceli ve popüler birisiniz";
            }
            if (toplam >= 27 && toplam <= 34)
            {
                textBox1.Text = "Öyle tatlısınızki sizi sevmemek imkansız";
            }
            if (toplam >= 35 && toplam <= 42)
            {
                textBox1.Text = "Siz iflah olmaz bir romantiksiniz";
            }
            if (toplam >= 43 && toplam <= 50)
            {
                textBox1.Text = "Belirgen özelliğiniz hızlı ve doğru kara veriyor olmanız";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

        }
    }
}
