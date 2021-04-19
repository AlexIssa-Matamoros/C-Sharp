using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Mouse", 250);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Teclado", 350);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Monitor", 4000);
        ListadeProductos.Add(p3);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Alex", "77777");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Issai", "99999");
        ListadeClientes.Add(c2);
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Jose", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Pablo", "V002");
        ListadeVendedores.Add(v2);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("===================");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }

    public void CrearOrden()
    {
        Console.WriteLine("Creando Orden");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("SubTotal de la orden es de: " + nuevaOrden.Subtotal);
        Console.WriteLine("Impuesto de la orden es de: " + nuevaOrden.Impuesto);
        Console.WriteLine("Total de la orden es de: " + nuevaOrden.Total);

        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("                 LISTA DE ORDENES");
        Console.WriteLine("==========================================================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo   | Fecha                    | Total");
        Console.WriteLine("==========================================================");

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine(orden.Codigo + "        | " + orden.Fecha +" |");
            Console.WriteLine("Subtotal |                          "+"| " + orden.Subtotal);
            Console.WriteLine("impuesto |                         "+" | " + orden.Impuesto);
            Console.WriteLine("Total    |                         "+" | " + orden.Total);
            Console.WriteLine("==========================================================");
            Console.WriteLine("Cliente  | Vendedor ");
            Console.WriteLine(orden.Cliente.Nombre + "     | " + orden.Vendedor.Nombre);
            Console.WriteLine("==========================================================");
            Console.WriteLine("Productos:");

            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}

 public void Listarclases()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("ASIGNATURAS");
        Console.WriteLine("************");
            
            Console.WriteLine("    Nombre de la asignatura    |Seccion| Horarios |Cupos|       Profesor      |");
            Console.WriteLine("_______________________________________________________________________________");

        foreach (var clases in ListadeAsignatura)
        {
            Console.WriteLine(clases.Clase + "  " + clases.Seccion + "  " + clases.Horario + "  " + clases.Cupos + " " + clases.Profesor);        
        }
        Console.WriteLine("");
        Console.WriteLine("0 - ATRAS");
        
        Adiciones adi = new Adiciones();
        Matricula M = new Matricula();
        string opcion = "";

             while (true)
        {
         opcion = Console.ReadLine();
                switch (opcion)
            {
                case "0":
                adi.DEPART();
                break;

            }
                
        }
    
    }   