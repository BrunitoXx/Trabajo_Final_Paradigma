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



		public static int valor;

		//----METODOS----

		//Procedimiento para cargar datos en el datagridview
		void CargaDatos()
		{
			con.Open();
			OleDbCommand com = new OleDbCommand("SELECT Id,Tipo_Reclamo,FechaHoraReclamo,FechaHoraReclamo FROM Reclamos WHERE Estado=@ESTADO", con);
			com.Parameters.AddWithValue("@ESTADO", "Solucionado");
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgv1.DataSource = dt;
			con.Close();
		}
		//usar el evento para Sacar el reclamo que se quiere visualizar
		private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv1.Rows[e.RowIndex].Selected = true;
			valor = Convert.ToInt16(dgv1.Rows[e.RowIndex].Cells[0].Value);
			this.Visible = false;
			var win = new Gerente2();
			win.ShowDialog();
			this.Visible = true;
		}

		private void Gerente1_Load(object sender, EventArgs e)
		{
			CargaDatos();
		}

		//----BOTONES----
		//Redirecciona a otro form con los detalles
		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Visible = false;
			var win = new Gerente2();
			win.ShowDialog();
			this.Visible = true;
		}
		//Cierra el fomr
		private void btnVolver_Click(object sender, EventArgs e)
		{
			Close();
		}

		//CONEXION CON LA BASE DE DATOS
		static string ruta = @"\BDT.mdb";
		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ruta;
		public static OleDbConnection con = new OleDbConnection(conex);
	}
}
