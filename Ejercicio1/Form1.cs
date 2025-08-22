using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nudModelo.Value);
            int añoACalcular = Convert.ToInt32(nudAñoCalcular.Value);
            double valorFabricacion = Convert.ToDouble(tbValorFabrica.Text);
            double tasaDepreciacion = Convert.ToDouble(tbTasadepresion.Text);
            int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);

            Moto moto1 = new Moto(marca, modelo, valorFabricacion);

            double depreciacionLineal = moto1.CalcularDepreciacionlineal(añoACalcular, vidaUtil);
            double depreciacionAnual = moto1.CalcularDepreciacionAnual(añoACalcular, tasaDepreciacion);

            Ver_Resultados resultados = new Ver_Resultados();


            resultados.tbResultado.Text = moto1.VerDescripcion();
            resultados.listbResultados.Items.Add($"Depreciación Lineal: {depreciacionLineal:f2}");
            resultados.listbResultados.Items.Add($"Depreciación Anual: {depreciacionAnual:f2}");

            resultados.ShowDialog();

            resultados.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
