// See https://aka.ms/new-console-template for more information
using creadorTareas;

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();
Console.WriteLine("Ingrese cuantas tareas desea crear");
int cantTareas = int.Parse(Console.ReadLine());
for (int i = 0; i < cantTareas; i++)
{
    Tarea nuevaTarea = new Tarea();
    nuevaTarea.cargarTarea(i + 1);
    tareasPendientes.Add(nuevaTarea);
}

foreach (var tareas in tareasPendientes)
{
    Console.WriteLine($"Id:{tareas.TareaID}");
    Console.WriteLine($"Estado de la tarea:{tareas.Descripcion}");
    Console.WriteLine($"Duracion:{tareas.Duracion}");
}