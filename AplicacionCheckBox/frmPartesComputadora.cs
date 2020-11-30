using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCheckBox
{
    public partial class frmPartesComputadora : Form
    {
        public frmPartesComputadora()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MEMORIAS RAM
            string cad = "";
            if (radioButton4gb.Checked)
            {
                cad = "Computadora con 4GB de memoria RAM";
            }
            else if (radioButton8gb.Checked)
            {
                cad = "Computadora con 8GB de memoria RAM";
            }else if (radioButton12gb.Checked) 
            {
                cad = "Computadora con 12GB de memoria RAM";
            }

            this.txtRes.Text = cad;

            //DISCO DURO
            string cad2 = "";
            if (radioButton80gbds.Checked) 
            {
                cad2 = "; 80GB de disco sólido";
            }else if (radioButton300gbds.Checked) 
            {
                cad2 = "; 300GB de disco sólido";
            }else if (radioButton500gbds.Checked)
            {
                cad2 = "; 500GB de disco sólido";
            }

            this.txtRes.Text += cad2;

            //PROCESADORES
            string cad3 = "";
            if (radioButtonPentiumi3.Checked)
            {
                cad3 = ". Con un procesador Intel Pentium/i3";
            }else if (radioButtoni5.Checked)
            {
                cad3 = ". Con un procesador Intel i5";
            }else if (radioButtoni7.Checked)
            {
                cad3 = ". Con un procesador Intel i7";
            }

            this.txtRes.Text += cad3;

            //ACCESORIOS
            string cad4 = ". Además cuenta con los accesorios: ";
            if (checkBoxCam.Checked)
            {
                cad4 += "- cámara WEB ";
            }if (checkBoxImpresora.Checked)
            {
                cad4 += "- impresora ";
            }if (checkBoxMouse.Checked)
            {
                cad4 += "- mouse inalámbrico ";
            }

            if(checkBoxCam.Checked ==false && checkBoxImpresora.Checked ==false && checkBoxMouse.Checked == false)
            {
                cad4 = "";
            }

            this.txtRes.Text += cad4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNum.Text);
            txtNumInvertido.Text = Convert.ToString(invertir(numero));
        }

        static int invertir(int num)
        {
            int numInvertido = 0;
            while(num > 0)
            {
                numInvertido = numInvertido * 10 + num % 10;
                num = num / 10;
            }
            return numInvertido;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Solo numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
