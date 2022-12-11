using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Empleado1 : Form
	{
		public Empleado1()
		{
			InitializeComponent();
		}


		public static Int16 valor;//Almacenar el id del reclamo seleccionado

		private void Form2_Load(object sender, EventArgs e)
		{
			CargaDatos();
		}

		//METODOS:

		//Procedimiento para cargar datos en el datagridview
		void CargaDatos()
		{
			con.Open();
			OleDbCommand com = new OleDbCommand("SELECT Id,Nombre,Apellido,Calle,Altura,Piso,Tipo_Reclamo,FechaHoraReclamo,Prioridad FROM Reclamos WHERE Estado=@ESTADO ORDER BY Valor_Prioridad ASC", con);
			com.Parameters.AddWithValue("@ESTADO", "En espera");
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgv1.DataSource = dt;
			con.Close();
		}
		
		//Sacar el reclamo que se quiere atender
		private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
	
				dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				dgv1.Rows[e.RowIndex].Selected = true;
				valor = Convert.ToInt16(dgv1.Rows[e.RowIndex].Cells[0].Value);
				this.Visible = false;
				var ventana = new Empleado2();
				ventana.ShowDialog();
				this.Visible = true;
			
			//dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//dgv1.Rows[e.RowIndex].Selected = true;
			//valor = Convert.ToInt16(dgv1.Rows[e.RowIndex].Cells[0].Value);
		}

		//BOTONES:

		//Abre el formulario para la atencion del reclamo
		//esto queda inutilizado ya que agrege para que al hacer 2ble click al reclamo ya habra el formulario
		private void button1_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var ventana = new Empleado2();
			ventana.ShowDialog();
			this.Visible = true;
		}
		//Cierra la ventana
		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}
		//Redirecciona para cambiar el reclamo a solucionado
		private void button2_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			var win = new Empleado3();
			win.ShowDialog();
			this.Visible = true;
		}

		static string ruta = @"\BDT.mdb";
		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ruta;
		OleDbConnection con = new OleDbConnection(conex);

	
	}
}
