using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Empleado3 : Form
	{
		public Empleado3()
		{
			InitializeComponent();
		}
		static string ruta = @"\BDT.mdb";
		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ruta;
		OleDbConnection con = new OleDbConnection(conex);

		int valor, id;

		void CargaDatos()
		{
			con.Open();
			//OleDbCommand com = new OleDbCommand("SELECT * FROM Reclamos WHERE Estado=@ESTADO", con);
			OleDbCommand com = new OleDbCommand("SELECT Id,Nombre,Apellido,Calle,Altura,Piso,Telefono,Correo,Observaciones,Tipo_Reclamo,Estado,FechaHoraReclamo,FechaHoraSolucion,Prioridad FROM Reclamos", con);// WHERE Estado=@ESTADO
			//com.Parameters.AddWithValue("@ESTADO", "En tramite");
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgv1.DataSource = dt;
			con.Close();
		}

		void ModificarEstado()
		{
			con.Open(); //Abrir la coneccion
			string com = "UPDATE Reclamos SET Estado = @ESTADO WHERE Id = @id";
	
			OleDbCommand cmd = new OleDbCommand(com, con);//Crear el comando
			cmd.Parameters.AddWithValue("@ESTADO", "Solucionado");
			cmd.Parameters.AddWithValue("@id", valor);
			cmd.ExecuteNonQuery();//Ejecutar comando
			con.Close();
		}

		private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dgv1.Rows[e.RowIndex].Selected = true;
			id = Convert.ToInt16(dgv1.Rows[e.RowIndex].Cells[0].Value);
			//MessageBox.Show(valor);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ModificarEstado();
			CargaDatos();
		}

		private void Empleado3_Load(object sender, EventArgs e)
		{
			CargaDatos();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CargaDatos();
		}

		private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			dgv1.Rows[e.RowIndex].Selected = true;
			valor = Convert.ToInt16(dgv1.Rows[e.RowIndex].Cells[0].Value);
		}
	}
}
