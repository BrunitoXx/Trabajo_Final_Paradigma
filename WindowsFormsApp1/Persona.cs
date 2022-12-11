using System;

namespace WindowsFormsApp1
{
	public class Persona
	{
		//Atributos

		public String nombre;
		public String apellido;
		public Int32 dni;

		//Metodos
		public Persona()
		{

		}

		public Persona(String nomb, String ape)
		{
			nombre = nomb;
			apellido = ape;
		}

		public Persona(String nomb, String ape, Int32 dni1)
		{
			nombre = nomb;
			apellido = ape;
			dni = dni1;
		}

		//polimorfismo con empleado en linea 27
		public virtual string DecirDatos()
		{
			string datos;
			datos = apellido + ", " + nombre;
			return datos;
		}
	}
}
