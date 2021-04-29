using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProjetoCaçaNiquel1._1
{
    public partial class Inicio : Form
    {
        private SoundPlayer _soundPlayer;
        public Inicio()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("sonicStarLight.wav");

        }



        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Main main = new Main();


            if (string.IsNullOrEmpty(textNome.Text))
            {

                errorProvider1.SetError(textNome, "Nome Invalido!");
                return;
            }
            errorProvider1.Clear();
            main.Nomemain = textNome.Text;
            this.Visible = false;
            main.ShowDialog();
            this.Visible = true;



        }

        private void BtnRanking_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Ranking ranking = new Ranking();
            ranking.ShowDialog();
            this.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);

          
            txtLogo.ForeColor = Color.FromArgb(r, g, b);
        }

        private void BtnEquacoes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Equacoes equacoes = new Equacoes();
            equacoes.ShowDialog();
            this.Visible = true;

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            _soundPlayer.PlayLooping();
        }
    }
}
