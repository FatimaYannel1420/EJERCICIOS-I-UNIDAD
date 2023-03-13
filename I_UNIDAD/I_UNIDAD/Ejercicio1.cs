using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_UNIDAD
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sumar_Click(object sender, EventArgs e)
        {
            //VARIABLES
            decimal numero1 = Convert.ToDecimal (Txt_Numero1.Text);
            decimal numero2 = Convert.ToDecimal(Txt_Numero2.Text);

            decimal resultado = numero1 + numero2;
            MessageBox.Show("El resultado es:" + resultado);
        }
    }
}
