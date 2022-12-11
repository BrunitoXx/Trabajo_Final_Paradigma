using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Cliente3 : Form
	{
		public Cliente3()
		{
			InitializeComponent();
		}

		//METODOS:

		// para verificar la existencia de un cliente
		public bool VerificaCliente(Cliente cli)
		{

			//Buscar el Cliente en la Base de Datos
			con.Open();

			OleDbCommand com = new OleDbCommand("SELECT Id,Nombre,Apellido FROM Clientes WHERE Id=@ID", con);
			com.Parameters.AddWithValue("@Id", cli.nroCliente);
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);

			con.Close();

			if (dt.Rows.Count == 0)
			{
				return false;
				//lblVerificar.Text = "Verifique los campos Ingresados.";
			}
			else
			{
				DataRow dataRow = dt.Rows[0];
				Cliente CliBD = new Cliente(dataRow["Nombre"].ToString(), dataRow["Apellido"].ToString(), cli.nroCliente);

				if (cli.nombre == CliBD.nombre & cli.apellido == CliBD.apellido)
				{
					return true;
					//MessageBox.Show("El Cliente esta en la base de datos.");
				}
				else
				{
					return false;
					//MessageBox.Show(cli.DecirDatos() + " no se encuentra en la base de datos. ");
				}
			}

		}

		//BOTONES:

		//Para cerrar la ventana
		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
		//Para mostrar el estado del reclamo
		private void button2_Click(object sender, EventArgs e)
		{
			Cliente cli = new Cliente(txtNombre.Text, txtApe.Text, Convert.ToInt16(txtNroCliente.Text));

			if (VerificaCliente(cli) == true) //Si esta el cliente
			{
				con.Open();

				OleDbCommand com = new OleDbCommand("SELECT Nombre,Apellido,Tipo_Reclamo,Estado,FechaHoraReclamo,FechaHoraSolucion FROM Reclamos WHERE (Nombre=@nomb) AND (Apellido=@APELLIDO)", con);
				com.Parameters.AddWithValue("@NOMB", cli.nombre);
				com.Parameters.AddWithValue("@APELLIDO", cli.apellido);
				com.ExecuteNonQuery();
				OleDbDataAdapter da = new OleDbDataAdapter(com);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dgv1.DataSource = dt;

				con.Close();
			}
			else
			{
				MessageBox.Show("Ingrese los datos correctamente.");
			}

		}

		//Coneccion con la base da datos
		static string ruta = @"\BDT.mdb";
		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ruta; //Cadena de conexion con la base da datos
		static OleDbConnection con = new OleDbConnection(conex); //Objeto para conectarse la base da datos

	}
}