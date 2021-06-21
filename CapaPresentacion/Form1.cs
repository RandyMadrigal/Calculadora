using System;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        //Objeto de la capa Logica.
        Operaciones Logica = new Operaciones();

        private Image ImagenInicio;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Logica.AgregarValor = int.Parse(Btn_0.Text);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += Logica.AgregarValor.ToString();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Logica.AgregarValor = int.Parse(btn_1.Text);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += Logica.AgregarValor.ToString();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Logica.AgregarValor = int.Parse(btn_2.Text);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += Logica.AgregarValor.ToString();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Logica.AgregarValor = int.Parse(btn_3.Text);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += Logica.AgregarValor.ToString();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Logica.AgregarValor = int.Parse(btn_4.Text);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += Logica.AgregarValor.ToString();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Logica.AgregarValor = int.Parse(btn_5.Text);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += Logica.AgregarValor.ToString();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Logica.AgregarValor = int.Parse(btn_6.Text);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += Logica.AgregarValor.ToString();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Logica.AgregarValor = int.Parse(btn_7.Text);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += Logica.AgregarValor.ToString();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Logica.AgregarValor = int.Parse(btn_8.Text);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += Logica.AgregarValor.ToString();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Logica.AgregarValor = int.Parse(btn_9.Text);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += Logica.AgregarValor.ToString();
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            Logica.Operador = Convert.ToChar(BtnSumar.Text);

            Logica.Valor1 = double.Parse(txtResultado.Text);

            txtResultado.Text = Logica.Limpiar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Logica.Limpiar();
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            Logica.Operador = Convert.ToChar(BtnRestar.Text);

            Logica.Valor1 = double.Parse(txtResultado.Text);

            txtResultado.Text = Logica.Limpiar();

        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            Logica.Operador = Convert.ToChar(BtnMultiplicar.Text);

            Logica.Valor1 = double.Parse(txtResultado.Text);

            txtResultado.Text = Logica.Limpiar();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            Logica.Operador = Convert.ToChar(BtnDividir.Text);

            Logica.Valor1 = double.Parse(txtResultado.Text);

            txtResultado.Text = Logica.Limpiar();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Logica.Valor1 = double.Parse(txtResultado.Text);

            txtResultado.Text = Logica.Cuadrado(Logica.Valor1).ToString();

        }
        private void btn_raiz_Click(object sender, EventArgs e)
        {
            Logica.Valor1 = double.Parse(txtResultado.Text);

            txtResultado.Text = Logica.Raiz(Logica.Valor1).ToString();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            Logica.Valor2 = double.Parse(txtResultado.Text);

            if (Logica.Operador == '+')
            {
                txtResultado.Text = Logica.Suma(Logica.Valor1, Logica.Valor2).ToString();
                Logica.Valor1 = double.Parse(txtResultado.Text);
            }
            else if (Logica.Operador == '-')
            {
                txtResultado.Text = Logica.Resta(Logica.Valor1, Logica.Valor2).ToString();
                Logica.Valor1 = double.Parse(txtResultado.Text);
            }
            else if (Logica.Operador == 'x')
            {
                txtResultado.Text = Logica.Multiplicar(Logica.Valor1, Logica.Valor2).ToString();
                Logica.Valor1 = double.Parse(txtResultado.Text);
            }
            else if (Logica.Operador == '/')
            {
               if(Logica.Valor2 != 0)
               {
                  txtResultado.Text = Logica.Dividir(Logica.Valor1, Logica.Valor2).ToString();
                 Logica.Valor1 = double.Parse(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre 0 ");
                    txtResultado.Text = Logica.Valor1.ToString();
                }  
            }
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Logica.Ayuda());
        }
    }
}
