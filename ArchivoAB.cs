namespace ProyectoDyA;

public class NodoArchivo
{
    public string Nombre;
    public string Extension;
    public double Tamaño;
    public bool Tipo;
    public NodoArchivo Derecho;
    public NodoArchivo Izquierdo;

    public NodoArchivo(string nom)
    {
        Nombre = nom;
        Tipo = true;
    }

    public NodoArchivo(string nom, string ext, double tam)
    {
        Nombre = nom;
        Extension = ext;
        Tamaño = tam;
        Tipo = false;
    }
}

public class Archivo
{
    public int Menu()
    {
        Console.WriteLine("Sistema de Archivos\n");
        Console.WriteLine("1. Crear Directorio");
        Console.WriteLine("2. Insertar Archivo");
        Console.WriteLine("3. Buscar Elemento");
        Console.WriteLine("4. Eliminar Elemento");
        Console.WriteLine("5. Recorido Inorden");
        Console.WriteLine("6. Recorido Preorden");
        Console.WriteLine("7. Recorido Postorden");
        Console.WriteLine("8. Información del Elemento");
        Console.WriteLine("9. Salir");

        Console.Write("Seleccione una opcion: ");
        
        return Convert.ToInt32(Console.ReadLine());
    }

    public void CrearDirectorio()
    {
        Console.Write("Nombre del directorio: ");
        string nombre = Console.ReadLine();
    }

    public void InsertarArchivo()
    {
        
    }
    public void BuscarElemento()
    {
    }
    public void EliminarArchivo()
    {
        
    }
    
}