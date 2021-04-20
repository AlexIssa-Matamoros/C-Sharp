using System;
using System.Collections.Generic;

public class AdicionarAsig
{

    public List<Departamentos> ListadeDepto { get; set; }
    public List<Asignaturas> ListadeAsignaturas { get; set; }
    public List<Secciones> ListadeSecciones { get; set; }

    public AdicionarAsig()
    {
        ListadeDepto = new List<Departamentos>();
        CargarDeptos();
        ListadeAsignaturas = new List<Asignaturas>();
        CargarAsig();
        ListadeSecciones = new List<Secciones>();
        CargarSecciones();
    }

    private void CargarDeptos()
    {
        Departamentos D1 = new Departamentos(01, "Informatica Adiministrativa");
            ListadeDepto.Add(D1);
        Departamentos D2 = new Departamentos(02, "Contaduria");
            ListadeDepto.Add(D2);
        Departamentos D3 = new Departamentos(01, "Historia");
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
            Secciones s1 = new Secciones(0700,"LuMaMiJu", "Bily Fernandez");
        ListadeSecciones.Add(s1);
            Secciones s2 = new Secciones(0710,"LuMaMiJu", "Bily Fernandez");
        ListadeSecciones.Add(s2);
            Secciones s3 = new Secciones(0800,"LuMaMiJu", "Bily Fernandez");
        ListadeSecciones.Add(s3);
    }

}
