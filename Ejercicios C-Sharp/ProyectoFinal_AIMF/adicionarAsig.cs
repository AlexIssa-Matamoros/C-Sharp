using System;
using System.Collections.Generic;

public class AdicionarAsig
{

    public List<Departamentos> ListadeDepto { get; set; }
    public List<Asignaturas> ListadeAsignaturas { get; set; }
    public List<Secciones> ListadeSecciones { get; set; }
    public List<Alumno> Alum { get; set; }
    public List<AgregarAsig> ListadeMatricula { get; set; }
    public List<AgregarAsig> Cancelado { get; set; }
    
    public AdicionarAsig()
    
    {
        ListadeDepto = new List<Departamentos>();
        CargarDeptos();
        ListadeAsignaturas = new List<Asignaturas>();
        CargarAsig();
        ListadeSecciones = new List<Secciones>();
        CargarSecciones();
        Alum = new List<Alumno>();
        MirarAlum();

        ListadeMatricula = new List<AgregarAsig>();
        Cancelado = new List<AgregarAsig>();
    }

    private void MirarAlum()
    {
    
        Alumno a = new Alumno(20192001134, "Alex Issai Matamoros Fuentes",12345,"Informatica Administrativa");
        Alum.Add(a);
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
        Asignaturas A1 = new Asignaturas("01", "Intro a Informatica        ");
            ListadeAsignaturas.Add(A1);
        Asignaturas A2 = new Asignaturas("02", "Taller de Hardawe I        ");
            ListadeAsignaturas.Add(A2);
        Asignaturas A3 = new Asignaturas("03", "Metodologia de Programacion");
            ListadeAsignaturas.Add(A3);

    }
    private void CargarSecciones()
    {
            Secciones s1 = new Secciones("0700","07","08","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s1);
            Secciones s2 = new Secciones("0701","07","08","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s2);
            Secciones s3 = new Secciones("0800","08","09","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s3);
            Secciones s4 = new Secciones("0801","08","09","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s4);
            Secciones s5 = new Secciones("0900","09","10","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s5);
            Secciones s6 = new Secciones("0901","09","10","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s6);
            Secciones s7 = new Secciones("1000","10","11","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s7);
            Secciones s8 = new Secciones("1001","10","11","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s8);
            Secciones s9 = new Secciones("1100","11","12","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s9);
    }

    public void LiAlumnos()
    {

        foreach (var Al in Alum)
        {
            Console.WriteLine(Al.NumeroCuenta + "," + Al.Nombre + "," + Al.Carrera);
        }
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
    public void Login()
    {
        Console.Clear();
        Console.WriteLine("                             B I E N V E N I D O");
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine("");
        MenuPrincipal men = new MenuPrincipal();

        Console.Write("Numero de Cuenta: "); string Ncue = Console.ReadLine();
        Console.Write("Ingrese la contraseña: "); string con = Console.ReadLine();
        if (Ncue == "20192001134" && con == "1234")
        {
            Console.WriteLine("Datos Correctos, Presione ENTER para continuar...");
            Console.ReadKey();
            men.menu();
        } else{
            Console.WriteLine("Los datos no coinciden");
            return;
        }
        
    }
    ///////////////////////////////////////
    private void MovimientoCupos(string nseccion,string tipoMov)
    {
        foreach (var S in ListadeSecciones)
        {
            if (S.Seccion == nseccion)
            {
                if (tipoMov == "+")
                {
                    S.Cupos = S.Cupos + 1;
                } else {
                    S.Cupos = S.Cupos - 1;
                }
            }
        }
    }
    public void MatricularClase()
    {
        Console.Clear();
        Console.WriteLine("M a t r i c u l a");
        Console.WriteLine("-----------------");
       
        Console.Write("Ingrese el codigo del Departamento: ");
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

            Console.Write("Ingrese el codigo de la Asignatura: ");
            string codigoAs = Console.ReadLine();
            
            Asignaturas Asig = ListadeAsignaturas.Find(A => A.Codigo_Clase == codigoAs);
            //string numero = Console.ReadLine();
            //Alumno Al = Alum.Find(al => al.NumeroCuenta.ToString() == numero);
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


            //int Nmatricula = ListadeMatricula.Count + 1;
            //int Mmatricula = Cancelado.Count + 1;
            AgregarAsig Matri = new AgregarAsig(Depto, Asig);
            ListadeMatricula.Add(Matri);
        while (true)
        {  
            Console.Write("Ingrese la Seccion: ");
            string Secci = Console.ReadLine();
            Secciones secciones = ListadeSecciones.Find(s => s.Seccion == Secci);
            if (secciones ==  null)
            {
                Console.WriteLine("Seccion en lista de Espera");
                Console.ReadLine();
                return;
            } else{
                Console.WriteLine("Seccion Disponible: " + secciones.Seccion + "," + secciones.Horario + "," + secciones.Cupos + "," + secciones.Profesor);
                Matri.AgragarAsignatura(Asig,secciones);
                MovimientoCupos(Secci,"-");
                
            }
           
            Console.WriteLine("");
            Console.WriteLine("___________________________________________________________________________________________________");
            Console.WriteLine("La Asignaturas seleccionada es: " + Matri.SeccionesM);
            Console.ReadLine();
            return;
        }
            
    }

    ///////////////////////////// CANCELAR ASIGNATURA /////////////////////////

    public void Cancelar()
    {
        Console.Clear();
        Console.WriteLine("              C A N C E L A R    C L A S E              ");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("");
        Console.Write("Ingrese el codigo de la clase: ");
        string Codigoc = Console.ReadLine();
        Console.Write("Ingrese la seccion: ");
        string secc = Console.ReadLine();
        foreach (var C in ListadeMatricula)
        {
            if (C.CodigoClase == Codigoc)
            {
               ListadeMatricula.Remove(C);
               Console.WriteLine("Asignatura Cancelada: "+ C.CodigoClase + ", " + C.ParaNombre + ", " + C.ParaSecciones); 
               
            } if (C.ParaSecciones == secc)
            {
                MovimientoCupos(secc,"+");
                break;
            }
            
        }
        
        Console.ReadLine();
    }

    public void PreMatricula()
    {
        Console.Clear();
            Alumno j = new Alumno(20192001134, "Alex Issai Matamoros Fuentes", 1234,"Informatica Administrativa");
            Console.WriteLine("                           M A T R I C U L A                               ");
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Nombre:           "+ j.Nombre);
            Console.WriteLine("_________________________________________________________________________________");
            Console.WriteLine("Cod |          Asignatura       | Secc  | HI  | HF   | Horario    | Edificio    |");
            Console.WriteLine("____|___________________________|_______|_____|______|____________|_____________|");
        foreach (var Mat in ListadeMatricula)
        {
         
            Console.WriteLine(Mat.CodigoClase + "  |"+ Mat.ParaNombre +"|" + Mat.ParaSecciones + "   |" + Mat.HoraIni + "   |" + Mat.Horafi + "    |" + Mat.ParaHorario + "    |" + Mat.Edi + "   |");
        }
        Console.ReadLine();
    }


    ////////////////////
       public void Forma03()
    {
        Console.Clear();
            Alumno j = new Alumno(20192001134, "Alex Issai Matamoros Fuentes", 1234,"Informatica Administrativa");
            Console.WriteLine("                           M A T R I C U L A                               ");
            Console.WriteLine("================================================================================");
            Console.WriteLine("Nombre:           "+ j.Nombre + "             Carrera:" + j.Carrera);
            Console.WriteLine("Numero de Cuenta: "+j.NumeroCuenta);
            Console.WriteLine("_________________________________________________________________________________");
            Console.WriteLine("Cod |          Asignatura       | Secc  | HI  | HF   | Horario    | Edificio    |");
            Console.WriteLine("____|___________________________|_______|_____|______|____________|_____________|");
        foreach (var Mat in ListadeMatricula)
        {
            Console.WriteLine(Mat.CodigoClase + "  |"+ Mat.ParaNombre +"|" + Mat.ParaSecciones + "   |" + Mat.HoraIni + "   |" + Mat.Horafi + "    |" + Mat.ParaHorario + "    |" + Mat.Edi + "   |");
        }

        Console.ReadLine();     
    }

        
}
        


       
