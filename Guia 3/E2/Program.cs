﻿using System;
using System.Collections.Generic;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Contratistas> contratistas= new List<Contratistas>();
          Pintores pintor1 = new Pintores(); 
          Pintores pintor2 = new Pintores(); 
          Pintores pintor3 = new Pintores(); 
          Pintores pintor4 = new Pintores(); 
          Pintores pintor5 = new Pintores(); 
          contratistas.Add(pintor1);
          contratistas.Add(pintor2);
          contratistas.Add(pintor3);
          contratistas.Add(pintor4);
          contratistas.Add(pintor5);
          Plomeros plomero1 = new Plomeros();
          Plomeros plomero2 = new Plomeros();
          Plomeros plomero3 = new Plomeros();
          Plomeros plomero4 = new Plomeros();
          Plomeros plomero5 = new Plomeros();
          contratistas.Add(plomero1);
          contratistas.Add(plomero2);
          contratistas.Add(plomero3);
          contratistas.Add(plomero4);
          contratistas.Add(plomero5);
          Albañiles albañil1 = new Albañiles(22,"MMO");
          Albañiles albañil2 = new Albañiles(28,"Cementista");
          Albañiles albañil3 = new Albañiles(35,"MMO");
          Albañiles albañil4 = new Albañiles(49,"Yesero");
          Albañiles albañil5 = new Albañiles(52,"Techista");
          contratistas.Add(albañil1);
          contratistas.Add(albañil2);
          contratistas.Add(albañil3);
          contratistas.Add(albañil4);
          contratistas.Add(albañil5);
          
          int presupuesto;
          int horasaTrabajarParaTerminar;

          Console.WriteLine("Ingrese las horas a trabajar y el presupuesto para la realizacion del edificio");
          presupuesto=Int32.Parse(Console.ReadLine());
          horasaTrabajarParaTerminar=Int32.Parse(Console.ReadLine());
          Constructora constructora= new Constructora(presupuesto, horasaTrabajarParaTerminar, contratistas);
          Console.WriteLine("El presupuesto alcanza?\n"+constructora.ElPresupuestoAlcanza());
        }
    }
}
