using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Consola
{
    public Archivo archivo;
    public ListaTareas lista;
    public Consola()
    {
        ListaTareas lista = new ListaTareas();
        Archivo archivo = new Archivo();
        elegirOpcion();
    }
    public void menu()
    {
        Console.WriteLine("1. Listar todas las tareas");
        Console.WriteLine("2. Listar tareas incompletas");
        Console.WriteLine("3. Listar tareas por fecha de vencimiento");
        Console.WriteLine("4. Agregar nueva tarea");
        Console.WriteLine("5. Marcar tarea como completada");
        Console.WriteLine("6. Guardar tareas en archivo");
        Console.WriteLine("7. Cargar tareas desde archivo");
        Console.WriteLine("8. salir");
    }
    public void elegirOpcion()
    {
        int opcion;
        do
        {
            Console.WriteLine("Elija una opcion: ");
            menu();
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    lista.ListarTareas();
                    break;
                case 2:
                    lista.ListarTareasIncompletas();
                    break;
                case 3:
                    lista.ListarTareasPorFecha();
                    break;
                case 4:
                    Console.WriteLine("Ingrese la descripcion de la tarea: ");
                    string descripcion = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha de vencimiento de la tarea: ");
                    int año = int.Parse(Console.ReadLine());
                    int mes = int.Parse(Console.ReadLine());
                    int dia = int.Parse(Console.ReadLine());
                    lista.AgregarTarea(descripcion, año, mes, dia);
                    break;
                case 5:
                    Console.WriteLine("Ingrese el numero de la tarea: ");
                    lista.MarcarTareaComoCompletada(int.Parse(Console.ReadLine()));
                    break;
                case 6:
                    archivo.GuardarTareas(lista.GetTareas(),"Tareas.txt");
                    break;
                case 7:
                    archivo.CargarTareas(lista, "Tareas.txt");
                    break;
                case 8:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            
        } while (opcion != 8);
        
    }
}
