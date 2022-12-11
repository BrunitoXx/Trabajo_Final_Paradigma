using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Gerente2 : Form
	{
		public Gerente2()
		{
			InitializeComponent();
		}
		//CONEXION CON LA BASE DE DATOS
		static string ruta = @"\BDT.mdb";
		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ruta;
		public static OleDbConnection con = new OleDbConnection(conex);


		public static Int16 valor = Gerente1.valor; //valor representa al ID
		string tipoReclamo, Fecha1, Fecha2, calle, vehiculos;
		int piso, altura, cuadrilla, personalExtra = 0;
		//Saca los datos de la base datos
		void SacarDatos()
		{
			con.Open();
			OleDbCommand com = new OleDbCommand("SELECT * FROM Reclamos WHERE Id=@id", con);
			com.Parameters.AddWithValue("@id", valor);
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);

			DataRow dataRow = dt.Rows[0];
			con.Close();

			tipoReclamo = dataRow[9].ToString();
			Fecha1 = dataRow[11].ToString();
			Fecha2 = dataRow[12].ToString();
			calle = dataRow[3].ToString();
			vehiculos = dataRow[17].ToString();
			piso = Convert.ToInt16(dataRow[5]);
			altura = Convert.ToInt16(dataRow[4]);
			cuadrilla = Convert.ToInt16(dataRow[15]);
			personalExtra = Convert.ToInt16(dataRow[16]);


			List<Int32> list = new List<Int32>();

			string actual;
			for (int i = 0; i < vehiculos.Length; i++)
			{
				actual = vehiculos.Substring(i, 1);

				if (actual != " ")
				{
					list.Add(Convert.ToInt32(actual));
				}
			}

			CargarDatagrid(list); //Carga el datagrid de vehiculos



			txtAltura.Text = altura.ToString();
			txtCalle.Text = calle.ToString();
			txtFecha1.Text = Fecha1;
			txtFecha2.Text = Fecha2;
			txtPiso.Text = piso.ToString();
			txtTipoeclamo.Text = tipoReclamo;

			comboBoxCuadrillas.Items.Add(cuadrilla.ToString());

			if (personalExtra != 0)
			{
				comboBoxCuadrillas.Items.Add(personalExtra.ToString());
			}

		}
		//Procedimiento para cargar datos en el datagridview
		void CargarDatagrid(List<int> IdVehiculos)
		{
			//DataTable Vehiculos = new DataTable();
			DataTable dt = new DataTable();
			for (int i = 0; i < IdVehiculos.Count; i++)
			{
				con.Open();
				OleDbCommand cmd = new OleDbCommand("SELECT Id,Patente,Marca,Tipo FROM Vehiculos WHERE Id=@id", con);

				cmd.Parameters.AddWithValue("@id", IdVehiculos[i]);
				cmd.ExecuteNonQuery();
				OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

				adapter.Fill(dt);

				dgv1.DataSource = dt;

				con.Close();
			}

		}




		//BOTONES:

		//para cerrar la ventana
		private void btnVolver_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Gerente2_Load(object sender, EventArgs e)
		{
			SacarDatos();
		}

		private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
