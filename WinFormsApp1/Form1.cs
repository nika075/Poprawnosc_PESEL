using System.Globalization;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int cyfraKontrolna = 0;
      
        int[] wspolczynniki = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        public Form1()
        {
            InitializeComponent();
        }

        private void bGenerujCyfreKontrolna_Click(object sender, EventArgs e)
        {
            int S = 0;
            int M = 0;
            char[] sCyfry = tbCyfry.Text.ToCharArray();
            Regex regex = new Regex("^[0-9]+$");

            if (regex.IsMatch(tbCyfry.Text))
            {
                for (int k = 0; k < sCyfry.Length; k++)
                {
                    S += int.Parse(sCyfry[k].ToString()) * wspolczynniki[k];
                }

                M = S % 10;

                if (M == 0)
                {
                    cyfraKontrolna = 0;
                }
                else
                {
                    cyfraKontrolna = 10 - M;
                }

                tbPesel.Text = tbCyfry.Text + cyfraKontrolna;
            }
            else {
                MessageBox.Show("Podaj cyfry");
            }

        }

        private void bSprawdzPesel_Click(object sender, EventArgs e)
        {
            char[] sCyfry = tbCyfry.Text.ToCharArray();
            int S = 0;
            for (int k = 0; k < sCyfry.Length; k++)
            {
                S += int.Parse(sCyfry[k].ToString()) * wspolczynniki[k];
            }
            S += cyfraKontrolna * 1;
 
            if (S % 10 == 0 && sCyfry.Length == 10) {
                lPeselPoprawnosc.Text = "Pesel poprawny.";
            }
            else
            {
                lPeselPoprawnosc.Text = "Pesel nie poprawny.";
            }

            String poprawnoscCyfryPlci = " Cyfra p³ci nie poprawna.";

            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (((RadioButton)groupBox1.Controls[i]).Checked && tbCyfry.Text.Length == 10)
                {
                     if (((RadioButton)groupBox1.Controls[i]).Text.Equals("¿eñska") && sCyfry[sCyfry.Length-1] % 2 == 0 ){
                        poprawnoscCyfryPlci = " Cyfra p³ci poprawna.";   
                     }
                    if (((RadioButton)groupBox1.Controls[i]).Text.Equals("mêska") && sCyfry[sCyfry.Length - 1] % 2 != 0)
                    {
                        poprawnoscCyfryPlci = " Cyfra p³ci poprawna.";
                    }
                }
                   
            }
            lPeselPoprawnosc.Text += poprawnoscCyfryPlci;
        }
    }
}