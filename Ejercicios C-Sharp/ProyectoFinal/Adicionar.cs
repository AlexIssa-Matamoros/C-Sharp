using System;
using System.Collections.Generic;

    public class Adiciones
    {
        public List<Departamento> ListadeDepto { get; set; }
        public Adiciones()
        {
            ListadeDepto = new List<Departamento>();

            Departamento d1 = new Departamento("1 - INFORMATICA ADMINISTRATIVA");
            Departamento d2 = new Departamento("2 - HISTORIA");
            Departamento d3 = new Departamento("3 - CULTURA FISICA Y DEPORTES");
            Departamento d4 = new Departamento("4 - LENGUAS EXTRANJERAS");
            Departamento d5 = new Departamento("5 - FILOSOFIA");
            Departamento d6 = new Departamento("6 - ARTE");

            ListadeDepto.Add(d1);
            ListadeDepto.Add(d2);
            ListadeDepto.Add(d3);
            ListadeDepto.Add(d4);
            ListadeDepto.Add(d5);
            ListadeDepto.Add(d6);
        }


    public void DEPART()
    {
        
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("DEPARTAMENTOS");
            Console.WriteLine("---------------------------");

            foreach (var D in ListadeDepto)
            {
                Console.WriteLine(D.NombreDepto);
                
            }
            Console.ReadLine();
            Console.WriteLine("ENTER - Salir");
            Console.WriteLine("");
            Console.WriteLine("* Seleccione un departamento *");

            
            Asignaturas Asi = new Asignaturas();
            Adiciones adi = new Adiciones();
            MENU Me = new MENU();
            string a = "";
         while (true)
         {
            a = Console.ReadLine();
            switch (a)
                {
                case "1":
                   Asi.ListarAsignaturas();
                    break;
                case "2":
                    Asi.ListarAsignaturas();
                    break;
                case "3":
                    Asi.ListarAsignaturas();
                    break;
                case "0":
                    break;
                }
                if (a.ToLower() == "0")
                {
                    break;
                }
        } 

    }

}