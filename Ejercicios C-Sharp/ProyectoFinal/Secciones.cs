using System;
using System.Collections.Generic;

public class Secciones
{
    public List<Secciones> ListadeSecciones { get; set; }
    public int Seccion { get; set; }
    public string Horario { get; set; }
    public int Cupos { get; set; }
    public string Profesor { get; set; }


    public Secciones(int seccion, string horario, int cupos, string profesor)
    {
        Seccion = seccion;
        Horario = horario;
        Cupos = Cupos;
        Profesor = profesor;
        //
        ListadeSecciones = new List<Secciones>();
        MostrarSecciones();
    }

    private void MostrarSecciones()
    {
        ListadeSecciones = new List<Secciones>();
        Secciones s1 = new Secciones(0700, "LuMaMiJue");
    }




}
    