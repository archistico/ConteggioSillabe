using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConteggioSillabe
{
    public partial class frmPrincipale : Form
    {
        public frmPrincipale()
        {
            InitializeComponent();
        }

        private List<char> Vocali = new List<char>();
        private List<char> Consonanti = new List<char>();
        private List<char> LetterePermesse = new List<char>();

        private string Calcola(string input)
        {
            // caratteri di punteggiatura
            char[] interruzioni = { ' ', ',', '.', '\'', '\"', ';', ':', '-', '+', '/', '*', '!', '(', ')', '=', '?', '[', ']', '{', '}', '“', '”', '’', '»', '«', '%', '€' };

            // Dividi il testo in parole
            List<string> parole = input.ToLower().Split(interruzioni).ToList<string>();

            // Elimina eventuali parole vuote
            parole = parole.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            // Elimina parole con numeri o simboli
            parole = parole.Where(s => s.Any(char.IsLetter)).ToList();

            for (int i = 0; i < parole.Count; i++)
            {
                parole[i] = parole[i].PadRight(30) + Struttura(parole[i]);
            }

            // Unisci il tutto in una stringa e restituisci il risultato
            string output = string.Join(Environment.NewLine, parole);
            return output;
        }

        private string Struttura(string input)
        {
            StringBuilder parola = new StringBuilder(input);

            for (int c = 0; c < parola.Length; c++)
            {
                if (parola[c].ToString().Any(x => Vocali.Contains(x)))
                {
                    parola[c] = 'V';
                }
                else
                {
                    parola[c] = 'C';
                }
            }

            return parola.ToString();
        }

        private void btCalcola_Click(object sender, EventArgs e)
        {
            string input = "";
            string output = "";

            GeneraleCaricaLettere();

            input = tbInput.Text;
            output = Calcola(input);
            tbOutput.Text = output;
        }

        private void GeneraleCaricaLettere()
        {
            Vocali.Add('a');
            Vocali.Add('e');
            Vocali.Add('i');
            Vocali.Add('o');
            Vocali.Add('u');

            Vocali.Add('à');
            Vocali.Add('é');
            Vocali.Add('è');
            Vocali.Add('ì');
            Vocali.Add('ò');
            Vocali.Add('ù');

            Consonanti.Add('q');
            Consonanti.Add('w');
            Consonanti.Add('r');
            Consonanti.Add('t');
            Consonanti.Add('y');
            Consonanti.Add('p');
            Consonanti.Add('s');
            Consonanti.Add('d');
            Consonanti.Add('f');
            Consonanti.Add('g');
            Consonanti.Add('h');
            Consonanti.Add('j');
            Consonanti.Add('k');
            Consonanti.Add('l');
            Consonanti.Add('z');
            Consonanti.Add('x');
            Consonanti.Add('c');
            Consonanti.Add('v');
            Consonanti.Add('b');
            Consonanti.Add('n');
            Consonanti.Add('m');

            LetterePermesse.Add('a');
            LetterePermesse.Add('e');
            LetterePermesse.Add('i');
            LetterePermesse.Add('o');
            LetterePermesse.Add('u');
            LetterePermesse.Add('à');
            LetterePermesse.Add('é');
            LetterePermesse.Add('è');
            LetterePermesse.Add('ì');
            LetterePermesse.Add('ò');
            LetterePermesse.Add('ù');
            LetterePermesse.Add('q');
            LetterePermesse.Add('w');
            LetterePermesse.Add('r');
            LetterePermesse.Add('t');
            LetterePermesse.Add('y');
            LetterePermesse.Add('p');
            LetterePermesse.Add('s');
            LetterePermesse.Add('d');
            LetterePermesse.Add('f');
            LetterePermesse.Add('g');
            LetterePermesse.Add('h');
            LetterePermesse.Add('j');
            LetterePermesse.Add('k');
            LetterePermesse.Add('l');
            LetterePermesse.Add('z');
            LetterePermesse.Add('x');
            LetterePermesse.Add('c');
            LetterePermesse.Add('v');
            LetterePermesse.Add('b');
            LetterePermesse.Add('n');
            LetterePermesse.Add('m');
        }



    }
}


