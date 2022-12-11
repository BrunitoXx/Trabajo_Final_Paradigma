using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Cliente1 : Form
	{
		public Cliente1()
		{
			InitializeComponent();
		}

		//BOTONES:
		//Redericciona para ingresar el reclamo
		private void button1_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new Cliente2();
			ventana.ShowDialog();
			this.Visible = true;
		}
		//Redericciona para consultar el estado del reclamo
		private void button2_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new Cliente3();
			ventana.ShowDialog();
			this.Visible = true;
		}
		//Cierra la ventana
		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}




	}
}
