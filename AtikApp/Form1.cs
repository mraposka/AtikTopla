using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AtikApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Globals
        Kutu organikKutu = new Kutu { DoluHacim = 0, DolulukOrani = 0, BosaltmaPuani = 1000, Kapasite = 700 };
        Kutu kagitKutu = new Kutu { DoluHacim = 0, DolulukOrani = 0, BosaltmaPuani = 1000, Kapasite = 1200 };
        Kutu camKutu = new Kutu { DoluHacim = 0, DolulukOrani = 0, BosaltmaPuani = 1000, Kapasite = 2200 };
        Kutu metalKutu = new Kutu { DoluHacim = 0, DolulukOrani = 0, BosaltmaPuani = 1000, Kapasite = 2300 };
        Atik atik1 = new Atik();
        KutuManager mng = new KutuManager();
        ProgressBar activePBar;
        bool ekle = false;
        bool bosalt = false;
        int puan = 0;
        int activeOran = 0;
        //Globals

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            puanKontrolTimer.Start();
            groupBox1.Enabled = false;
        }

        private void _sifirla()
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            organikBox.Items.Clear();
            camBox.Items.Clear();
            metalBox.Items.Clear();
            kagitBox.Items.Clear();
            puan = 0;
            sureTimer.Stop();
            puanKontrolTimer.Stop();
            progressBarAnimasyonTimer.Stop();
            groupBox1.Enabled = false;
            button1.Enabled = true;
            sureTxt.Text = "60";
            puanTxt.Text = "0";
        }

        private void OrganikEkle(object sender, EventArgs e)
        {
            if (atik1.Name == "Domates" || atik1.Name == "Salatalık")
            {
                ekle = mng.Ekle(atik1, organikKutu, organikBox);
                if (ekle)
                {
                    activePBar = progressBar1;
                    activeOran = organikKutu.DolulukOrani;
                    progressBarAnimasyonTimer.Start();
                    puan += atik1.Hacim;
                    _yeniAtik();
                }
                else { }

            }
        }

        private void KagitEkle(object sender, EventArgs e)
        {
            if (atik1.Name == "Dergi" || atik1.Name == "Gazete")
            {
                ekle = mng.Ekle(atik1, kagitKutu, kagitBox);
                if (ekle)
                {
                    activePBar = progressBar2;
                    activeOran = kagitKutu.DolulukOrani;
                    progressBarAnimasyonTimer.Start();
                    puan += atik1.Hacim;
                    _yeniAtik();
                }
                else { }
            }
        }
        private void MetalEkle(object sender, EventArgs e)
        {
            if (atik1.Name == "Kola Kutusu" || atik1.Name == "Salça Kutusu")
            {
                ekle = mng.Ekle(atik1, metalKutu, metalBox);
                if (ekle)
                {
                    activePBar = progressBar4;
                    activeOran = metalKutu.DolulukOrani;
                    progressBarAnimasyonTimer.Start();
                    puan += atik1.Hacim;
                    _yeniAtik();
                }
                else { }
            }
        }
        private void CamEkle(object sender, EventArgs e)
        {
            if (atik1.Name == "Cam Şişe" || atik1.Name == "Bardak")
            {
                ekle = mng.Ekle(atik1, camKutu, camBox);
                if (ekle)
                {
                    activePBar = progressBar3;
                    activeOran = camKutu.DolulukOrani;
                    progressBarAnimasyonTimer.Start();
                    puan += atik1.Hacim;
                    _yeniAtik();
                }
                else { }
            }

        }

        private void _yeniAtik()
        {
            int random = 0;
            Random rnd = new Random();
            random = rnd.Next(0, 8);
            switch (random)
            {

                case 0:
                    //Cam
                    atik1.Name = "Cam Şişe";
                    atik1.Hacim = 600;
                    atik1.Image = Image.FromFile(@"cam.png");
                    pictureBox1.Image = atik1.Image;
                    break;

                //Cam
                case 1:
                    //Bardak
                    atik1.Name = "Bardak";
                    atik1.Hacim = 250;
                    atik1.Image = Image.FromFile(@"bardak.png");
                    pictureBox1.Image = atik1.Image;
                    //Bardak
                    break;

                case 2:
                    //Gazete
                    atik1.Name = "Gazete";
                    atik1.Hacim = 250;
                    atik1.Image = Image.FromFile(@"gazete.png");
                    pictureBox1.Image = atik1.Image;
                    //Gazete
                    break;

                case 3:
                    //Dergi
                    atik1.Name = "Dergi";
                    atik1.Hacim = 200;
                    atik1.Image = Image.FromFile(@"dergi.png");
                    pictureBox1.Image = atik1.Image;
                    //Dergi
                    break;

                case 4:
                    //Domates
                    atik1.Name = "Domates";
                    atik1.Hacim = 150;
                    atik1.Image = Image.FromFile(@"domates.png");
                    pictureBox1.Image = atik1.Image;
                    //Domates
                    break;

                case 5:
                    //Salatalık
                    atik1.Name = "Salatalık";
                    atik1.Hacim = 120;
                    atik1.Image = Image.FromFile(@"salatalik.png");
                    pictureBox1.Image = atik1.Image;
                    //Salatalık
                    break;

                case 6:
                    //Kola
                    atik1.Name = "Kola Kutusu";
                    atik1.Hacim = 350;
                    atik1.Image = Image.FromFile(@"kola.png");
                    pictureBox1.Image = atik1.Image;
                    //Kola
                    break;

                case 7:
                    //Salca
                    atik1.Name = "Salça Kutusu";
                    atik1.Hacim = 550;
                    atik1.Image = Image.FromFile(@"metal.png");
                    pictureBox1.Image = atik1.Image;
                    //Salca
                    break;

                default:
                    break;
            }
        }

        private void OrganikBosalt(object sender, EventArgs e)
        {
            bosalt = mng.Bosalt(organikKutu, organikBox);
            if (bosalt)
            {
                progressBar1.Value = 0;
                puan += 0;
                sureTxt.Text = (Int16.Parse(sureTxt.Text) + 3).ToString();
            }
        }
        private void CamBosalt(object sender, EventArgs e)
        {
            bosalt = mng.Bosalt(camKutu, camBox);
            if (bosalt)
            {
                progressBar3.Value = 0;
                puan += 600;
                sureTxt.Text = (Int16.Parse(sureTxt.Text) + 3).ToString();
            }
        }
        private void MetalBosalt(object sender, EventArgs e)
        {
            bosalt = mng.Bosalt(metalKutu, metalBox);
            if (bosalt)
            {
                progressBar4.Value = 0;
                puan += 800;
                sureTxt.Text = (Int16.Parse(sureTxt.Text) + 3).ToString();
            }
        }
        private void KagitBosalt(object sender, EventArgs e)
        {
            bosalt = mng.Bosalt(kagitKutu, kagitBox);
            if (bosalt)
            {
                progressBar2.Value = 0;
                puan += 1000;
                sureTxt.Text = (Int16.Parse(sureTxt.Text) + 3).ToString();
            }
        }

        private void Yeni(object sender, EventArgs e)
        {
            _sifirla();
            _yeniAtik();
            puanKontrolTimer.Start();
            sureTimer.Start();
            groupBox1.Enabled = true;
            button1.Enabled = false;
        }

        private void Cikis(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PuanKontrol_Tick(object sender, EventArgs e)
        {
            puanTxt.Text = puan.ToString();
        }

        private void ProgressBarAnimasyon_Tick(object sender, EventArgs e)
        {
            if (activePBar.Value < activeOran) activePBar.Increment(5);
            else { activePBar = null; activeOran = 0; progressBarAnimasyonTimer.Stop(); }
        }

        private void SureTimer_Tick(object sender, EventArgs e)
        {
            sureTxt.Text = (Int16.Parse(sureTxt.Text) - 1).ToString();
            if (sureTxt.Text == "0")
            {
                progressBar1.Value = 0;
                progressBar2.Value = 0;
                progressBar3.Value = 0;
                progressBar4.Value = 0;
                organikBox.Items.Clear();
                camBox.Items.Clear();
                metalBox.Items.Clear();
                kagitBox.Items.Clear();
                puan = 0;
                sureTimer.Stop();
                puanKontrolTimer.Stop();
                progressBarAnimasyonTimer.Stop();
                groupBox1.Enabled = false;
                button1.Enabled = true;
                pictureBox1.Image = null;
            }
        }

    }
    public interface IAtik
    {
        int Hacim { get; }
        System.Drawing.Image Image { get; }
        string Name { get; set; }
    }
    public interface IAtikKutusu : IDolabilen
    {
        int BosaltmaPuani { get; }

        bool Ekle(IAtik atik);
        bool Bosalt();
    }
    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }
    }
    class Atik : IAtik
    {
        public int Hacim { get; set; }

        public Image Image { get; set; }

        public string Name { get; set; }
    }
    class Kutu : IAtikKutusu
    {
        public int BosaltmaPuani { get; set; }
        public int Kapasite { get; set; }

        public int DoluHacim { get; set; }

        public int DolulukOrani { get; set; }

        public bool Bosalt()
        {
            return false;
        }

        public bool Ekle(IAtik atik)
        {
            return false;
        }
    }
    class KutuManager
    {
        public int BosaltmaPuani { get; set; }
        public int Kapasite { get; set; }

        public int DoluHacim { get; set; }

        public int DolulukOrani { get; set; }
        public bool Ekle(IAtik atik, Kutu kutu, ListBox lb)
        {
            if (kutu.Kapasite - kutu.DoluHacim > atik.Hacim)
            {
                kutu.DoluHacim += atik.Hacim;
                double oran = (kutu.DoluHacim * 100) / kutu.Kapasite;
                kutu.DolulukOrani = Convert.ToInt32(oran);
                lb.Items.Add(atik.Name + "(" + atik.Hacim + ")");
                return true;
            }
            else
            { return false; }
        }
        public bool Bosalt(Kutu kutu, ListBox lb)
        {
            if (kutu.DolulukOrani >= 75)
            {
                kutu.DoluHacim = 0;
                kutu.DolulukOrani = 0;
                lb.Items.Clear();
                return true;
            }
            else
                return false;
        }

    }

}
