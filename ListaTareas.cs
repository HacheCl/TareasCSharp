using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListaTareas
{
    List<Tarea> tareas;


    public ListaTareas()
    {
        tareas = new List<Tarea>();
    }

    public void AgregarTarea(string descripcion, int año, int mes,int dia)
    {
        Tarea tarea = new Tarea(descripcion, año, mes, dia);
        tareas.Add(tarea);
    }

    public void ListarTareas()
    {
        if(tareas.Count==0)
        {
            Console.WriteLine("No hay tareas");
        }
        foreach (Tarea tarea in tareas)
        {
            Console.WriteLine(tareas.IndexOf(tarea) + ". " + tarea.ToString());
        }
    }
    public void ListarTareasIncompletas()
    {
        foreach (Tarea tarea in tareas)
        {
            if (!tarea.EstaCompletada())
            {
                Console.WriteLine(tareas.IndexOf(tarea) + ". " + tarea.ToString());
            }
        }
    }
    public void ListarTareasPorFecha()
    {
        tareas.Sort((x, y) => DateTime.Compare(x.getFecha(), y.getFecha()));
        foreach (Tarea tarea in tareas)
        {
            Console.WriteLine(tareas.IndexOf(tarea) + ". " + tarea.ToString());
        }
    }
    public void MarcarTareaComoCompletada(int indice)
    {
        tareas[indice].MarcarComoCompletada();
    }
    public List<Tarea> GetTareas()
    {
            return tareas;
    }
}
