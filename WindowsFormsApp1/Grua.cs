using System;

namespace WindowsFormsApp1
{
	class Grua : Automovil
	{
		//Atributos

		String elemento;
		String capacidad_elemento;

		//Metodos

		public Grua()
		{

		}

		public Grua(String elem, String cde)
		{
			elemento = elem;
			capacidad_elemento = cde;
		}

	}
}
