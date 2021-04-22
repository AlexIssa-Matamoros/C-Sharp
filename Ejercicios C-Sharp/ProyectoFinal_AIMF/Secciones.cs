using System;

public class Secciones
{
    public int Seccion { get; set; }
    public string Profesor { get; set; }
    public string Horario { get; set; }
    public int Cupos { get; set; }
    public int HI { get; set; }
    public int HF { get; set; }
    public string Edificio { get; set; }

    public Secciones(int seccion, int Hi, int Hf, string horario, string edificio, int cupos, string profesor)
    {
        Seccion = seccion;
        HI = Hi;
        HF = Hf;
        Edificio = edificio;
        Profesor = profesor;
        Horario = horario;
        Cupos = cupos;
    }
}