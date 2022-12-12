using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Principal : Form
	{
		public Principal()
		{
			InitializeComponent();
		}



		private void button1_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new Empleado1();
			ventana.ShowDialog();
			this.Visible = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new Cliente1();
			ventana.ShowDialog();
			this.Visible = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new Gerente1();
			ventana.ShowDialog();
			this.Visible = true;
		}



		private void button5_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new Registro();
			ventana.ShowDialog();
			this.Visible = true;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
