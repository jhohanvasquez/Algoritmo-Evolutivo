namespace Algoritmo.Evolutivo.Consola
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {

        #region constantes

        const string CadenaB = "ESTO ES UN ALGORITMO EVOLUTIVO";
        const string posibles = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";

        #endregion

        #region funciones

        /// <summary>
        /// Crea caracteres aleatorios con una longitud expecificada
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string CrearCaracter(int length)
        {
            Random obj = new Random();
            int longitud = posibles.Length;
            char letra;
            int longitudnuevacadena = 1;
            string nuevacadena = "";
            for (int i = 0; i < longitudnuevacadena; i++)
            {
                letra = posibles[obj.Next(longitud)];
                nuevacadena += letra.ToString();
            }
            return nuevacadena;
        }

        /// <summary>
        /// Calificar la cadena generada
        /// </summary>
        /// <param name="cadenaA"></param>
        /// <returns></returns>
        public static int CalificarCadena(string cadenaA)
        {
            var resultado = 0;
            var oCaracterA = cadenaA.ToCharArray();
            var oCaracterB = CadenaB.ToCharArray();
            for (int i = 0; i < oCaracterA.Length; i++)
            {
                if (oCaracterA[i].Equals(oCaracterB[i]))
                {
                    resultado++;
                }
            }

            return resultado;

        }

        #endregion 

        static void Main(string[] args)
        {
            var data = "RFXLIYGKDOUIWJKPIJAZAPSSNIPHYT";
            var index = 0;
            var mayorPuntaje = 0;
            var cadenaMayor = string.Empty;
            while (mayorPuntaje < 30)
            {
                for (int x = 0; x < 100; x++)
                {
                    var miLista = new List<WeightedItem<string>>();
                    for (int i = 0; i < data.Length; i++)
                    {
                        WeightedItem<string> oItem = new WeightedItem<string>(i.ToString(), 1.5);
                        miLista.Add(oItem);
                    }
                    var posicion = Convert.ToInt32(WeightedItem<string>.Choose(miLista));
                    var newCaracter = CrearCaracter(1);
                    data = data.Remove(posicion, 1).Insert(posicion, newCaracter);
                    var auxPuntaje = CalificarCadena(data);
                    if (mayorPuntaje < auxPuntaje)
                    {
                        mayorPuntaje = auxPuntaje;
                        cadenaMayor = data;
                    }
                    Console.WriteLine($"Generación:{index++} - Mutación: {data} - Puntaje: {CalificarCadena(data)}");
                }
                data = cadenaMayor;
            }
            Console.WriteLine($"Generación:{index++} - Mutación: {data} - Puntaje: {CalificarCadena(data)}");
            Console.ReadKey();
        }
    }
}
