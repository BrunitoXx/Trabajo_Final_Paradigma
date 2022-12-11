using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Registro : Form
	{
		public Registro()
		{
			InitializeComponent();
		}

		//Coneccion con la base da datos
		static string ruta = @"\BDT.mdb";
		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ruta; //Cadena de conexion con la base da datos
		static OleDbConnection con = new OleDbConnection(conex); //Objeto para conectarse la base da datos
		int Idcliente;
		public void CrearCliente()
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
				textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
			{
				MessageBox.Show("algun campo esta vacio.");
			}
			else
			{
				try
				{
					con.Open(); //Abrimos la coneccion con la base de datos
					OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Clientes", con);

					OleDbCommand cmd = new OleDbCommand("INSERT INTO Clientes VALUES (@ID ,@NOMB, @APE, @CA, @ALT, @PIS, @BARRIO, @COD, @DNI)", con);

					OleDbCommand cm2 = new OleDbCommand("SELECT MAX(Id) FROM Clientes", con);//con esto busca el maximo id de los clientes registrado
					Idcliente = Convert.ToInt32(cm2.ExecuteScalar());//aca lo pasa a una variable para incrementarlo

					cmd.Parameters.AddWithValue("@ID", Idcliente + 1);
					cmd.Parameters.AddWithValue("@NOMB", textBox1.Text);
					cmd.Parameters.AddWithValue("@APE", textBox2.Text);
					cmd.Parameters.AddWithValue("@CA", textBox3.Text);
					cmd.Parameters.AddWithValue("@ALT", textBox4.Text);
					cmd.Parameters.AddWithValue("@PIS", textBox5.Text);
					cmd.Parameters.AddWithValue("@BARRIO", textBox6.Text);
					cmd.Parameters.AddWithValue("@COD", textBox7.Text);
					cmd.Parameters.AddWithValue("@DNI", textBox8.Text);


					cmd.ExecuteNonQuery();

					con.Close();//Cerramos Coneccion con base de datos

					MessageBox.Show("Cliente registrado");

				}

				catch (DBConcurrencyException ex)
				{
					MessageBox.Show("Error de concurrencia:\n" + ex.Message);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

		}

		private void button4_Click(object sender, EventArgs e)
		{
			CrearCliente();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
