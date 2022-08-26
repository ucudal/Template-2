//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------
//Encontrarás una clase Train, crea una variable de clase que te permitirá acumular 
//la cantidad de instancias creadas. Una 
//variable de clase la definimos, por ejemplo de la siguiente forma (presta atención al modificador static):
using System;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase representa un tren muy básico.
    /// </summary>
    public class Train
    {
        /// <summary>cd
        /// Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        /// </summary>
        /// <value><c>true</c> si las máquinas fueron encendidas, <c>false</c> en caso contrario.</value>
        public bool IsEngineStarted { get; private set; }

        /// <summary>
        /// Enciende las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser encendidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        /// <summary>
        /// Detiene las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser detenidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }
        public static int Count = 0;
        public string Identificador { get; set;}
        public static int AddCounter(){
            return ++Count;
        }
         public static int returnCounter(){
            return Count;
        }
        public Train(string identificador)
        {
        this.Identificador = identificador;
        AddCounter();
        }
        
         ~Train()
        {
            --Count;
            Console.WriteLine("Destructor se ejecutó");
        } 
        public override string ToString(){
            return  $"Identificador {this.Identificador}\nContador de instancias {returnCounter()}";
        }



    }
}