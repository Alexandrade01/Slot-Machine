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
            // Listagem de discos da roleta (1 laranja -- 3 bananas -- 6 maças)
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
           
        }
        private void Main_Load(object sender, EventArgs e)
        {// A imagem inicial sendo uma estrela
            pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = Image.FromFile("estrela.png");
            //criacao de um novo objeto
            novojogador = new Jogador();
            novojogador.Nome = this.Nomemain;
            label1.Text = this.Nomemain;
        }
        private void BtnStart_Click_1(object sender, EventArgs e)
        {
            _soundPlayer.Stop();
            // start fazendo acionar o timer start
            btnSair.Visible = BtnStart.Visible = false;
            tempo = 0;
            labelSaldo.Text = novojogador.GanhosPerdas(-1);

            timer1.Start();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            string conteudo = novojogador.ToString();
            File.AppendAllText("arq.txt", conteudo+Environment.NewLine);
            this.Close();
        }
        /// <summary>
        /// Verificador dos resultados gerador pela roleta
        /// </summary>
        /// <param name="a">primeira roleta</param>
        /// <param name="b">segunda roleta</param>
        /// <param name="c">terceira roleta</param>
        public void Resultados(string a, string b, string c)
        {
            // Dependendo do endereço ira abrir uma nova janela e atualizar o saldo do jogador
            if (a == "maca.png" && b == "maca.png" && c == "maca.png")
            {
                ExibirResultados(" Parabéns! Voce ganhou + R$1,00 ", "congratulations.wav");
                labelSaldo.Text = novojogador.GanhosPerdas(1);
                

            }
            else if (a == "banana.png" && b == "banana.png" && c == "banana.png")
            {
                ExibirResultados(" Parabéns! Voce ganhou + R$3,00 ", "congratulations.wav");
                labelSaldo.Text = novojogador.GanhosPerdas(3);
               

            }

            else if (a == "laranja.png" && b == "laranja.png" && c == "laranja.png")
            {
                ExibirResultados(" Parabéns! Voce ganhou + R$5,00 ", "congratulations.wav");
                labelSaldo.Text = novojogador.GanhosPerdas(5);
               

            }
            else
            {
                ExibirResultados(" Você perdeu !  ", "lose.wav");
                


            }
        }
        /// <summary>
        /// Temporizador que controlara o giro dos discos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo += timer1.Interval;
            if (tempo >= 4000)
            {
                timer1.Stop();

                Resultados(p1, p2, p3);
                btnSair.Visible = BtnStart.Visible = true;
                return;


            }
            Random rnd = new Random();

            // geradores de indices aleatórios com base na lista de roletas
            p1 = listaRoleta[rnd.Next(0, 10)];
            p2 = listaRoleta[rnd.Next(0, 10)];
            p3 = listaRoleta[rnd.Next(0, 10)];
            // se a imagem for diferente de null o metrodo dispose da classe image ira apagar o registro na memoria melhorando o desempenho
            if (pictureBox1.Image != null) { pictureBox1.Image.Dispose(); }
            // Em seguida um novo endereço ira ser conectado ao picturebox 
            pictureBox1.Image = Image.FromFile(p1);
            if (pictureBox2.Image != null) { pictureBox2.Image.Dispose(); }
            pictureBox2.Image = Image.FromFile(p2);
            if (pictureBox3.Image != null) { pictureBox3.Image.Dispose(); }
            pictureBox3.Image = Image.FromFile(p3);
        }
        
        /// <summary>
        ///Exibição de resultados de acordo com os parametros
        /// </summary>
        /// <param name="msg">a mensagem que ira ser exibido no label da janela resultado </param>
        /// <param name="audio">definicao de endereço de qual audio sera executado </param>
        private void ExibirResultados(string msg, string audio)
        {
            CorSaldo();
            Results results = new Results();
            results.NovoSaldo = msg;

            _soundPlayerresult = new SoundPlayer(audio);
            _soundPlayerresult.Play();
            results.ShowDialog();
            
        }
        /// <summary>
        /// Condição para indicar se o saldo é positivo ou negativo usando as cores branca e vermelho
        /// </summary>
        public void CorSaldo()
        {
            if (novojogador.Saldo >= 0)
            {
                labelSaldo.ForeColor = Color.White;

            }
            else if(novojogador.Saldo<0)
            {
                labelSaldo.ForeColor = Color.Red;
            }
        }
    }
}




























