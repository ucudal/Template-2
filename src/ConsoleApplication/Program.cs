//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("Número 1");
            var train2= new Train("Número 2");
            var train3= new Train("Número 3");

            train.StartEngines();
            Console.WriteLine(train);
            Console.WriteLine(train2);
            Console.WriteLine(train3);
            Console.WriteLine(Train.Count);
        }
    }
}