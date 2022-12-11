using System.Collections.Generic;

namespace WindowsFormsApp1
{
	class Cuadrilla
	{
		//Atributos
		int nroCuadrilla;
		List<Empleado> Empleados = new List<Empleado>();

		public Cuadrilla()
		{

		}

		public Cuadrilla(int Cuadrilla, List<Empleado> emp)
		{
			nroCuadrilla = Cuadrilla;
			Empleados = emp;
		}

		void MostarEmpleados()
		{
			string Empleadoss = " ";

			foreach (var emp in Empleados)
			{
				Empleadoss = Empleadoss + emp.DecirDatos();
			}

		}

	}
}
