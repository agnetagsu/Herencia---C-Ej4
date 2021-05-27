using System;

namespace Herencia___C_Ej4
{
    class program
    {
        
        static void Main(string[] args)
        { 
            int preciolavadoras = 0;
            int precioelectrodomesticos = 0;
            int preciotelevisiones = 0;
            Lavadora milavadora = new Lavadora();
            television mitelevision = new television();
            Electrodomestico mielectro = new Electrodomestico();


            Electrodomestico[] electro = new Electrodomestico[10];
            electro[0] = new Electrodomestico(120, "negro", 'A', 20);
            electro[1] = new Lavadora(90, "azul", 'B', 30, 4);
            electro[2] = new Lavadora(80, "rojo", 'C', 10, 3);
            electro[3] = new Lavadora(110, 15);
            electro[4] = new Lavadora(100, "negro", 'E', 20, 6);
            electro[5] = new Electrodomestico(200, "gris", 'E', 15);
            electro[6] = new television(250, "negro", 'D', 30, 30, false);
            electro[7] = new television(350, "negro", 'E', 30, 30, true);
            electro[8] = new television(400, "azul", 'B', 35, 43, false);
            electro[9] = new television(500, "negro", 'A', 45, 55, true);

            for ( int i = 0; i < electro.Length; i++)
            {
                if (electro[i].GetType() == milavadora.GetType())
                {
                    precioelectrodomesticos = precioelectrodomesticos + electro[i].precioFinal();
                    preciolavadoras = preciolavadoras + electro[i].precioFinal();
                }
                else
                {
                    if (electro[i].GetType() == mitelevision.GetType())
                    {
                        precioelectrodomesticos = precioelectrodomesticos + electro[i].precioFinal();
                        preciotelevisiones = preciotelevisiones + electro[i].precioFinal();
                    }
                    else
                    {
                        precioelectrodomesticos = precioelectrodomesticos + electro[i].precioFinal();
                    }
                        
                }
            }

            System.Console.WriteLine("El resultado final será: {0} de electrodomesticos, {1} de lavadoras, {2} de televisiones", precioelectrodomesticos, preciolavadoras, preciotelevisiones);

        }
    }
}
