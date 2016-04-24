using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //premenne
        Boolean test_comma = false; // test na ciarku
        Boolean operace_scitani = false; // scitanie
        Boolean operace_odcitani = false; // odcitanie
        Boolean operace_nasobeni = false; // nasobenie
        Boolean operace_deleni = false; // delenie
        Boolean operace_faktorial = false; // faktoorial
        Boolean operace_pow = false; // mocnina
        Boolean zvysok_del = false; // zvysok po deleni
        Boolean operace_sqrt = false; // odmocnina
        double operand1 = 0; // prve cislo
        double operand2 = 0; // druhe cislo
        double vysledok = 0; // vysledok
        matematicka.Class1 newObject = new matematicka.Class1(); // inicializace mat.knihovny

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Clear(); // ak je tam 0 vycistime textbox
            }
            Button button = (Button)sender; // posielame z tlacitka hodnotu 
            if (button.Text == ",") // osetrenie ciarky 
            {
                if (textBox1.Text == "") // osetrenie ked pred ciarkou nieje nic
                {
                    textBox1.Text = "0";
                }
                if (test_comma == true) // osetrenie ak sa tam uz jedna ciarka nachadza
                { }
                else
                {
                    test_comma = true;
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
            
        }

        private void button17_Click(object sender, EventArgs e) // clearovaci button
            // nastavi vsetky priznaky operaci na default
        {
            test_comma = false;
            operace_scitani = false;
            operace_odcitani = false;
            operace_nasobeni = false;
            operace_deleni = false;
            operace_faktorial = false;
            operace_pow = false;
            zvysok_del = false;
            operace_sqrt = false;
            operand1 = 0;
            operand2 = 0;
            vysledok = 0;
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e) // operace scitani , nastaveni priznakov a nacitanie prveho cisla
        {
            if (operace_scitani == true || operace_odcitani == true || operace_deleni == true || operace_nasobeni == true || operace_pow == true || operace_faktorial == true || operace_sqrt == true || zvysok_del == true)
                {
                    button15_Click(sender, e);
                }
                    
            operace_scitani = true;
            test_comma = false;
            operand1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";           
        }

        private void button12_Click(object sender, EventArgs e) // operace odcitani , nastaveni priznakov a nacitanie prveho cisla
        {
            if (operace_scitani == true || operace_odcitani == true || operace_deleni == true || operace_nasobeni == true || operace_pow == true || operace_faktorial == true || operace_sqrt == true || zvysok_del == true)
            {
                button15_Click(sender, e);
            }
            operace_odcitani = true;
            test_comma = false;
            operand1 = Convert.ToDouble(textBox1.Text);
            operand1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e) // operace nasobeni , nastaveni priznakov a nacitanie prveho cisla
        {
            if (operace_scitani == true || operace_odcitani == true || operace_deleni == true || operace_nasobeni == true || operace_pow == true || operace_faktorial == true || operace_sqrt == true || zvysok_del == true)
            {
                button15_Click(sender, e);
            }
            if (operace_nasobeni == true)
            {
                button15_Click(sender, e);
            }
            operace_nasobeni = true;
            test_comma = false;
            operand1 = Convert.ToDouble(textBox1.Text);
            operand1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)  // operace deleni , nastaveni priznakov a nacitanie prveho cisla
        {
            if (operace_scitani == true || operace_odcitani == true || operace_deleni == true || operace_nasobeni == true || operace_pow == true || operace_faktorial == true || operace_sqrt == true || zvysok_del == true)
            {
                button15_Click(sender, e);
            }
            if (operace_deleni == true)
            {
                button15_Click(sender, e);
            }
            operace_deleni = true;
            test_comma = false;
            operand1 = Convert.ToDouble(textBox1.Text);
            operand1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e) // rovna se , podla toho aky priznak je nacitany ,  vykona danu operaciu
        {
            test_comma = false;
            if (operace_scitani==true)
            {
                operand2 = Convert.ToDouble(textBox1.Text);
                label1.Text = label1.Text + textBox1.Text + "=";
                vysledok = newObject.add(operand1, operand2);
                textBox1.Text = vysledok.ToString();
                operace_scitani = false;
            }
            if (operace_odcitani == true)
            {
                operand2 = Convert.ToDouble(textBox1.Text);
                label1.Text = label1.Text + textBox1.Text + "=";
                vysledok = newObject.sub(operand1, operand2);
                textBox1.Text = vysledok.ToString();
                operace_odcitani = false; 
            }
            if (operace_nasobeni == true)
            {
                operand2 = Convert.ToDouble(textBox1.Text);
                label1.Text = label1.Text + textBox1.Text + "=";
                vysledok = newObject.nas(operand1, operand2);
                textBox1.Text = vysledok.ToString();
                operace_nasobeni = false;
            }
            if (operace_deleni == true)
            {
                operand2 = Convert.ToDouble(textBox1.Text);
                label1.Text = label1.Text + textBox1.Text + "=";
                vysledok = newObject.del(operand1, operand2);
                textBox1.Text = vysledok.ToString();
                operace_deleni = false;
            }
            if (operace_pow == true)
            {
                operand2 = Convert.ToDouble(textBox1.Text);
                label1.Text = label1.Text + textBox1.Text + "=";
                vysledok = newObject.PowerA(operand1, operand2);
                textBox1.Text = vysledok.ToString();
                operace_pow = false;
            }
            if (zvysok_del == true)
            {
                operand2 = Convert.ToDouble(textBox1.Text);
                label1.Text = label1.Text + textBox1.Text + "=";
                vysledok = newObject.modulo(operand1, operand2);
                textBox1.Text = vysledok.ToString();
                operace_pow = false;
            }
            if (operace_sqrt == true)
            {
                operand2 = Convert.ToDouble(textBox1.Text);
                label1.Text = label1.Text + textBox1.Text + "=";
                vysledok = newObject.odmocneni(operand1, operand2);
                textBox1.Text = vysledok.ToString();
                operace_sqrt = false;
            }

        }

        private void button18_Click(object sender, EventArgs e) // faktorial daneho nacitaneho cisla , priznaky a vypis
        {
            if (operace_scitani == true || operace_odcitani == true || operace_deleni == true || operace_nasobeni == true || operace_pow == true || operace_faktorial == true || operace_sqrt == true || zvysok_del == true)
            {
                button15_Click(sender, e);
            }
            operace_faktorial = true;
            test_comma = false;
            operand1 = Convert.ToDouble(textBox1.Text);
            vysledok = newObject.factorial(operand1);
            label1.Text = textBox1.Text + "!";
            textBox1.Text = vysledok.ToString();
        }

        private void button19_Click(object sender, EventArgs e) // nta mocnina " Funguje zaujimavo treba odskusat "
        {
            if (operace_scitani == true || operace_odcitani == true || operace_deleni == true || operace_nasobeni == true || operace_pow == true || operace_faktorial == true || operace_sqrt == true || zvysok_del == true)
            {
                button15_Click(sender, e);
            }
            operace_pow = true;
            test_comma = false;
            operand1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "^";
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e) // zvysok po deleni , tzv. modulo
        {
            if (operace_scitani == true || operace_odcitani == true || operace_deleni == true || operace_nasobeni == true || operace_pow == true || operace_faktorial == true || operace_sqrt == true || zvysok_del == true)
            {
                button15_Click(sender, e);
            }
            zvysok_del = true;
            test_comma = false;
            operand1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "%";
            textBox1.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e) // nta odmocnina "odskusajte a pochopite jak funguje" 
        {
            if (operace_scitani == true || operace_odcitani == true || operace_deleni == true || operace_nasobeni == true || operace_pow == true || operace_faktorial == true || operace_sqrt == true || zvysok_del == true)
            {
                button15_Click(sender, e);
            }
            operace_sqrt = true;
            test_comma = false;
            operand1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "√";
            textBox1.Text = "0";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
    }
    }/*pomenoval som vsetky funkcie ktore som tvori , zvysne su dodatocne z designu */
    
}
