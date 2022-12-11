using System;

namespace WindowsFormsApp1
{
	class Automovil : Vehiculo
	{
		//Atributos

		String marca;
		String modelo;
		String tipo;
		String color;
		String capacidad_carga;

		//Metodos

		public Automovil()
		{

		}

		public Automovil(String marc, String mod, String tip, String col, String cdc)
		{
			marca = marc;
			modelo = mod;
			tipo = tip;
			color = col;
			capacidad_carga = cdc;
		}
	}
}
