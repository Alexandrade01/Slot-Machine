using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Media;

namespace ProjetoCaçaNiquel1._1
{
    public partial class Main : Form
    {
        private SoundPlayer _soundPlayerresult;
        private SoundPlayer _soundPlayer;
        private static string p1;
        private static string p2;
        private static string p3;
        private int tempo;
        Jogador novojogador;
        public string Nomemain { get; set; }


        List<string> listaRoleta;

        public string Nome { get; set; }

        public Main()
        {
            InitializeComponent();
            listaRoleta = new List<string>();
            listaRoleta.Add("laranja.png");
            listaRoleta.Add("banana.png");
            listaRoleta.Add("banana.png");
            listaRoleta.Add("banana.png");
            listaRoleta.Add("maca.png");
            listaRoleta.Add("maca.png");
            listaRoleta.Add("maca.png");
            listaRoleta.Add("maca.png");
            listaRoleta.Add("maca.png");
            listaRoleta.Add("maca.png");
            _soundPlayer = new SoundPlayer("sonicStarLight.wav");
            _soundPlayer.PlayLooping();
        }











        public void Resultados(string a, string b, string c)
        {
            
            if (a == "maca.png" && b == "maca.png" && c == "maca.png")
            {
                ExibirResultados(" Parabéns! Voce ganhou + R$1,00 ", "congratulations.wav");
                labelSaldo.Text = novojogador.GanhosPerdas(1);
                CorSaldo();

            }
            else if (a == "banana.png" && b == "banana.png" && c == "banana.png")
            {
                ExibirResultados(" Parabéns! Voce ganhou + R$3,00 ", "congratulations.wav");
                labelSaldo.Text = novojogador.GanhosPerdas(3);
                CorSaldo();

            }

            else if (a == "laranja.png" && b == "laranja.png" && c == "laranja.png")
            {
                ExibirResultados(" Parabéns! Voce ganhou + R$5,00 ", "congratulations.wav");
                labelSaldo.Text = novojogador.GanhosPerdas(5);
                CorSaldo();

            }
            else
            {
                ExibirResultados(" Você perdeu !  ", "lose.wav");
                CorSaldo();


            }
        }

        public void CorSaldo()
        {
            if (novojogador.Saldo >= 0)
            {
                labelSaldo.ForeColor = Color.White;

            }
            else
            {
                labelSaldo.ForeColor = Color.Red;
            }
        }

        private void BtnStart_Click_1(object sender, EventArgs e)
        {

            BtnStart.Visible = false;
            tempo = 0;
            labelSaldo.Text = novojogador.GanhosPerdas(-1);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo += timer1.Interval;
            if (tempo >= 4000)
            {
                timer1.Stop();

                Resultados(p1, p2, p3);
                BtnStart.Visible = true;
                return;


            }
            Random rnd = new Random();


            p1 = listaRoleta[rnd.Next(0, 10)];
            p2 = listaRoleta[rnd.Next(0, 10)];
            p3 = listaRoleta[rnd.Next(0, 10)];
            if (pictureBox1.Image != null) { pictureBox1.Image.Dispose(); }
            pictureBox1.Image = Image.FromFile(p1);
            if (pictureBox2.Image != null) { pictureBox2.Image.Dispose(); }
            pictureBox2.Image = Image.FromFile(p2);
            if (pictureBox3.Image != null) { pictureBox3.Image.Dispose(); }
            pictureBox3.Image = Image.FromFile(p3);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = Image.FromFile("estrela.png");
            novojogador = new Jogador();
            novojogador.Nome = this.Nomemain;
            label1.Text = this.Nomemain;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string conteudo = JsonConvert.SerializeObject(novojogador) + "\n";
            //string dados = novojogador.Nome + " ---> R$" + novojogador.Saldo.ToString("0.00");
            File.AppendAllText("dados.json", conteudo);

            this.Close();
        }

        private void ExibirResultados(string msg,string audio)
        {
          
            Results results = new Results();
            results.NovoSaldo = msg;
            
            _soundPlayerresult = new SoundPlayer(audio);
            _soundPlayerresult.Play();
            results.ShowDialog();
            _soundPlayer.PlayLooping();
            
           




        }
    }
}
