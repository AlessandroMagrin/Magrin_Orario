namespace FormOrario
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lblDigitale = new Label();
            txtOreA = new TextBox();
            txtMinutiA = new TextBox();
            txtSecondiA = new TextBox();
            btnImposta = new Button();
            btnOraCorrente = new Button();
            btnAzzeraOra = new Button();
            txtOreB = new TextBox();
            txtMoltiplica = new TextBox();
            txtSecondiB = new TextBox();
            btnSomma = new Button();
            btnDifferenza = new Button();
            btnMaggiore = new Button();
            txtMinutiB = new TextBox();
            btnMoltiplica = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblRisultato = new Label();
            SuspendLayout();
            // 
            // lblDigitale
            // 
            lblDigitale.Location = new Point(408, 23);
            lblDigitale.Name = "lblDigitale";
            lblDigitale.Size = new Size(238, 77);
            lblDigitale.TabIndex = 0;
            lblDigitale.Text = "lblDigitale";
            lblDigitale.Click += lblDigitale_Click;
            // 
            // txtOreA
            // 
            txtOreA.Location = new Point(77, 171);
            txtOreA.Margin = new Padding(3, 4, 3, 4);
            txtOreA.Name = "txtOreA";
            txtOreA.Size = new Size(114, 27);
            txtOreA.TabIndex = 1;
            txtOreA.TextChanged += txtOreA_TextChanged;
            // 
            // txtMinutiA
            // 
            txtMinutiA.Location = new Point(408, 171);
            txtMinutiA.Margin = new Padding(3, 4, 3, 4);
            txtMinutiA.Name = "txtMinutiA";
            txtMinutiA.Size = new Size(114, 27);
            txtMinutiA.TabIndex = 2;
            txtMinutiA.TextChanged += txtMinutiA_TextChanged;
            // 
            // txtSecondiA
            // 
            txtSecondiA.Location = new Point(714, 171);
            txtSecondiA.Margin = new Padding(3, 4, 3, 4);
            txtSecondiA.Name = "txtSecondiA";
            txtSecondiA.Size = new Size(114, 27);
            txtSecondiA.TabIndex = 3;
            txtSecondiA.TextChanged += txtSecondiA_TextChanged;
            // 
            // btnImposta
            // 
            btnImposta.Location = new Point(89, 248);
            btnImposta.Margin = new Padding(3, 4, 3, 4);
            btnImposta.Name = "btnImposta";
            btnImposta.Size = new Size(86, 31);
            btnImposta.TabIndex = 4;
            btnImposta.Text = "Imposta";
            btnImposta.UseVisualStyleBackColor = true;
            btnImposta.Click += btnImposta_Click;
            // 
            // btnOraCorrente
            // 
            btnOraCorrente.Location = new Point(421, 248);
            btnOraCorrente.Margin = new Padding(3, 4, 3, 4);
            btnOraCorrente.Name = "btnOraCorrente";
            btnOraCorrente.Size = new Size(86, 31);
            btnOraCorrente.TabIndex = 5;
            btnOraCorrente.Text = "Ora Corrente";
            btnOraCorrente.UseVisualStyleBackColor = true;
            // 
            // btnAzzeraOra
            // 
            btnAzzeraOra.Location = new Point(727, 248);
            btnAzzeraOra.Margin = new Padding(3, 4, 3, 4);
            btnAzzeraOra.Name = "btnAzzeraOra";
            btnAzzeraOra.Size = new Size(86, 31);
            btnAzzeraOra.TabIndex = 6;
            btnAzzeraOra.Text = "Azzera";
            btnAzzeraOra.UseVisualStyleBackColor = true;
            // 
            // txtOreB
            // 
            txtOreB.Location = new Point(77, 329);
            txtOreB.Margin = new Padding(3, 4, 3, 4);
            txtOreB.Name = "txtOreB";
            txtOreB.Size = new Size(114, 27);
            txtOreB.TabIndex = 7;
            // 
            // txtMoltiplica
            // 
            txtMoltiplica.Location = new Point(487, 417);
            txtMoltiplica.Margin = new Padding(3, 4, 3, 4);
            txtMoltiplica.Name = "txtMoltiplica";
            txtMoltiplica.Size = new Size(114, 27);
            txtMoltiplica.TabIndex = 8;
            // 
            // txtSecondiB
            // 
            txtSecondiB.Location = new Point(714, 329);
            txtSecondiB.Margin = new Padding(3, 4, 3, 4);
            txtSecondiB.Name = "txtSecondiB";
            txtSecondiB.Size = new Size(114, 27);
            txtSecondiB.TabIndex = 9;
            // 
            // btnSomma
            // 
            btnSomma.Location = new Point(89, 416);
            btnSomma.Margin = new Padding(3, 4, 3, 4);
            btnSomma.Name = "btnSomma";
            btnSomma.Size = new Size(86, 31);
            btnSomma.TabIndex = 10;
            btnSomma.Text = "A+B";
            btnSomma.UseVisualStyleBackColor = true;
            btnSomma.Click += btnSomma_Click;
            // 
            // btnDifferenza
            // 
            btnDifferenza.Location = new Point(235, 416);
            btnDifferenza.Margin = new Padding(3, 4, 3, 4);
            btnDifferenza.Name = "btnDifferenza";
            btnDifferenza.Size = new Size(86, 31);
            btnDifferenza.TabIndex = 11;
            btnDifferenza.Text = "A-B";
            btnDifferenza.UseVisualStyleBackColor = true;
            btnDifferenza.Click += btnDifferenza_Click;
            // 
            // btnMaggiore
            // 
            btnMaggiore.Location = new Point(371, 416);
            btnMaggiore.Margin = new Padding(3, 4, 3, 4);
            btnMaggiore.Name = "btnMaggiore";
            btnMaggiore.Size = new Size(86, 31);
            btnMaggiore.TabIndex = 12;
            btnMaggiore.Text = "Maggiore?";
            btnMaggiore.UseVisualStyleBackColor = true;
            // 
            // txtMinutiB
            // 
            txtMinutiB.Location = new Point(408, 329);
            txtMinutiB.Margin = new Padding(3, 4, 3, 4);
            txtMinutiB.Name = "txtMinutiB";
            txtMinutiB.Size = new Size(114, 27);
            txtMinutiB.TabIndex = 13;
            txtMinutiB.TextChanged += txtMinutiB_TextChanged;
            // 
            // btnMoltiplica
            // 
            btnMoltiplica.Location = new Point(667, 417);
            btnMoltiplica.Margin = new Padding(3, 4, 3, 4);
            btnMoltiplica.Name = "btnMoltiplica";
            btnMoltiplica.Size = new Size(86, 31);
            btnMoltiplica.TabIndex = 14;
            btnMoltiplica.Text = "Moltiplica";
            btnMoltiplica.UseVisualStyleBackColor = true;
            btnMoltiplica.Click += btnMoltiplica_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblRisultato
            // 
            lblRisultato.Location = new Point(77, 481);
            lblRisultato.Name = "lblRisultato";
            lblRisultato.Size = new Size(751, 96);
            lblRisultato.TabIndex = 15;
            lblRisultato.Text = "label1";
            lblRisultato.Click += lblRisultato_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblRisultato);
            Controls.Add(btnMoltiplica);
            Controls.Add(txtMinutiB);
            Controls.Add(btnMaggiore);
            Controls.Add(btnDifferenza);
            Controls.Add(btnSomma);
            Controls.Add(txtSecondiB);
            Controls.Add(txtMoltiplica);
            Controls.Add(txtOreB);
            Controls.Add(btnAzzeraOra);
            Controls.Add(btnOraCorrente);
            Controls.Add(btnImposta);
            Controls.Add(txtSecondiA);
            Controls.Add(txtMinutiA);
            Controls.Add(txtOreA);
            Controls.Add(lblDigitale);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDigitale;
        private TextBox txtOreA;
        private TextBox txtMinutiA;
        private TextBox txtSecondiA;
        private Button btnImposta;
        private Button btnOraCorrente;
        private Button btnAzzeraOra;
        private TextBox txtOreB;
        private TextBox txtMoltiplica;
        private TextBox txtSecondiB;
        private Button btnSomma;
        private Button btnDifferenza;
        private Button btnMaggiore;
        private TextBox txtMinutiB;
        private Button btnMoltiplica;
        private System.Windows.Forms.Timer timer1;
        private Label lblRisultato;
    }
}
