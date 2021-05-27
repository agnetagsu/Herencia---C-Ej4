using System;

namespace Herencia___C_Ej4
{
    public class Electrodomestico
    {
        private decimal _preciobase;
        private string _color; 
        private char _consumoenergetico;
        private int _peso;

        public const char F = 'F';
        public const decimal preciopordefecto = 100;
        public const string colorpordefecto = "blanco";
        public const int pesopordefecto = 5;

        public string color
        {
            get { return _color; }
            set { _color = value; }
        }
        public decimal preciobase
        {
            get { return _preciobase; }
            set { _preciobase = value; }
        }
        public char consumoenergetico
        {
            get { return _consumoenergetico; }
            set { _consumoenergetico = value; }
        }
        public int peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public Electrodomestico()
        {
            preciobase = preciopordefecto;
            color = colorpordefecto;
            consumoenergetico = F;
            peso = pesopordefecto;
            

        }
        public Electrodomestico(decimal precio, int npeso)
        {
            preciobase = precio;
            color = colorpordefecto;
            consumoenergetico = F;
            peso = npeso;
        }

        public Electrodomestico(decimal precio, string ncolor, char nconsumoenergetico, int npeso)
        {
            preciobase = precio;
            peso = npeso;
            comprobarConsumoEnergetico(nconsumoenergetico);
            comprobarColor(ncolor);
        }

        private void comprobarConsumoEnergetico(char letra)
        {//letras permitidos ABCDEF
            if((letra!='A')& (letra != 'B')& (letra != 'C')& (letra != 'D')& (letra != 'E')& (letra != 'F'))
            {
                this.consumoenergetico = F;
            }
            else
            {
                this.consumoenergetico = letra;
            }

        }
        private void comprobarColor(String color)
        {//colores permitidos blanco, negro, rojo, azul y gris (en mayúsculas y minúsculas)
            if((color != "blanco")& (color != "BLANCO")& (color != "NEGRO")& (color != "negro")& (color != "rojo")& (color != "ROJO")& (color != "AZUL")& (color != "azul")& (color != "gris")& (color != "GRIS"))
            {
                this.color = colorpordefecto;
            }
            else
            {
                this.color = color;
            }
        }
        public int precioFinal()
        {
            int precioadicional = 0;

            switch (this.consumoenergetico){
                case 'A':

                    precioadicional = precioadicional + 100;
                    break;
                case 'B':

                    precioadicional = precioadicional + 80;
                    break;
                case 'C':

                    precioadicional = precioadicional + 60;
                    break;
                case 'D':

                    precioadicional = precioadicional + 50;
                    break;
                case 'E':

                    precioadicional = precioadicional + 30;
                    break;
                case 'F':

                    precioadicional = precioadicional + 10;
                    break;

            }

            if (this.peso<=19)
            {
                precioadicional = precioadicional + 10;
            }
            else
            {
                if((this.peso >20) & (this.peso <= 49)){
                    precioadicional = precioadicional + 50;
                }
                else
                {
                    if((this.peso > 50)&(this.peso <=79))
                    {
                        precioadicional = precioadicional + 80;
                    }
                    else
                    {
                        precioadicional = precioadicional + 100;
                    }
                }
            }


            return precioadicional+this.peso;

        }

    }
}

