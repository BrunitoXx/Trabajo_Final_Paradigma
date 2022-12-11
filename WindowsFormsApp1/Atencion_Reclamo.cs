using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	class Atencion_Reclamo
	{
		//Atributos
		public int nroReclamo;
		public int PersonalReclamoID;
		public int PersonalExtraID;
		public List<int> VehiculosID = new List<int>();
		public String fecha_y_hora;
		int Escalera, CajaHerramientas, Transformador, Poste, Focos,
			Llave, Otro;
		public string estado = "En tramite";


		public Atencion_Reclamo()
		{

		}

		public Atencion_Reclamo(int idReclamo)
		{
			nroReclamo = idReclamo;
		}

		public Atencion_Reclamo(String Fecha_y_Hora)
		{
			fecha_y_hora = Fecha_y_Hora;
		}

		public void AgregarCuarilla(int PersonalExtraId)
		{
			PersonalExtraID = PersonalExtraId;
		}

		public void AgregarVehiculo(int VehiculoID)
		{
			VehiculosID.Add(VehiculoID);
		}

		public void AgregarHerramientas(int escalera, int cajaHerramientas, int transformador, int poste, int focos,
			int llave, int otro)
		{
			Escalera = escalera;
			CajaHerramientas = cajaHerramientas;
			Transformador = transformador;
			Poste = poste;
			Focos = focos;
			Llave = llave;
			Otro = otro;
		}

		public int DevolverIdReclamo()
		{
			return nroReclamo;
		}

		public string DevolverVehiculosUsados()
		{
			string vehiculosUsados = null;

			foreach (var IDvehiculo in VehiculosID)
			{
				vehiculosUsados = vehiculosUsados + " " + IDvehiculo.ToString();
			}
			return vehiculosUsados;
		}

		//Coneccion con la base da datos
		static string ruta = @"\BDT.mdb";
		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ruta; //Cadena de conexion con la base da datos
		static OleDbConnection con = new OleDbConnection(conex); //Objeto para conectarse la base da datos

		public void CargarAtencion()
		{
			con.Open(); //Abrir la coneccion  ,Fecha/Hora Solucion=@FECHA
			string com = "UPDATE Reclamos SET Estado=@ESTADO,FechaHoraSolucion=@FECHA, Cuadrilla=@CUADRILLA, PersonalExtra=@PERSONAL,VehiculosUsados=@VEHICULOS WHERE Id = @id";
			OleDbCommand cmd = new OleDbCommand(com, con);//Crear el comando
			cmd.Parameters.AddWithValue("@ESTADO", estado);
			cmd.Parameters.AddWithValue("@FECHA", fecha_y_hora);
			cmd.Parameters.AddWithValue("@CUADRILLA", PersonalReclamoID);
			cmd.Parameters.AddWithValue("@PERSONAL", PersonalExtraID);
			cmd.Parameters.AddWithValue("@VEHICULOS", DevolverVehiculosUsados());

			cmd.Parameters.AddWithValue("@id", nroReclamo);
			cmd.ExecuteNonQuery();//Ejecutar comando
			con.Close();
		}

	}
}
