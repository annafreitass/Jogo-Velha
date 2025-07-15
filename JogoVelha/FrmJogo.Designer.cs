namespace JogoVelha
{
    partial class FrmJogo
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
            btnEspaco1 = new Button();
            lblJogadorX = new Label();
            lblJogadorO = new Label();
            grpPlacar = new GroupBox();
            lblVitoriaEmpates = new Label();
            lblEmpates = new Label();
            lblVitoriaO = new Label();
            lblVitoriaX = new Label();
            btnEspaco2 = new Button();
            btnEspaco3 = new Button();
            btnEspaco6 = new Button();
            btnEspaco5 = new Button();
            btnEspaco4 = new Button();
            btnEspaco9 = new Button();
            btnEspaco8 = new Button();
            btnEspaco7 = new Button();
            btnLimpar = new Button();
            grpPlacar.SuspendLayout();
            SuspendLayout();
            // 
            // btnEspaco1
            // 
            btnEspaco1.Font = new Font("Arial", 36F);
            btnEspaco1.Location = new Point(232, 19);
            btnEspaco1.Name = "btnEspaco1";
            btnEspaco1.Size = new Size(77, 68);
            btnEspaco1.TabIndex = 0;
            btnEspaco1.UseVisualStyleBackColor = true;
            btnEspaco1.MouseClick += btnEspaco1_MouseClick;
            // 
            // lblJogadorX
            // 
            lblJogadorX.AutoSize = true;
            lblJogadorX.Location = new Point(6, 28);
            lblJogadorX.Name = "lblJogadorX";
            lblJogadorX.Size = new Size(62, 15);
            lblJogadorX.TabIndex = 0;
            lblJogadorX.Text = "Jogador X:";
            // 
            // lblJogadorO
            // 
            lblJogadorO.AutoSize = true;
            lblJogadorO.Location = new Point(6, 60);
            lblJogadorO.Name = "lblJogadorO";
            lblJogadorO.Size = new Size(64, 15);
            lblJogadorO.TabIndex = 1;
            lblJogadorO.Text = "Jogador O:";
            // 
            // grpPlacar
            // 
            grpPlacar.BackColor = Color.White;
            grpPlacar.Controls.Add(lblVitoriaEmpates);
            grpPlacar.Controls.Add(lblEmpates);
            grpPlacar.Controls.Add(lblVitoriaO);
            grpPlacar.Controls.Add(lblVitoriaX);
            grpPlacar.Controls.Add(lblJogadorO);
            grpPlacar.Controls.Add(lblJogadorX);
            grpPlacar.Location = new Point(12, 19);
            grpPlacar.Name = "grpPlacar";
            grpPlacar.Size = new Size(200, 115);
            grpPlacar.TabIndex = 3;
            grpPlacar.TabStop = false;
            grpPlacar.Text = "PLACAR";
            // 
            // lblVitoriaEmpates
            // 
            lblVitoriaEmpates.Location = new Point(73, 92);
            lblVitoriaEmpates.Name = "lblVitoriaEmpates";
            lblVitoriaEmpates.Size = new Size(60, 15);
            lblVitoriaEmpates.TabIndex = 7;
            lblVitoriaEmpates.Text = "{{pontos}}";
            // 
            // lblEmpates
            // 
            lblEmpates.AutoSize = true;
            lblEmpates.Location = new Point(6, 91);
            lblEmpates.Name = "lblEmpates";
            lblEmpates.Size = new Size(55, 15);
            lblEmpates.TabIndex = 6;
            lblEmpates.Text = "Empates:";
            // 
            // lblVitoriaO
            // 
            lblVitoriaO.Location = new Point(73, 60);
            lblVitoriaO.Name = "lblVitoriaO";
            lblVitoriaO.Size = new Size(60, 15);
            lblVitoriaO.TabIndex = 5;
            lblVitoriaO.Text = "{{pontos}}";
            // 
            // lblVitoriaX
            // 
            lblVitoriaX.Location = new Point(73, 28);
            lblVitoriaX.Name = "lblVitoriaX";
            lblVitoriaX.Size = new Size(60, 15);
            lblVitoriaX.TabIndex = 4;
            lblVitoriaX.Text = "{{pontos}}";
            // 
            // btnEspaco2
            // 
            btnEspaco2.Font = new Font("Arial", 36F);
            btnEspaco2.Location = new Point(315, 19);
            btnEspaco2.Name = "btnEspaco2";
            btnEspaco2.Size = new Size(77, 68);
            btnEspaco2.TabIndex = 4;
            btnEspaco2.UseVisualStyleBackColor = true;
            btnEspaco2.MouseClick += btnEspaco2_MouseClick;
            // 
            // btnEspaco3
            // 
            btnEspaco3.Font = new Font("Arial", 36F);
            btnEspaco3.Location = new Point(399, 19);
            btnEspaco3.Name = "btnEspaco3";
            btnEspaco3.Size = new Size(77, 68);
            btnEspaco3.TabIndex = 5;
            btnEspaco3.UseVisualStyleBackColor = true;
            btnEspaco3.MouseClick += btnEspaco3_MouseClick;
            // 
            // btnEspaco6
            // 
            btnEspaco6.Font = new Font("Arial", 36F);
            btnEspaco6.Location = new Point(399, 93);
            btnEspaco6.Name = "btnEspaco6";
            btnEspaco6.Size = new Size(77, 68);
            btnEspaco6.TabIndex = 8;
            btnEspaco6.UseVisualStyleBackColor = true;
            btnEspaco6.MouseClick += btnEspaco6_MouseClick;
            // 
            // btnEspaco5
            // 
            btnEspaco5.Font = new Font("Arial", 36F);
            btnEspaco5.Location = new Point(315, 93);
            btnEspaco5.Name = "btnEspaco5";
            btnEspaco5.Size = new Size(77, 68);
            btnEspaco5.TabIndex = 7;
            btnEspaco5.UseVisualStyleBackColor = true;
            btnEspaco5.MouseClick += btnEspaco5_MouseClick;
            // 
            // btnEspaco4
            // 
            btnEspaco4.Font = new Font("Arial", 36F);
            btnEspaco4.Location = new Point(232, 93);
            btnEspaco4.Name = "btnEspaco4";
            btnEspaco4.Size = new Size(77, 68);
            btnEspaco4.TabIndex = 6;
            btnEspaco4.UseVisualStyleBackColor = true;
            btnEspaco4.MouseClick += btnEspaco4_MouseClick;
            // 
            // btnEspaco9
            // 
            btnEspaco9.Font = new Font("Arial", 36F);
            btnEspaco9.Location = new Point(399, 167);
            btnEspaco9.Name = "btnEspaco9";
            btnEspaco9.Size = new Size(77, 68);
            btnEspaco9.TabIndex = 11;
            btnEspaco9.UseVisualStyleBackColor = true;
            btnEspaco9.MouseClick += btnEspaco9_MouseClick;
            // 
            // btnEspaco8
            // 
            btnEspaco8.Font = new Font("Arial", 36F);
            btnEspaco8.Location = new Point(315, 167);
            btnEspaco8.Name = "btnEspaco8";
            btnEspaco8.Size = new Size(77, 68);
            btnEspaco8.TabIndex = 10;
            btnEspaco8.UseVisualStyleBackColor = true;
            btnEspaco8.MouseClick += btnEspaco8_MouseClick;
            // 
            // btnEspaco7
            // 
            btnEspaco7.Font = new Font("Arial", 36F);
            btnEspaco7.Location = new Point(232, 167);
            btnEspaco7.Name = "btnEspaco7";
            btnEspaco7.Size = new Size(77, 68);
            btnEspaco7.TabIndex = 9;
            btnEspaco7.UseVisualStyleBackColor = true;
            btnEspaco7.MouseClick += btnEspaco7_MouseClick;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Location = new Point(12, 204);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(87, 31);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FrmJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 251);
            Controls.Add(btnLimpar);
            Controls.Add(btnEspaco9);
            Controls.Add(btnEspaco8);
            Controls.Add(btnEspaco7);
            Controls.Add(btnEspaco6);
            Controls.Add(btnEspaco5);
            Controls.Add(btnEspaco4);
            Controls.Add(btnEspaco3);
            Controls.Add(btnEspaco2);
            Controls.Add(grpPlacar);
            Controls.Add(btnEspaco1);
            Name = "FrmJogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo da Velha";
            Load += FrmJogo_Load;
            grpPlacar.ResumeLayout(false);
            grpPlacar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEspaco1;
        private Label lblJogadorX;
        private Label lblJogadorO;
        private Label lblEmpates;
        private GroupBox grpPlacar;
        private Label lblVitoriaX;
        private Button btnEspaco2;
        private Button btnEspaco3;
        private Button btnEspaco6;
        private Button btnEspaco5;
        private Button btnEspaco4;
        private Button btnEspaco9;
        private Button btnEspaco8;
        private Button btnEspaco7;
        private Button btnLimpar;
        private Label lblVitoriaEmpates;
        private Label lblVitoriaO;
    }
}
