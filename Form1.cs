using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string PossibleCharacters = "qwertyuiopasdfghjklzxcvbnm";
        string defaultArray = "qwertyuiopasdfghjklzxcvbnm";
        string CapitalsArray = "QWERTYUIOPASDFGHJKLZXCVBNM";
        string NumbersArray = "1234567890";
        string SimilarsArray = "l1O0o|";
        string SymbolsArray = "!@#$%^&*()<>?/|`~-=_+";

        public Form1()
        {
            InitializeComponent();

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            string password = "";
            int length = 8;
            try
            {
                length = Convert.ToInt16(this.Length.Text);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.StackTrace);
            }
            if (this.Capitals.Checked) {
                PossibleCharacters += CapitalsArray;
            }
            if (this.Numbers.Checked)
            {
                PossibleCharacters += NumbersArray;
            }
            if (this.Similars.Checked)
            {
                PossibleCharacters += SimilarsArray;
            }
            if (this.Symbols.Checked)
            {
                PossibleCharacters += SymbolsArray;
            }

            for (int count = 0; count < length; count++)
            {
                char randomCharacter = PossibleCharacters[(generator.Next(0, PossibleCharacters.Length))];
                password += randomCharacter;
            }
            this.Password.Text = "Password: " + password;
            PossibleCharacters = defaultArray;
        } 
    }
}
