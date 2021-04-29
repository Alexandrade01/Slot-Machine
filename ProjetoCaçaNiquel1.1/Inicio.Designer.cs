
namespace ProjetoCaçaNiquel1._1
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnRanking = new System.Windows.Forms.Button();
            this.BtnEquacoes = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(31, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome : ";
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textNome.Location = new System.Drawing.Point(189, 308);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(257, 23);
            this.textNome.TabIndex = 1;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnIniciar.Location = new System.Drawing.Point(31, 264);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(415, 27);
            this.BtnIniciar.TabIndex = 2;
            this.BtnIniciar.Text = "S T A R T !";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnRanking
            // 
            this.BtnRanking.BackColor = System.Drawing.Color.Transparent;
            this.BtnRanking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRanking.Location = new System.Drawing.Point(12, 22);
            this.BtnRanking.Name = "BtnRanking";
            this.BtnRanking.Size = new System.Drawing.Size(127, 29);
            this.BtnRanking.TabIndex = 3;
            this.BtnRanking.Text = "Ranking ";
            this.BtnRanking.UseVisualStyleBackColor = false;
            this.BtnRanking.Click += new System.EventHandler(this.BtnRanking_Click);
            // 
            // BtnEquacoes
            // 
            this.BtnEquacoes.BackColor = System.Drawing.Color.Transparent;
            this.BtnEquacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnEquacoes.Location = new System.Drawing.Point(345, 22);
            this.BtnEquacoes.Name = "BtnEquacoes";
            this.BtnEquacoes.Size = new System.Drawing.Size(127, 46);
            this.BtnEquacoes.TabIndex = 4;
            this.BtnEquacoes.Text = "Equações Esperança";
            this.BtnEquacoes.UseVisualStyleBackColor = false;
            this.BtnEquacoes.Click += new System.EventHandler(this.BtnEquacoes_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLogo
            // 
            this.txtLogo.AutoSize = true;
            this.txtLogo.BackColor = System.Drawing.Color.Transparent;
            this.txtLogo.Font = new System.Drawing.Font("Mistral", 62.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtLogo.ForeColor = System.Drawing.Color.White;
            this.txtLogo.Location = new System.Drawing.Point(8, 116);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(464, 99);
            this.txtLogo.TabIndex = 6;
            this.txtLogo.Text = "Caça-Níquel-FTT";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCaçaNiquel1._1.Properties.Resources.Sky1;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.BtnEquacoes);
            this.Controls.Add(this.BtnRanking);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.Text = "Caça Níquel 1.1v";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnRanking;
        private System.Windows.Forms.Button BtnEquacoes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label txtLogo;
        private System.Windows.Forms.Timer timer1;
    }
}

