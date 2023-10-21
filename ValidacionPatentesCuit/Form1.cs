using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacionPatentesCuit
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//PATENTES
		private void btRegistrar_Click(object sender, EventArgs e)
		{
			if (itemVieja.Checked)
			{
				if (patVieja.Text.Length <6 )
				{ 	
					MessageBox.Show("Error en cargar la patente");
					return;
				}
				lblRes.Text = patVieja.Text.Substring(0, 3).ToUpper() + " " + patVieja.Text.Substring(3, 4);

			}
			else
			{
				if(patNueva.Text.Length < 9) 
				{
					MessageBox.Show("Error en cargar la patente");
					return;
				}
				lblRes.Text = patNueva.Text.Substring(0,2).ToUpper()+ "" + patNueva.Text.Substring(2,3) + "" + patNueva.Text.Substring(5,4).ToUpper();
			}
		}


		//CUIT

		private void btCargar_Click(object sender, EventArgs e)
		{
			if (txtCuit.Text.Length == 11)
			{
				lblCuit.Text = "El Cuit es:" + txtCuit.Text.Substring(0, 2) + "-" + txtCuit.Text.Substring(2, 8) + "-" + txtCuit.Text.Substring(10, 1);
				lblDNI.Text = "El DNI es:" + txtCuit.Text.Substring(2,8);
			}
			else
			{
				MessageBox.Show("CUIT INCORRECTO");
				return;
			}

		}
	}
}
