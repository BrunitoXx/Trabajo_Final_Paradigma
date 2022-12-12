using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Gerente1 : Form
	{
		public Gerente1()
		{
			InitializeComponent();
		}
		//CONEXION CON LA BASE DE DATOS
		static string ruta = @"\BDT.mdb";
		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ruta;
		public static OleDbConnection con = new OleDbConnection(conex);

		//----METODOS----

		//Procedimiento para cargar datos en el datagridview
		void CargaDatosClientes()
		{
			con.Open();
			OleDbCommand com = new OleDbCommand("SELECT * FROM Clientes", con);
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgv1.DataSource = dt;
			con.Close();
		}
		void CargaDatosEmpleados()
		{
			con.Open();
			OleDbCommand com = new OleDbCommand("SELECT * FROM Empleados", con);
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgv2.DataSource = dt;
			con.Close();
		}
		void CargarDatosReclamos()
		{
			con.Open();
			OleDbCommand com = new OleDbCommand("SELECT * FROM Reclamos", con);
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgv3.DataSource = dt;
			con.Close();
		}
		void CargarDatosVehiculos()
		{
			con.Open();
			OleDbCommand com = new OleDbCommand("SELECT * FROM Vehiculos", con);
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgv4.DataSource = dt;
			con.Close();
		}

		//Variables para sacar el id de cada dgv
		int valor1, valor2, valor3, valor4;
		
		private void Gerente1_Load(object sender, EventArgs e)
		{
			CargaDatosClientes();
			CargaDatosEmpleados();
			CargarDatosReclamos();
			CargarDatosVehiculos();
		}

		private void dgv4_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dgv4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//dgv4.Rows[e.RowIndex].Selected = true;
			valor4 = Convert.ToInt16(dgv4.Rows[e.RowIndex].Cells[0].Value);
			DialogResult dialog = MessageBox.Show("Desea BORRAR el Vehiculo Seleccionado?", "BORRAR?!", MessageBoxButtons.YesNoCancel);

			if(dialog == DialogResult.Yes)
			{
				con.Open();
				OleDbCommand com = new OleDbCommand("DELETE FROM Vehiculos WHERE Id=@id", con);
				com.Parameters.AddWithValue("@id", valor4);
				com.ExecuteNonQuery();
				con.Close();
			}
			CargarDatosVehiculos();

		}

		private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dgv3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//dgv4.Rows[e.RowIndex].Selected = true;
			valor3 = Convert.ToInt16(dgv3.Rows[e.RowIndex].Cells[0].Value);
			DialogResult dialog = MessageBox.Show("Desea BORRAR el Reclamo Seleccionado?", "BORRAR?!", MessageBoxButtons.YesNoCancel);

			if (dialog == DialogResult.Yes)
			{
				con.Open();
				OleDbCommand com = new OleDbCommand("DELETE FROM Reclamos WHERE Id=@id", con);
				com.Parameters.AddWithValue("@id", valor3);
				com.ExecuteNonQuery();
				con.Close();
			}
			CargarDatosReclamos();
		}
		private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dgv2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//dgv4.Rows[e.RowIndex].Selected = true;
			valor2 = Convert.ToInt16(dgv2.Rows[e.RowIndex].Cells[0].Value);
			DialogResult dialog = MessageBox.Show("Desea BORRAR el Empleado Seleccionado?", "BORRAR?!", MessageBoxButtons.YesNoCancel);

			if (dialog == DialogResult.Yes)
			{
				con.Open();
				OleDbCommand com = new OleDbCommand("DELETE FROM Empleados WHERE Id=@id", con);
				com.Parameters.AddWithValue("@id", valor2);
				com.ExecuteNonQuery();
				con.Close();
			}
			CargaDatosEmpleados();
		}
		private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//dgv4.Rows[e.RowIndex].Selected = true;
			valor1 = Convert.ToInt16(dgv1.Rows[e.RowIndex].Cells[0].Value);
			DialogResult dialog = MessageBox.Show("Desea BORRAR el Cliente Seleccionado?", "BORRAR?!", MessageBoxButtons.YesNoCancel);

			if (dialog == DialogResult.Yes)
			{
				con.Open();
				OleDbCommand com = new OleDbCommand("DELETE FROM Clientes WHERE Id=@id", con);
				com.Parameters.AddWithValue("@id", valor1);
				com.ExecuteNonQuery();
				con.Close();
			}
			CargaDatosClientes();
		}

		//----BOTONES----

		//Cierra el fomr
		private void btnVolver_Click(object sender, EventArgs e)
		{
			Close();
		}

		
	}
}
