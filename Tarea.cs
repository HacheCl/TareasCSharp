using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tarea
{
    string descripcion;
    DateTime fechaVencimiento;
    bool completada;
    public Tarea(string descripcion,int año, int mes, int dia)
    {
        this.descripcion = descripcion;
        this.fechaVencimiento = new DateTime(año, mes, dia);
        completada = false;
    }
    public String toString()
    {
        return "Descripcion: " + descripcion + " Fecha: " + fechaVencimiento + " Completada: " + completada;
    }
    
    
    public bool EstaCompletada()
    {
        return completada;
    }
    public DateTime getFecha()
    {
        return fechaVencimiento;
    }
    public void MarcarComoCompletada()
    {
        completada = true;
    }
    public string getDescripcion()
    {
           return descripcion;
    }
    public string getFechaVencimiento()
    {
        return fechaVencimiento.ToString();
    }
    public string getCompletada()
    {
        return completada.ToString();
    }

}
