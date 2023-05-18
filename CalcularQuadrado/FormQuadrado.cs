using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularQuadrado
{
    public partial class FormQuadrado : Form
    {
        public FormQuadrado()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //declara as variaveis

            int numero;
            int quadrado = 0;

            //atribui o valor de entrada na variavel numero vindo da txBox_calcular
            numero = Convert.ToInt32(txBox_calcular.Text);

            //atribui o valor de entrada na variavel quadrado, realizando calculo
            quadrado = numero * numero;

            lbl_resul.Text = "Quadrado de " + numero + " é: " + quadrado.ToString();
            txBox_calcular.Text = "";
            txBox_calcular.Focus();
        }

     
    }
}