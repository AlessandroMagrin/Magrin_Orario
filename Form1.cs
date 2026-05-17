using Orario;
using System;
using System.Windows.Forms;

namespace FormOrario
{
    public partial class Form1 : Form

    {
        private COrario _orarioA;
        private COrario _orarioB;
        private bool _lampeggio = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblDigitale_Click(object sender, EventArgs e)
        {

        }

        private void txtSecondiA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinutiA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOreA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImposta_Click(object sender, EventArgs e)
        {
            try
            {
                int h = int.Parse(txtOreA.Text);
                int m = int.Parse(txtMinutiA.Text);
                int s = int.Parse(txtSecondiA.Text);

                _orarioA = new COrario(h, m, s);
                timer1.Stop(); // Fermo il timer per non sovrascrivere il valore
                AggiornaDisplay();
            }
            catch (FormatException)
            {
                MessageBox.Show("Inserisci valori numerici validi nei campi dell'orario A.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _orarioA = new COrario(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            // Imposta la frequenza del timer a 1 secondo
            timer1.Interval = 1000;
            //il timer inizia
            timer1.Start();
            AggiornaDisplay();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //portiamo l'orario 
            _orarioA = new COrario(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            AggiornaDisplay();
        }


        private void AggiornaDisplay()
        {
            _lampeggio = !_lampeggio;
            string sep = _lampeggio ? ":" : " ";


            lblDigitale.Text = $"{_orarioA.ore:D2}{sep}{_orarioA.minuti:D2}{sep}{_orarioA.secondi:D2}";
        }

        private void LeggiOrarioB()
        {
            // Metodo di supporto per non ripetere il try/catch in ogni pulsante
            int h = int.Parse(txtOreB.Text);
            int m = int.Parse(txtMinutiB.Text);
            int s = int.Parse(txtSecondiB.Text);
            _orarioB = new COrario(h, m, s);
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            try
            {
                LeggiOrarioB();

                lblRisultato.Text = $"A + B = {(_orarioA + _orarioB).ToString()}";
            }
            catch (FormatException)
            {
                lblRisultato.Text = "Errore: inserisci valori numerici in B.";
            }
        }

        private void btnDifferenza_Click(object sender, EventArgs e)
        {
            try
            {
                LeggiOrarioB();

                lblRisultato.Text = $"A - B = {(_orarioA - _orarioB).ToString()}";
            }
            catch (FormatException)
            {
                lblRisultato.Text = "Errore: inserisci valori numerici in B.";
            }
            catch (ArgumentException ex)
            {

                lblRisultato.Text = $"Errore: {ex.Message}";
            }
        }

        private void btnMoltiplica_Click(object sender, EventArgs e)
        {
            try
            {
                int fattore = int.Parse(txtMoltiplica.Text);

                lblRisultato.Text = $"A * {fattore} = {(_orarioA * fattore).ToString()}";
            }
            catch (FormatException)
            {
                lblRisultato.Text = "Errore: inserisci un fattore numerico.";
            }
        }

        private void btnMaggiore_Click(object sender, EventArgs e)
        {
            try
            {
                LeggiOrarioB();


                if (_orarioA > _orarioB)
                {
                    lblRisultato.Text = "L'orario A è maggiore dell'orario B";
                }
                else if (_orarioA == _orarioB)
                {
                    lblRisultato.Text = "Gli orari A e B sono uguali";
                }
                else
                {
                    lblRisultato.Text = "L'orario B è maggiore dell'orario A";
                }
            }
            catch (FormatException)
            {
                lblRisultato.Text = "Errore: inserisci valori numerici in B.";
            }
        }

        private void txtMinutiB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRisultato_Click(object sender, EventArgs e)
        {

        }
    }
}


