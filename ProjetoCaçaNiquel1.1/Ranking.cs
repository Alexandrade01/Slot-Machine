using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ProjetoCaçaNiquel1._1
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ranqueamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ranking_Load(object sender, EventArgs e)
        {//se o arquivo json existe ira ser carregado dentro de um array e inserido no campo do textbox
            if (File.Exists("dados.json"))
            {
                string[] dados = File.ReadAllLines("dados.json");
                foreach (var dado in dados)
                {
                    textBox1.Text += dado + Environment.NewLine;
                }
            }
        }
    }
}
