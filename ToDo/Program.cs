// See https://aka.ms/new-console-template for more information
using creadorTareas;
int decision;
int id;
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();
Console.WriteLine("Ingrese cuantas tareas desea crear");
int cantTareas = int.Parse(Console.ReadLine());
for (int i = 0; i < cantTareas; i++)
{
    Tarea nuevaTarea = new Tarea();
    nuevaTarea.cargarTarea();
    tareasPendientes.Add(nuevaTarea);
}

do
{
    Console.WriteLine("[1] Marcar Tareas como Realizada");
    Console.WriteLine("[2] Mostrar Tareas Pendientes");
    Console.WriteLine("[3] Mostrar Tareas Realizadas");
    Console.WriteLine("[4] Buscar Por Descripcion");
    Console.WriteLine("[0] Salir");
    decision = int.Parse(Console.ReadLine());
    switch (decision)
    {
        case 1:
            Console.WriteLine("Ingrese el id de cual tarea quiere marcar como realizada");

            id = int.Parse(Console.ReadLine());
            for (int i = 0; i < tareasPendientes.Count; i++)
            {
                 if (tareasPendientes[i].TareaID == id)
                {
                    tareasRealizadas.Add(tareasPendientes[i]);
                    tareasPendientes.Remove(tareasPendientes[i]);
                    Console.WriteLine("La tarea fue marcada como realizada");
                } else
                {
                    Console.WriteLine("La tarea con ese id no se pudo encontrar");
                }
            }
           
            break;

        case 2:
            foreach (var tareasPen in tareasPendientes)
            {
                Console.WriteLine($"Id:{tareasPen.TareaID}");
                Console.WriteLine($"Descripcion de la tarea:{tareasPen.Descripcion}");
                Console.WriteLine($"Duracion:{tareasPen.Duracion}");
            }
            break;
        case 3:
            foreach (var tareasReal in tareasRealizadas)
            {
                Console.WriteLine($"Id:{tareasReal.TareaID}");
                Console.WriteLine($"Descripcion de la tarea:{tareasReal.Descripcion}");
                Console.WriteLine($"Duracion:{tareasReal.Duracion}");
            }
            break;
    }
   
} while (decision != 0);