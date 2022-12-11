using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Empleado2 : Form
	{
		public Empleado2()
		{
			InitializeComponent();
		}

		//Crear el objeto reclamo y pasare el id del reclamo
		Atencion_Reclamo atencion_Reclamo = new Atencion_Reclamo(Empleado1.valor);

		private void Empleado2_Load(object sender, EventArgs e)
		{
			CargaDatosReclamoActual();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";
			dateTimePicker1.CustomFormat = " dddd dd MMMM yyyy hh:mm:ss ";
		}

		int escalera, CajaHerramientas, transformador, poste, focos,
			llave, otro;

		int id = 0, IdPersonalExtra = 0;

		string fechaYhora;


		//METODOS:
		Empleado1 asd = new Empleado1();
		//Procedimiento para cargar reclamo actual en el datagridview
		void CargaDatosReclamoActual()
		{
			
			con.Open();
			OleDbCommand com = new OleDbCommand("SELECT Calle, Altura, Piso, Tipo_Reclamo, Observaciones FROM Reclamos WHERE Id=@ID ", con);
			com.Parameters.AddWithValue("@ID", atencion_Reclamo.nroReclamo);
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgv1.DataSource = dt;
			con.Close();
		}

		//Procedimiento para cargar los vehiculos en el datagridview
		void CargaDatosDgv2(string TIPO)
		{
			con.Open();
			OleDbCommand com = new OleDbCommand("SELECT * FROM Vehiculos WHERE (Tipo=@TIPO) AND (Estado=@ESTADO)", con);
			com.Parameters.AddWithValue("@TIPO", TIPO);
			com.Parameters.AddWithValue("@ESTADO", "Disponible");
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgv2.DataSource = dt;
			con.Close();
		}

		//Inicializa y carga las variables y cantidad de herramientas
		void CargarHerramientas()
		{
			escalera = CajaHerramientas = transformador = poste = focos
				= llave = otro = 0;

			if (checkCajaHerramientas.Checked == true)
			{
				CajaHerramientas = Convert.ToInt16(txtCajaHerramientas.Text);
			}

			if (checkEscalera.Checked == true)
			{
				escalera = Convert.ToInt16(txtEscalera.Text);
			}

			if (checkFocos.Checked == true)
			{
				focos = Convert.ToInt16(txtFocos.Text);
			}

			if (checkLlaves.Checked == true)
			{
				llave = Convert.ToInt16(txtLlaves.Text);
			}

			if (checkPoste.Checked == true)
			{
				poste = Convert.ToInt16(txtPoste.Text);
			}

			if (checkTransformador.Checked == true)
			{
				transformador = Convert.ToInt16(txtTransformador.Text);
			}

			if (checkOtros.Checked == true)
			{
				otro = Convert.ToInt16(txtOtros.Text);
			}
		}

		//Procedimientos para cargar los comboBox
		void CargaDatosCuarillasCombobox(int CuadrillaActual)
		{
			//Abrir la conexion con la Base da Datos
			con.Open();

			//Extraer los Datos de la Base da Datos
			OleDbCommand com = new OleDbCommand("SELECT * FROM Cuadrillas WHERE (Estado=@EST)AND (Id>@ID) OR (Id<@ID) ", con); //Selecciona todos los Datos de la Tabla Cuadrilla
			com.Parameters.AddWithValue("@EST", "Disponible");
			com.Parameters.AddWithValue("ID", CuadrillaActual);
			OleDbDataAdapter da = new OleDbDataAdapter(com); //objeto para pasar los datos a un DATASET,DATATABLE,ELC;
			DataTable dt = new DataTable(); //Almacena UNA tabla de una base da datos
			da.Fill(dt);//Le pasamos los datos a el objeto DATATABLE

			//Cargamos el combobox con los datos de los empleados

			int max = dt.Rows.Count;

			comboBoxPersonalExtra.Items.Clear(); //Antes de cargar, limpia el combobox

			for (int i = 0; i < max; i++)
			{
				DataRow dataRow = dt.Rows[i];
				comboBoxPersonalExtra.Items.Add(dataRow["Cuadrilla"].ToString());
			}

			//Cerramos la Conexion con la Base da Datos
			con.Close();
		}

		int BuscarId(string NombreCuadrilla)
		{
			con.Open();
			OleDbCommand com = new OleDbCommand("SELECT * FROM Cuadrillas WHERE Cuadrilla=@CUADRILLA ", con);
			com.Parameters.AddWithValue("@CUADRILLA", NombreCuadrilla);
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();

			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("No se ingreso cuadrilla");
				return 0;
			}
			else
			{
				DataRow dataRow = dt.Rows[0]; //Asiga el valor de la tabla en la fila 0 al datarow( fila de un  data table)
				int ID = Convert.ToInt16(dataRow["Id"]);

				return ID;
			}

		}

		//Procedimiento para Borrar campos
		void BorrarCampos()
		{
			//Datos del empleado
			txtApellidoEmpleado.Text = "";
			txtNombreEmpleado.Text = "";
			txtNroEmpleado.Text = "";

			//Herramientas
			txtEscalera.Text = "";
			txtFocos.Text = "";
			txtLlaves.Text = "";
			txtPoste.Text = "";
			txtTransformador.Text = "";
			txtCajaHerramientas.Text = "";
			txtOtros.Text = "";


		}

		//Funciones Para Verificar empleado
		bool VerificaEmpleado(Empleado emp)
		{

			//Buscar el empleado en la Base de Datos
			con.Open();

			OleDbCommand com = new OleDbCommand("SELECT Id,Nombre,Apellido,Cuadrilla FROM Empleados WHERE Id=@ID", con);
			com.Parameters.AddWithValue("@ID", emp.numempleado);
			com.ExecuteNonQuery();
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);

			con.Close();

			if (dt.Rows.Count == 0)
			{
				//lblVerificar.Text = "Verifique los campos Ingresados.";
				return false;
			}
			else
			{
				DataRow dataRow = dt.Rows[0];
				Empleado EmpDB = new Empleado(dataRow["Nombre"].ToString(), dataRow["Apellido"].ToString(), Convert.ToInt16(dataRow["Cuadrilla"]), Convert.ToInt16(dataRow["Id"]));

				if (emp.nombre == EmpDB.nombre & emp.apellido == EmpDB.apellido & emp.numCuadrilla == EmpDB.numCuadrilla)
				{
					return true;
					//MessageBox.Show("El empleado esta en la base de datos.");
				}
				else
				{
					return false;
					//MessageBox.Show(emp.DecirDatos()+" no se encuentra en la base da datos. ");
				}
			}

		}

		void EmpleadoVerificado()
		{
			Empleado emp = new Empleado(txtNombreEmpleado.Text, txtApellidoEmpleado.Text, Convert.ToInt16(txtCuadrilla.Text), Convert.ToInt16(txtNroEmpleado.Text));

			if (VerificaEmpleado(emp) == true)
			{
				MessageBox.Show("El empleado esta en la base da datos.");
			}
			else
			{
				MessageBox.Show(emp.DecirDatos() + " no se encuentra en la base da datos.");
			}
		}

		bool VerificaCampos()
		{
			if (txtApellidoEmpleado.Text == "" | txtNombreEmpleado.Text == "" | txtCuadrilla.Text == "" | txtNroEmpleado.Text == "")
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		//procedimiento para modificar el estado del reclamo a "En proceso"

		void ModificarEstadoVehiculos(int idVehiculo)
		{
			con.Open(); //Abrir la coneccion
			string com = "UPDATE Vehiculos SET " +
				"Estado = @ESTADO WHERE Id = @ID";
			OleDbCommand cmd = new OleDbCommand(com, con);//Crear el comando
			cmd.Parameters.AddWithValue("@ESTADO", "No disponible");
			cmd.Parameters.AddWithValue("@PATENTE", idVehiculo);
			cmd.ExecuteNonQuery();//Ejecutar comando
			con.Close();
		}

		void ModificarEstadoCuadrilla(int IdCuadrilla)
		{
			con.Open(); //Abrir la coneccion
			string com = "UPDATE Cuadrillas SET " +
				"Estado = @ESTADO WHERE Id = @id";
			OleDbCommand cmd = new OleDbCommand(com, con);//Crear el comando
			cmd.Parameters.AddWithValue("@ESTADO", "No disponible");
			cmd.Parameters.AddWithValue("@id", IdCuadrilla);
			cmd.ExecuteNonQuery();//Ejecutar comando
			con.Close();
		}

		//Procedimmiento para sacar la id del vehiculo seleccionado
		private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dgv2.Rows[e.RowIndex].Selected = true;
			id = Convert.ToInt16(dgv2.Rows[e.RowIndex].Cells[0].Value);
		}


		//---------BOTONES----------

		//Para registrar que se esta atendiendo el reclamo
		private void button1_Click(object sender, EventArgs e)
		{
			if (VerificaCampos() == true)
			{
				EmpleadoVerificado();
				//ModificarEstadoReclamos();
				CargarHerramientas();

				fechaYhora = dateTimePicker1.Value.ToString();


				atencion_Reclamo.PersonalReclamoID = Convert.ToInt16(txtCuadrilla.Text);

				atencion_Reclamo.AgregarHerramientas(escalera, CajaHerramientas, transformador, poste, focos,
					llave, otro);

				atencion_Reclamo.fecha_y_hora = fechaYhora;
				atencion_Reclamo.CargarAtencion();
			}

		}

		//Para seleccionar un vehiculo
		private void button1_Click_1(object sender, EventArgs e)
		{
			if (id == 0)
			{
				MessageBox.Show("No se seleccionó ningun vehiculo");
			}
			else
			{

				atencion_Reclamo.AgregarVehiculo(id);

				ModificarEstadoVehiculos(id);

				if (checkCamioneta.Checked == true)
				{
					CargaDatosDgv2("UTILITARIO/B");

				}

				if (checkGrua.Checked == true)
				{
					CargaDatosDgv2("CARGA");
				}

				if (checkAuto.Checked == true)
				{
					CargaDatosDgv2("UTILITARIO/A");
				}

				MessageBox.Show("Vehiculo Seleccionado");
			}
		}

		//Para cerrar la ventana
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//Para verificar el empleado
		private void button2_Click_1(object sender, EventArgs e)
		{
			EmpleadoVerificado();
		}

		//Para borrar campos
		private void button3_Click(object sender, EventArgs e)
		{
			BorrarCampos();
		}

		//Para Seleccionar el personal extra
		private void button4_Click(object sender, EventArgs e)
		{
			if (comboBoxPersonalExtra.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccionar cuadrilla extra.");
			}
			else
			{
				string NombreDeCuadrilla = comboBoxPersonalExtra.SelectedItem.ToString();


				IdPersonalExtra = (BuscarId(comboBoxPersonalExtra.SelectedItem.ToString()));

				atencion_Reclamo.AgregarCuarilla(IdPersonalExtra);
				ModificarEstadoCuadrilla(IdPersonalExtra);

				checkPersonal.Checked = false;
				comboBoxPersonalExtra.Enabled = false;
			}
		}


		//-----PARTE GRAFICA-------

		//HERRAMIENTAS:
		//Checkbox para escalera
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{

			if (checkEscalera.Checked == true)
			{
				txtEscalera.ReadOnly = false;
			}
			else
			{
				txtEscalera.ReadOnly = true;
			}
		}
		//Checkbox para Caja de herramientas
		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			if (checkCajaHerramientas.Checked == true)
			{
				txtCajaHerramientas.ReadOnly = false;
			}
			else
			{
				txtCajaHerramientas.ReadOnly = true;
			}
		}
		//Checkbox para transformador
		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (checkTransformador.Checked == true)
			{
				txtTransformador.ReadOnly = false;
			}
			else
			{
				txtTransformador.ReadOnly = true;
			}
		}
		//Checkbox para poste
		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			if (checkPoste.Checked == true)
			{
				txtPoste.ReadOnly = false;
			}
			else
			{
				txtPoste.ReadOnly = true;
			}
		}
		//Checkbox para focos
		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			if (checkFocos.Checked == true)
			{
				txtFocos.ReadOnly = false;
			}
			else
			{
				txtFocos.ReadOnly = true;
			}
		}
		//Checkbox para llaves
		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{
			if (checkLlaves.Checked == true)
			{
				txtLlaves.ReadOnly = false;
			}
			else
			{
				txtLlaves.ReadOnly = true;
			}
		}
		//Checkbox para otros herramientas
		private void checkOtros_CheckedChanged(object sender, EventArgs e)
		{
			if (checkOtros.Checked == true)
			{
				txtOtros.ReadOnly = false;
			}
			else
			{
				txtOtros.ReadOnly = true;
			}
		}


		//VEHICULOS A USAR
		//Checkbox para autos
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkAuto.Checked == true)
			{
				CargaDatosDgv2("UTILITARIO/A");
				checkGrua.Checked = checkCamioneta.Checked = false;
			}
			else
			{

			}
		}
		//Checkbox para camionetas
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkCamioneta.Checked == true)
			{

				CargaDatosDgv2("UTILITARIO/B");
				checkAuto.Checked = checkGrua.Checked = false;
			}
			else
			{

			}

		}
		//Checkbox para gruas
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkGrua.Checked == true)
			{

				CargaDatosDgv2("CARGA");
				checkAuto.Checked = checkCamioneta.Checked = false;
			}
			else
			{

			}
		}

		//Checkbox para personal extra
		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{

			if (checkPersonal.Checked == true & VerificaCampos() == true)
			{
				Empleado emp = new Empleado(txtNombreEmpleado.Text, txtApellidoEmpleado.Text, Convert.ToInt16(txtCuadrilla.Text), Convert.ToInt16(txtNroEmpleado.Text));
				if (VerificaEmpleado(emp) == true)
				{
					comboBoxPersonalExtra.Enabled = true;
					CargaDatosCuarillasCombobox(emp.numCuadrilla);
				}
				else
				{
					MessageBox.Show("Verifique los datos del empleado.");
					checkPersonal.Checked = false;
				}

			}
			else
			{
				checkPersonal.Checked = false;
				comboBoxPersonalExtra.Enabled = false;
			}
		}


		//Conexion con la base da datos
		static string ruta = @"\BDT.mdb";
		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ruta; //Cadena de conexion con la base da datos
		static OleDbConnection con = new OleDbConnection(conex); //Objeto para conectarse la base da datos

	}
}
