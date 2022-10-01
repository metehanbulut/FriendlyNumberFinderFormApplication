using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sakarya_Nesneye_Dayalı_Programlama_Odevi
{
    /*
     
                        SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........:  1 
**				ÖĞRENCİ ADI............: METEHAN BULUT
**				ÖĞRENCİ NUMARASI.......: s201210936
**              DERSİN ALINDIĞI GRUP...:  YAZ OKULU 

     
     
     
     */
    public partial class Form1 : Form
    {   

        /* alıştığımdan ötürü fonksiyonlar ile çalıştım hocam 3 temel fonksiyonumuz var 
         * birincisi bileşenleri ekliyor
         * ikincisi formu genişletiyor
         * üçüncüsü sayıların arkadaş olma işlemini hesaplıyor ve değerleri göstertiyor. 
         * 
         * Daha profosyonelce de yazılabilirdi fakat olabildiğince ödevdekine benzetmek istedim.
         * Örneğin Textboxların enabled özelliği kapatılabilirdi, girişin string girilmesi eklenebilirdi vs. fakat 
         * istendiğinden fazla yazıp kod kalablığı yapmak istemedim.*/


        bool bilesenler_eklendi_mi = false;
        ListBox x_listbox = new ListBox();
        TextBox x_textbox_gosteren = new TextBox(); // kullanıcının girdiği textbox ile aynı ada sahip olmasın diye _gosteren diye ekledim ona da bu ismi vermiştim
        ListBox y_listbox = new ListBox();
        TextBox y_textbox_gosteren = new TextBox();
        int toplam_x = 0;
        int toplam_y = 0;
        // dışarıdan erişilecek nesneleri burada tanımlıyoruz ki diğer fonksiyonlardan ve sınıflardan erişebilelim

        public Form1()
        {
            InitializeComponent();
        }

        private void button_son_Click(object sender, EventArgs e)
        {
            /* Son butonuna bastığında programın kapanması için sadece this.close deyimi eklendi.*/
            this.Close();
        }

        private void button_arkadasmi_Click(object sender, EventArgs e) 
        {
            if(bilesenler_eklendi_mi==false) // böylelikle tekrar tekrar bileşen ekleyip form genişletmesinin önüne geçiliyor.
            { 
                bilesenleri_ekle();
                formu_genislet();
            }

            try  // hata verecek değerler girildiğinde hata olursa diye buraya try catch ekledim
            {
                arkadasmi_hesapla(int.Parse(x_textbox.Text), int.Parse(y_textbox.Text));
            }
            catch
            {
                MessageBox.Show("Lütfen Uygun değerler giriniz");
            }

        }

        private void bilesenleri_ekle()
        {

            /* 
       Listbox oluştur --> Label oluştur --> TextBox oluştur

        listboxun konumuna göre label, listboxun konumuna göre textbox oluşturulacak. 

        Daha dinamik bir yapı olsun diye bu şekilde çalıştım hocam. 
         */




            /************************************ x BİLEŞENLERİ ******************************************************************/


            x_listbox.SetBounds(x_textbox.Location.X + 250, x_textbox.Location.Y, 100, 250); // textboxun locationuna göre konumlandırılıyor ve boyut veriliyor
            this.Controls.Add(x_listbox);

            // x listboxu eklendi

            Label X_Labeli = new Label();
            X_Labeli.Text = "X";
            X_Labeli.Font = new Font("Times New Roman", 12, FontStyle.Bold);       // yazının Stilini değiştirip daha güzel gözüksün diye oluştururken stil veriyorum
            X_Labeli.TextAlign = ContentAlignment.MiddleCenter;                   // yazı tabloyu ortalasın diye Align'ini mid yapıyoruz 
            X_Labeli.SetBounds(x_listbox.Location.X, x_listbox.Location.Y - 20, x_listbox.Width, 20); // listenin 20 px üstünde genişliği listbox ile aynı olan label oluşturuluyor
            this.Controls.Add(X_Labeli);

            //x labeli eklendi

            x_textbox_gosteren.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            x_textbox_gosteren.SetBounds(x_listbox.Location.X, x_listbox.Location.Y + x_listbox.Height + 20, x_listbox.Width, 20); // listenin uzunluğu ile listenin y değeri toplanarak listenin en altına iniliyor ve 20 eklenerek uygun bir konum elde ediliyor.
            this.Controls.Add(x_textbox_gosteren);

            // x textboxu eklendi

            /************************************ Y BİLEŞENLERİ ******************************************************************/


            y_listbox.SetBounds(x_listbox.Location.X + 150, x_listbox.Location.Y, 100, 250);
            this.Controls.Add(y_listbox);

            // y listboxu eklendi

            Label Y_Labeli = new Label();
            Y_Labeli.Text = "Y";
            Y_Labeli.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            Y_Labeli.TextAlign = ContentAlignment.MiddleCenter;
            Y_Labeli.SetBounds(y_listbox.Location.X, y_listbox.Location.Y - 20, y_listbox.Width, 20);
            this.Controls.Add(Y_Labeli);

            //y labeli eklendi

            y_textbox_gosteren.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            y_textbox_gosteren.SetBounds(y_listbox.Location.X, y_listbox.Location.Y + y_listbox.Height + 20, y_listbox.Width, 20);
            this.Controls.Add(y_textbox_gosteren);

            // y textboxu eklendi

            Label toplamlar_labeli = new Label();
            toplamlar_labeli.Text = "TOPLAMLAR :";
            toplamlar_labeli.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            toplamlar_labeli.SetBounds(x_textbox_gosteren.Location.X -115, x_textbox_gosteren.Location.Y+5, 150, 75); // buradaki değerler tamamıyla görsellik güzel gözüksün diye konmuş değerler
            this.Controls.Add(toplamlar_labeli);

            // toplamlar labeli eklendi

            bilesenler_eklendi_mi = true; // bu bool deger ile tekrar eklenmesini kontrol edecegiz
            
        }
        private void formu_genislet()
        {
            this.SetBounds(this.Location.X,this.Location.Y,600,400);
            this.MinimumSize=this.MaximumSize = this.Size; // formun büyütülüp küçültülmesini engelliyorum
        }
        private void arkadasmi_hesapla(int x,int y)
        {
            x = int.Parse(x_textbox.Text);
            y = int.Parse(y_textbox.Text);

            toplam_x = 0;
            toplam_y = 0;
            x_listbox.Items.Clear();
            y_listbox.Items.Clear(); // değerleri temizliyorum ki tekrar girişte karışmasın

            /* sayının birden kendine kadar olan tüm sayılara bölünerek 
                tam bölenleri listeye bir döngü oluşturuyorum.*/
            for (int i = 1; i < x; i++) 
            {
                if (x % i == 0) // sayı tam bölünüyorsa evet diyecek if kontrolü
                {
                    x_listbox.Items.Add(i);
                    toplam_x += i;
                }
            }
            for (int i = 1; i < y; i++) // ikinci sayı için aynı işlem
            {
                if (y % i == 0) // sayı tam bölünüyorsa evet diyecek if kontrolü
                {
                    y_listbox.Items.Add(i);
                    toplam_y += i;
                }
            }
            x_textbox_gosteren.Text = toplam_x.ToString(); 
            y_textbox_gosteren.Text = toplam_y.ToString();

            if(toplam_x==y && toplam_y==x)  // arkadaş olup olmadığını kontrol eden if
            {
                MessageBox.Show("Sayılar Arkadaştır :) !");
            }
            else
            {
                MessageBox.Show("Sayılar Arkadaş Değildir :( !");
            }
        }
        
    }
}
