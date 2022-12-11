using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	class Reclamo
	{
		//Atributos
		public Cliente cliente;
		public String fecha_hora;
		public String tipo_reclamo;
		public String observaciones;
		public Int16 nro_reclamo;
		public String estado = "En espera";
		public String Prioridad;
		public int Valor_Prioridad;
		public string calle;
		public int altura;
		public int piso;


		//Metodos
		public Reclamo()
		{

		}

		String GeneraPrioridad()
		{

			if (tipo_reclamo == "Caida de Poste")
			{
				return "MEDIA";
			}
			else if (tipo_reclamo == "Falla de Transformador")
			{
				return "ALTA";
			}
			else if (tipo_reclamo == "Desperfecto Electrico" | tipo_reclamo == "Otros")
			{
				return "BAJA";
			}
			else
			{
				return null;
			}

		}

		int ValorPrioridad()
		{
			if (GeneraPrioridad() == "BAJA")
			{
				return 3;
			}
			else if (GeneraPrioridad() == "MEDIA")
			{
				return 2;
			}
			else
			{
				return 1;
			}

		}

		public Reclamo(String tr, String obs, Cliente cl, Int16 Nro, String Fecha_y_Hora, string Calle, int Altura, int Piso)
		{

			fecha_hora = Fecha_y_Hora;
			cliente = cl;
			tipo_reclamo = tr;
			observaciones = obs;
			nro_reclamo = Nro;

			calle = Calle;
			piso = Piso;
			altura = Altura;

			Prioridad = GeneraPrioridad();
			Valor_Prioridad = ValorPrioridad();
		}



		//Coneccion con la base da datos
		static string ruta = @"\BDT.mdb";
		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ruta; //Cadena de conexion con la base da datos
		static OleDbConnection con = new OleDbConnection(conex); //Objeto para conectarse la base da datos


		public void Insertar()
		{
			try
			{
				con.Open(); //Abrimos la coneccion con la base de datos
				OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Reclamos", con);
				OleDbCommand cmd = new OleDbCommand("INSERT INTO Reclamos VALUES (@ID, @NOMB, @APE, @CA, @ALT, @PIS, @TEL, @CORR, @OBS, @TIPO, @EST," +
					"@FECHA1, @FECHA2, @PRIORIDAD,@VALOR,@CUADRILLA,@PERSONAL,@VEHICULOS)", con);
				cmd.Parameters.AddWithValue("@ID", nro_reclamo);
				cmd.Parameters.AddWithValue("@NOMB", cliente.nombre);
				cmd.Parameters.AddWithValue("@APE", cliente.apellido);
				cmd.Parameters.AddWithValue("@CA", calle);
				cmd.Parameters.AddWithValue("@ALT", altura);
				cmd.Parameters.AddWithValue("@PIS", piso);
				cmd.Parameters.AddWithValue("@TEL", cliente.telefono);
				cmd.Parameters.AddWithValue("@CORR", cliente.correo);
				cmd.Parameters.AddWithValue("@OBS", observaciones);
				cmd.Parameters.AddWithValue("@TIPO", tipo_reclamo);
				cmd.Parameters.AddWithValue("@EST", estado);

				cmd.Parameters.AddWithValue("@FECHA1", fecha_hora);
				cmd.Parameters.AddWithValue("@FECHA2", "-");
				cmd.Parameters.AddWithValue("@PRIORIDAD", Prioridad);

				cmd.Parameters.AddWithValue("@VALOR", Valor_Prioridad);
				cmd.Parameters.AddWithValue("@CUADRILLA", 0);
				cmd.Parameters.AddWithValue("@PERSONAL", 0);

				cmd.Parameters.AddWithValue("@VEHICULOS", "-");

				cmd.ExecuteNonQuery();

				con.Close();//Cerramos Coneccion con base de datos

				MessageBox.Show("Registro guardado");

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
}
