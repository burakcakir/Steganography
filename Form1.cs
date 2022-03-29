using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiberGuvenlikOdev
{
    public partial class Form1 : Form
    {        
        Bitmap image;

        string resimYolu;

        public Form1()
        {
            InitializeComponent();

            tbGizlenmisMetin.Enabled = false;
            tbGizlenmisMetin.Visible = false;
            lblGizlenmisMetin.Visible = false;
        }

        //gizlenecek olan resmin seçilmesi işlemi
        private void btnGizlenecekResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.png) | *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                resimYolu = dialog.FileName.ToString();
                image = new Bitmap(resimYolu);
                pictureBox1.Image = (Image)image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //gizlenmiş olan resmin seçilmesi işlemi
        private void btnGizlenmisMetinSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.png) | *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                resimYolu = dialog.FileName.ToString();
                image = new Bitmap(resimYolu);
                pictureBox1.Image = (Image)image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //kullanıcıdan alınan metinin resim içerisine gizlenme işlemi
        private void btnGizle_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)image;

            char[] dizi1 = tbGizlenecekMetin.Text.ToArray();
            image.SetPixel(image.Width - 1, image.Height - 1, Color.FromArgb(0, 0, dizi1.Length));
            for (int j = 0; j < tbGizlenecekMetin.TextLength; j++)
            {
                Color piksel = image.GetPixel(image.Width - 2, j);
                image.SetPixel(image.Width - 2, j, Color.FromArgb(piksel.R, piksel.G, dizi1[j]));
            }

            //şifrelenen resmi kaydetme
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.png) | *.png";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                resimYolu = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = resimYolu;

                image.Save(resimYolu);
            }

        }

        //resim içerisinde gizlenmiş olan metnin çözülmesi işlemi
        private void btnSifreyiCoz_Click(object sender, EventArgs e)
        {
            string anamesaj = "";
            Color sonpiksel = image.GetPixel(image.Width - 1, image.Height - 1);
            int mesajuzunlugu = sonpiksel.B;
            for (int j = 0; j < mesajuzunlugu; j++)
            {
                Color piksel = image.GetPixel(image.Width - 2, j);
                anamesaj += (char)piksel.B;
            }

            tbGizlenmisMetin.Visible = true;
            lblGizlenmisMetin.Visible = true;

            tbGizlenmisMetin.ForeColor = Color.Green;
            tbGizlenmisMetin.Text = anamesaj;
        }

        //soket bağlantısı ile resmi gönderme işlemi
        private void btnGonder_Click(object sender, EventArgs e)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 13000); // GÖNDEREN KİŞİ IP
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(iep);
            server.Listen(10);

            using (Socket client = server.Accept()) // karşı taraf ortama bağlandığında
            {
                ImageConverter converter = new ImageConverter();
                byte[] buffer = (byte[])converter.ConvertTo(image, typeof(byte[]));

                client.Send(buffer, buffer.Length, SocketFlags.None);
            }

            server.Close();
        }

        //soket bağlantısı ile gönderilen resmi alma işlemi
        private void btnAl_Click(object sender, EventArgs e)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 13000); //gönderen kisi ipsine bağlanılır
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                client.Connect(iep);
                byte[] buffer = new byte[200000000];
                client.Receive(buffer, buffer.Length, SocketFlags.None);
                File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//SifrelenenResim.jpg", buffer);

                image = new Bitmap(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//SifrelenenResim.jpg");
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
