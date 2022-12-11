using System;

namespace WindowsFormsApp1
{
	public class Vehiculo
	{
		//Atributos 

		String tipocombustible;
		String patente;
		Int32 numero_chasis;
		double motor;

		//Metodos

		public Vehiculo()
		{

		}

		public Vehiculo(String tipcomb, String pat, int mot, Int32 nmrc)
		{
			tipocombustible = tipcomb;
			patente = pat;
			numero_chasis = nmrc;
			motor = mot;
		}
	}



}
