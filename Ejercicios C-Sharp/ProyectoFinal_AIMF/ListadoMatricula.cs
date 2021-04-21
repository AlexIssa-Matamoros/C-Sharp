using System;

public class ListadoMatricula
{
    public Departamentos Departamento { get; set; }
    public int Num { get; set; }
    public Asignaturas Asignat { get; set; }
    public Secciones secci { get; set; }
    public string Clase { get; set; }
    public string Horario { get; set; }
    public int Cupos { get; set; }
    public string Profe { get; set; }

    public ListadoMatricula(int num, Asignaturas Asignat, Secciones secci)
    {
        Clase = Asignat.Clase;
        Num = num;
        Horario = secci.Horario;
        Cupos = secci.Cupos;
        Profe = secci.Profesor;
    }

}