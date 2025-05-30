namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declarar vector y variables
            int cont;
            int[] numeros;
            int valor;
            int acum;
            int mayor;
            int posicionM;
            int menor;
            int posicionMe;
            double prom;
            #endregion

            #region definir vector
            numeros = new int[100];
            #endregion

            #region cargaDeValores e inicializar variables
            Console.WriteLine("Ingrese el valor(-1 para terminar carga)");
            valor = Convert.ToInt32(Console.ReadLine());
            cont = 0;
            acum = 0;
            mayor = 0;
            menor = 0;
            posicionM = 0;
            posicionMe = 0;


            while (valor != -1)
            {

                numeros[cont] = valor;
                cont++;

                Console.WriteLine("Ingrese el valor(-1 para terminar carga)");
                valor = Convert.ToInt32(Console.ReadLine());

            }
            #endregion

            #region Recorremos los valores del vector
            for (int n = 0; n < cont; n++)
            {
                //mostramos los valores del vector
                Console.Write($"{n,3}:{numeros[n]}");
                //acumulamos los valores del vector
                acum = acum + numeros[n];
                //conseguimos el mayor valor del vector
                if (n == 0)
                {
                    mayor = numeros[n];
                    posicionM = n;
                    menor = numeros[n];
                    posicionMe = n;
                }
                else
                {
                    if (mayor < numeros[n])
                    {
                        mayor = numeros[n];
                        posicionM = n;
                    }
                    if (menor > numeros[n])
                    {
                        menor = numeros[n];
                        posicionMe = n;
                    }
                }
            }
            #endregion
            #region calcular promedio
            if (cont > 0)
            {
                prom = 1.0 * acum / cont;
                Console.WriteLine($"\n promedio={prom}");
            }
            else
            {
                Console.WriteLine("No hay valores en el vector");
            }
            #endregion
            Console.WriteLine($"El mayor numero del vector (indice:número) es {posicionM}:{mayor}, el menor numero es {posicionMe}:{menor}");
            Console.ReadKey();
        }
    }
}
