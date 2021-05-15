using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere_algoritmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Empty;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string raktas = keyTextBox.Text;
                string tekstas = textBox.Text;

                if (string.IsNullOrEmpty(raktas) || string.IsNullOrEmpty(tekstas))
                    throw new Exception("Turite parašytį raktą arba šifruojamą tekstą!");

                if (!encryptRadioButton.Checked && !decryptRadioButton.Checked)
                    throw new Exception("Turite pasirinkite - šifruoti arba dešifruoti!");

                if (raktas.Length > tekstas.Length)
                    throw new Exception("Raktas negali būti didesnis už tekstą!");

                if (encryptRadioButton.Checked) 
                    resultTextBox.Text = SifruotiTeksta(SugeneruotiRakta(raktas, tekstas), tekstas);

                if (decryptRadioButton.Checked)
                    resultTextBox.Text = DesifruotiTeksta(SugeneruotiRakta(raktas, tekstas), tekstas);
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        static String SugeneruotiRakta (string raktas, string tekstas)
        {
            for (int i = 0; ; i++)
            {
                if (raktas.Length == tekstas.Length)
                    break;

                raktas += (raktas[i]);
            }
            return raktas;
        }

        static List<int> SudarytiTekstoDecIntLista(string tekstas)
        {
            List<int> skaiciai = new List<int>();
            foreach (char c in tekstas)
                skaiciai.Add(c);

            return skaiciai;
        }
        static List<int> SudarytiRaktoDecIntLista(string raktas)
        {
            List<int> skaiciai = new List<int>();
            foreach (char c in raktas)
                skaiciai.Add(c);

            return skaiciai;
        }

        static String SifruotiTeksta(String raktas, String tekstas)
        {
            String uzsifruotasTekstas = "";

            List<int> raktoSkaiciai = SudarytiRaktoDecIntLista(raktas);
            List<int> tekstoSkaiciai = SudarytiTekstoDecIntLista(tekstas);


            for (int i = 0; i < tekstas.Length; i++)
            {
                int x = (tekstoSkaiciai[i] + raktoSkaiciai[i]) % 128;

                uzsifruotasTekstas += (char)(x);
            }
            return uzsifruotasTekstas;
        }
        static String DesifruotiTeksta(String raktas, String tekstas)
        {
            String desifruotasTekstas = "";

            List<int> raktoSkaiciai = SudarytiRaktoDecIntLista(raktas);
            List<int> tekstoSkaiciai = SudarytiTekstoDecIntLista(tekstas);

            for (int i = 0; i < tekstas.Length; i++)
            {
                int x = (tekstoSkaiciai[i] - raktoSkaiciai[i] + 128) % 128;

                desifruotasTekstas += (char)(x);
            }
            return desifruotasTekstas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            keyTextBox.Clear();
            textBox.Clear();
            decryptRadioButton.Checked = false;
            encryptRadioButton.Checked = false;
        }
    }
}
