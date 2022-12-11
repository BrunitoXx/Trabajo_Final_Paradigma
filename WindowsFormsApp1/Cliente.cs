using System;

namespace WindowsFormsApp1
{
	public class Cliente : Persona
	{
		//Atributos

		public String barrio;
		public String calle;
		public Int16 piso;
		public Int16 altura;
		public Int16 codigop;
		public Int32 telefono;
		public String correo;
		public Int16 nroCliente;

		//Metodos
		public Cliente()
		{

		}

		public Cliente(String nomb, String ape, Int16 numCliente) : base(nomb, ape)
		{
			nroCliente = numCliente;
		}

		public Cliente(String nomb, String ape, String calle1, Int16 piso1, Int16 alt, String dom,
			String barr, Int16 cod, Int16 nro, Int32 telf, string corr) : base(nomb, ape)
		{

			//dni = DNI;
			calle = calle1;
			piso = piso1;
			altura = alt;
			barrio = barr;
			codigop = cod;
			nroCliente = nro;
			telefono = telf;
			correo = corr;

		}

		public override string DecirDatos()
		{
			return "Cliente N°: " + nroCliente.ToString() + ", " + base.DecirDatos();
		}
	}
}
