using System;

namespace WindowsFormsApp1
{
	public class Empleado : Persona
	{
		//Atributos

		public Int16 numempleado;
		public Int16 numCuadrilla;

		//Metodos

		public Empleado()
		{

		}

		public Empleado(String Nombre, String Apellido, Int16 nroCuadrilla, Int16 nroEmpleado)
		{
			nombre = Nombre;
			apellido = Apellido;
			numCuadrilla = nroCuadrilla;
			numempleado = nroEmpleado;

		}

		//polimorfismo con persona en linea 32
		public override string DecirDatos()
		{
			string datos = "Empleado N° " + numempleado.ToString() + " de la Cuadrilla " + numCuadrilla.ToString() + ", " + base.DecirDatos();
			return datos;
		}
	}
}
