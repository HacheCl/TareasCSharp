using System;

public class Archivo
{
    public void GuardarTareas(List<Tarea> lista,string ruta)
    {
        List<string> lineas = new List<string>();

        
        foreach (Tarea tarea in lista)
        {
               string linea = $"{tarea.getDescripcion()},{tarea.getFechaVencimiento()},{tarea.getCompletada()}";
               lineas.Add(linea);
        }
        System.IO.File.WriteAllLinesAsync(ruta,lineas);



    }
    public void CargarTareas(ListaTareas lista,string ruta)
    {
        string[] lineas = System.IO.File.ReadAllLines(ruta);
        foreach (string linea in lineas)
        {
            string[] datos = linea.Split(',');
            lista.AgregarTarea(datos[0], int.Parse(datos[1]), int.Parse(datos[2]), int.Parse(datos[3]));
           
        }
    }

}
