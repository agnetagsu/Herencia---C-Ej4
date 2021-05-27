using System;

namespace Herencia___C_Ej4
{
	class television : Electrodomestico
	{
		public int resolucion { get; set; }
		const int resolucionpordefecto = 20;
		Boolean TDT { get; set; }
		Boolean TDTpordefecto = false;

		
		
		public television() : base()
		{
			resolucion = resolucionpordefecto;
			TDT = TDTpordefecto;

		}
		public television(int lpreciobase, int lpeso) : base(lpreciobase, lpeso)
		{
			resolucion = resolucionpordefecto;
			TDT = TDTpordefecto;
		}
		public television(int lpreciobase, string lcolor, char lconsumoenergetico, int lpeso, int lresolucion, Boolean lTDT) : base(lpreciobase, lcolor, lconsumoenergetico, lpeso)
		{
			resolucion = lresolucion;
			TDT = lTDT;
		}
		public int precioFinal()
		{
			int precio = base.precioFinal();

			if (this.resolucion > 40)
			{
				precio = precio * (1 + 30/100);
			}
			if (this.TDT == true)
			{
				precio = precio + 50;
			}
			return precio;

		}

	}
}
