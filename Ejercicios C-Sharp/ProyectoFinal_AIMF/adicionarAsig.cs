using System;
using System.Collections.Generic;

public class AdicionarAsig
{

    public List<Departamentos> ListadeDepto { get; set; }
    public List<Asignaturas> ListadeAsignaturas { get; set; }
    public List<Secciones> ListadeSecciones { get; set; }

    public List<AgregarAsig> ListadeMatricula { get; set; }
    public AdicionarAsig()
    {
        ListadeDepto = new List<Departamentos>();
        CargarDeptos();
        ListadeAsignaturas = new List<Asignaturas>();
        CargarAsig();
        ListadeSecciones = new List<Secciones>();
        CargarSecciones();

        ListadeMatricula = new List<AgregarAsig>();
    }

    private void CargarDeptos()
    {
        Departamentos D1 = new Departamentos(01, "Informatica Adiministrativa");
            ListadeDepto.Add(D1);
        Departamentos D2 = new Departamentos(02, "Contaduria");
            ListadeDepto.Add(D2);
        Departamentos D3 = new Departamentos(02, "Historia");
            ListadeDepto.Add(D3);

    }

    private void CargarAsig()
    {
        Asignaturas A1 = new Asignaturas(01, "Introduccion a Informatica");
            ListadeAsignaturas.Add(A1);
        Asignaturas A2 = new Asignaturas(02, "Taller de Hardawe I");
            ListadeAsignaturas.Add(A2);
        Asignaturas A3 = new Asignaturas(03, "Metodologia de Programacion");
            ListadeAsignaturas.Add(A3);

    }
    private void CargarSecciones()
    {
            Secciones s1 = new Secciones(0700,"LuMaMiJu",30, "Bily Fernandez");
        ListadeSecciones.Add(s1);
            Secciones s2 = new Secciones(0701,"LuMaMiJu",30, "Bily Fernandez");
        ListadeSecciones.Add(s2);
            Secciones s3 = new Secciones(0800,"LuMaMiJu",30, "Bily Fernandez");
        ListadeSecciones.Add(s3);
            Secciones s4 = new Secciones(0801,"LuMaMiJu",30, "Bily Fernandez");
        ListadeSecciones.Add(s4);
            Secciones s5 = new Secciones(0900,"LuMaMiJu",30, "Bily Fernandez");
        ListadeSecciones.Add(s5);
            Secciones s6 = new Secciones(0901,"LuMaMiJu",30, "Bily Fernandez");
        ListadeSecciones.Add(s6);
            Secciones s7 = new Secciones(1000,"LuMaMiJu",30, "Bily Fernandez");
        ListadeSecciones.Add(s7);
            Secciones s8 = new Secciones(1001,"LuMaMiJu",30, "Bily Fernandez");
        ListadeSecciones.Add(s8);
            Secciones s9 = new Secciones(1100,"LuMaMiJu",30, "Bily Fernandez");
        ListadeSecciones.Add(s9);
    }

    public void MostrarDepto()
    {
        Console.Clear();
        Console.WriteLine("DEPARTAMENTOS");
        Console.WriteLine("");

        foreach (var De in ListadeDepto)
        {
            Console.WriteLine(De.Codigo + " | " + De.Nombre_Dep);
        }
        Console.ReadLine();
    }

    public void MostrarAsig()
    {
        Console.Clear();
        Console.WriteLine("ASIGNATURAS");
       

        foreach (var As in ListadeAsignaturas)
        {
            Console.WriteLine(As.Codigo_Clase + " | " + As.Clase);
        }
        Console.ReadLine(); 
    }

    public void MostrarSecc()
    {
        Console.Clear();
        Console.WriteLine("SECCIONES");
       

        foreach (var Se in ListadeSecciones)
        {
            Console.WriteLine(Se.Seccion + " | " + Se.Horario + " | " + Se.Cupos + " | " + Se.Profesor);
        }
        Console.ReadLine(); 
    }
    //////////////////////////////////////
    public void MatricularClase()
    {
        Console.Clear();
        Console.WriteLine("M a t r i c u l a");
        Console.WriteLine("-----------------");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del Departamento: ");
        string codigoDe = Console.ReadLine();
        Departamentos Depto = ListadeDepto.Find(a => a.Codigo.ToString() == codigoDe);
        if (Depto == null)
        {
            Console.WriteLine("Parece que no existe ese Departamento");
            Console.ReadLine();
            return;
        }
        else{
            Console.WriteLine("Departamento: " + Depto.Nombre_Dep);
            Console.WriteLine("");
        }

            Console.WriteLine("Ingrese el codigo de la Asignatura: ");
            string codigoAs = Console.ReadLine();
            Asignaturas Asig = ListadeAsignaturas.Find(A => A.Codigo_Clase.ToString() == codigoAs);
            if (Asig == null)
            {
                Console.WriteLine("Parece que no existe esta Asignatura");
                Console.ReadLine();
                return;
            } 
            else
            {
                Console.WriteLine("Asignatura Agragada: " + Asig.Clase);
                Console.WriteLine("");

            }


            int Nmatricula = ListadeMatricula.Count + 1;
            AgregarAsig Matri = new AgregarAsig(Nmatricula,de);
            ListadeMatricula.Add(Matri);
        while (true)
        {  
            Console.WriteLine("Ingrese la Seccion: ");
            string Secci = Console.ReadLine();
            Secciones secciones = ListadeSecciones.Find(s => s.Seccion.ToString()== Secci);
            if (secciones ==  null)
            {
                Console.WriteLine("Seccion en lista de Espera");
                Console.ReadLine();
            } else{
                Console.WriteLine("Seccion Disponible: " + secciones.Seccion + "," + secciones.Horario + "," + secciones.Cupos + "," + secciones.Profesor);
                Matri.AgragarAsignatura(secciones);
            }

            Console.WriteLine("Desea buscar otra seccion? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }
        //agregar la clase matriculada
        
    }
        

}
       
