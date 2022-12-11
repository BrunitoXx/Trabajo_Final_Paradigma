using System;

namespace WindowsFormsApp1
{
	class Camioneta
	{
		//Atributos

		String marca;
		String modelo;
		String tipo;
		String color;
		String capacidad_carga;

		//Metodos

		public Camioneta()
		{

		}

		public Camioneta(String marc, String mod, String tip, String col, String cdc)
		{
			marca = marc;
			modelo = mod;
			tipo = tip;
			color = col;
			capacidad_carga = cdc;
		}
	}
}
