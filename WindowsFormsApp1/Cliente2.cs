using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Cliente2 : Form
	{
		public Cliente2()
		{
			InitializeComponent();
		}

		//Conexion con la base da datos
		static string ruta = @"\BDT.mdb";

		static string conex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
			+ Application.StartupPath + ruta; //Cadena de conexion con la base da datos

		static OleDbConnection con = new OleDbConnection(conex); //Objeto para conectarse la base da datos

		string fechaYhora;

		//METODOS:

		// para verificar la existencia de un cliente
		public int VerificaCliente(Cliente cli)
		{

			//Buscar el Cliente en la Base de Datos
			con.Open();

			OleDbCommand com = new OleDbCommand("SELECT Id,Nombre,Apellido FROM Clientes WHERE Id=@ID", con);
			com.Parameters.AddWithValue("@Id", cli.nroCliente);//Pasar al objeto comando los parametros
			com.ExecuteNonQuery();//Ejecutar el comando

			OleDbDataAdapter da = new OleDbDataAdapter(com);//Intermediario entre el DataTable y la Base datos

			DataTable dt = new DataTable();

			da.Fill(dt);//Llenar la tabla con los datos

			con.Close();

			if (dt.Rows.Count == 0)
			{
				return 0;
				//lblVerificar.Text = "Verifique los campos Ingresados.";
			}
			else
			{
				DataRow dataRow = dt.Rows[0];//Almacena una fila de un DataTable

				Cliente CliBD = new Cliente(dataRow["Nombre"].ToString(), dataRow["Apellido"].ToString(), cli.nroCliente);

				if (cli.nombre == CliBD.nombre & cli.apellido == CliBD.apellido)
				{
					return 1;
					//MessageBox.Show("El Cliente esta en la base de datos.");
				}
				else
				{
					return 0;
					//MessageBox.Show(cli.DecirDatos() + " no se encuentra en la base de datos. ");
				}
			}

		}

		//Para borrar los campos de ls textbox
		public void BorarTextBox()
		{
			txtNombre.Text = "";
			txtApe.Text = "";
			txtCalle.Text = "";
			txtCorreo.Text = "";
			txtPiso.Text = "";
			txtNroCliente.Text = "";
			txtAltura.Text = "";
			txtObs.Text = "";
		}

		//Genera el numero de reclamos a partir dal actual nro de reclamos
		Int16 GeneraNroReclamo()
		{
			con.Open();//Abrir la coneccion

			//Generamos el numero de reclamos
			OleDbCommand com = new OleDbCommand("SELECT * FROM Reclamos", con);
			OleDbDataAdapter da = new OleDbDataAdapter(com);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();//Cerrar la coeccion

			Int16 actual = Convert.ToInt16(dt.Rows.Count);
			actual++;

			return actual;
		}

		//Verifica que los campos nombre, apellido e id no esten vacios;
		bool VerificaCamposCliente()
		{
			if (txtApe.Text != "" & txtNroCliente.Text != "" & txtNombre.Text != "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		//BOTONES

		//Para confirmar reclamo
		private void button1_Click(object sender, EventArgs e)
		{
			Cliente cli;

			if (VerificaCamposCliente() == true)
			{
				cli = new Cliente(txtNombre.Text, txtApe.Text, Convert.ToInt16(txtNroCliente.Text));

				if (VerificaCliente(cli) == 1)//Si el cliente esta en la BD
				{
					if (txtPiso.Text != "" & txtCalle.Text != "" & txtAltura.Text != "")
					{


						if (checkTelefono.Checked == true)
						{
							cli.telefono = Convert.ToInt32(txtTelefono.Text);
						}
						else
						{
							cli.telefono = 0;
						}

						if (checkCorreo.Checked == true)
						{
							cli.correo = txtCorreo.Text;
						}
						else
						{
							cli.correo = "-";
						}

						string obs;

						if (txtObs.Text != "")
						{
							obs = txtObs.Text;
						}
						else
						{
							obs = "-";
						}

						if (cmbTipo.SelectedIndex == -1)
						{
							MessageBox.Show("El campo Tipo de reclamo es obligatorio");
						}
						else
						{
							fechaYhora = dateTimePicker1.Value.ToString();
							Reclamo rec = new Reclamo(cmbTipo.SelectedItem.ToString(), obs, cli, GeneraNroReclamo(),
								fechaYhora, txtCalle.Text, Convert.ToInt16(txtAltura.Text), Convert.ToInt16(txtPiso.Text));
							rec.Insertar();
						}
					}
					else
					{
						MessageBox.Show("Los campos: Piso, Altura y calle son obligatorios.");
					}

				}
				else
				{
					MessageBox.Show("Solo los clientes pueden ingresar reclamos.");
				}

			}
			else
			{
				MessageBox.Show("Los campos: Nombre, Apellido y Numero de cliente son obligatorios.");
			}
		}
		//Para cerrar ventana
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//Para limpiar campos
		private void button3_Click(object sender, EventArgs e)
		{
			BorarTextBox();
		}
		//Para verificar clientes
		private void btnVerificar_Click(object sender, EventArgs e)
		{
			if (VerificaCamposCliente() == false)
			{
				MessageBox.Show("Ingrese Nombre,Apellido y Nro de CLiente.");
			}
			else
			{
				Cliente cli = new Cliente(txtNombre.Text, txtApe.Text, Convert.ToInt16(txtNroCliente.Text));

				if (VerificaCliente(cli) == 1) //Si el cliente esta
				{
					MessageBox.Show("El Cliente esta en la base de datos.");
				}
				else
				{
					MessageBox.Show(cli.DecirDatos() + " no se encuentra en la base de datos. ");
				}
			}
		}


		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkTelefono.Checked == true)
			{
				txtTelefono.ReadOnly = false;
			}
			else
			{
				txtTelefono.ReadOnly = true;
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkCorreo.Checked == true)
			{
				txtCorreo.ReadOnly = false;
			}
			else
			{
				txtCorreo.ReadOnly = true;
			}
		}
	}
}
