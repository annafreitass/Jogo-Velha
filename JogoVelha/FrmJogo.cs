using System.Security.Cryptography.X509Certificates;

namespace JogoVelha
{
    public partial class FrmJogo : Form
    {
        public FrmJogo()
        {
            InitializeComponent();
        }

        int vitoriasX = 0;
        int vitoriasO = 0;
        int empates = 0;

        Boolean Jogador = false;


        private void FrmJogo_Load(object sender, EventArgs e)
        {
            lblVitoriaX.Text = "0";
            lblVitoriaO.Text = "0";
            lblVitoriaEmpates.Text = "0";
        }

        public void PreencherCampo(Button botao)
        {
            if (string.IsNullOrEmpty(botao.Text))
            {
                VerificaJogador(botao);
            }
            else
            {
                return;
            }
        }

        public void VerificaJogador(Button botao)
        {
            if (Jogador == false)
            {
                botao.Text = "X";
                Jogador = true;
            }
            else if (Jogador == true)
            {
                botao.Text = "O";
                Jogador = false;
            }
        }

        public void VerificaVencedor()
        {
            VerificarSequencia(btnEspaco1, btnEspaco2, btnEspaco3);
            VerificarSequencia(btnEspaco4, btnEspaco5, btnEspaco6);
            VerificarSequencia(btnEspaco7, btnEspaco8, btnEspaco9);
            VerificarSequencia(btnEspaco1, btnEspaco4, btnEspaco7);
            VerificarSequencia(btnEspaco2, btnEspaco5, btnEspaco8);
            VerificarSequencia(btnEspaco3, btnEspaco6, btnEspaco9);
            VerificarSequencia(btnEspaco1, btnEspaco5, btnEspaco9);
            VerificarSequencia(btnEspaco3, btnEspaco5, btnEspaco7);

            VerificaEmpate(btnEspaco1, btnEspaco2, btnEspaco3, btnEspaco4, btnEspaco5, btnEspaco6, btnEspaco7, btnEspaco8, btnEspaco9);
        }

        public void VerificaEmpate(Button a, Button b, Button c, Button d, Button e, Button f, Button g, Button h, Button i)
        {
            if(a.Text != "" && b.Text != "" && c.Text != "" && d.Text != "" && e.Text != "" && f.Text != "" && g.Text != "" && h.Text != "" && i.Text != "") 
            {
                empates++;
                lblVitoriaEmpates.Text = empates.ToString();
                MessageBox.Show("Empate!!!");

                LimparCampos();
            }
        }

        public void VerificarSequencia(Button a, Button b, Button c)
        {
            if (a.Text != "" && a.Text == b.Text && b.Text == c.Text)
            {
                if (a.Text == "X")
                {
                    vitoriasX++;
                    lblVitoriaX.Text = vitoriasX.ToString();
                }
                else if (a.Text == "O")
                {
                    vitoriasO++;
                    lblVitoriaO.Text = vitoriasO.ToString();
                }

                MessageBox.Show($"VOCÊ VENCEU {a.Text}!");
                LimparCampos();
            }
        }

        private void btnEspaco1_MouseClick(object sender, MouseEventArgs e)
        {
            PreencherCampo(btnEspaco1);
            VerificaVencedor();
        }

        private void btnEspaco2_MouseClick(object sender, MouseEventArgs e)
        {
            PreencherCampo(btnEspaco2);
            VerificaVencedor();
        }

        private void btnEspaco3_MouseClick(object sender, MouseEventArgs e)
        {
            PreencherCampo(btnEspaco3);
            VerificaVencedor();
        }

        private void btnEspaco4_MouseClick(object sender, MouseEventArgs e)
        {
            PreencherCampo(btnEspaco4);
            VerificaVencedor();
        }

        private void btnEspaco5_MouseClick(object sender, MouseEventArgs e)
        {
            PreencherCampo(btnEspaco5);
            VerificaVencedor();
        }

        private void btnEspaco6_MouseClick(object sender, MouseEventArgs e)
        {
            PreencherCampo(btnEspaco6);
            VerificaVencedor();
        }

        private void btnEspaco7_MouseClick(object sender, MouseEventArgs e)
        {
            PreencherCampo(btnEspaco7);
            VerificaVencedor();
        }

        private void btnEspaco8_MouseClick(object sender, MouseEventArgs e)
        {
            PreencherCampo(btnEspaco8);
            VerificaVencedor();
        }

        private void btnEspaco9_MouseClick(object sender, MouseEventArgs e)
        {
            PreencherCampo(btnEspaco9);
            VerificaVencedor();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            btnEspaco1.Text = "";
            btnEspaco2.Text = "";
            btnEspaco3.Text = "";
            btnEspaco4.Text = "";
            btnEspaco5.Text = "";
            btnEspaco6.Text = "";
            btnEspaco7.Text = "";
            btnEspaco8.Text = "";
            btnEspaco9.Text = "";

            Jogador = false;
        }
    }
}
