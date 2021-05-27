using System;

namespace Herencia___C_Ej4
{
	class Lavadora : Electrodomestico
	{
		public int _carga;
		const int cargapordefecto = 5;

		public int carga
        {
            get { return _carga; }
			set { _carga = value; }
        }
		public Lavadora() : base()
        {
			carga = cargapordefecto;

		}
		public Lavadora(int lpreciobase, int lpeso) : base(lpreciobase, lpeso)
		{
			carga = cargapordefecto;
		}
		public Lavadora(int lpreciobase, string lcolor, char lconsumoenergetico, int lpeso, int lcarga) : base(lpreciobase, lcolor, lconsumoenergetico, lpeso)
        {
			carga = lcarga;
        }
		public int precioFinal()
        {

			if(this.carga > 30)
            {
				return base.precioFinal()+50;
			}
            else
            {
				return base.precioFinal();

			}
			
        }
		
	}
}
