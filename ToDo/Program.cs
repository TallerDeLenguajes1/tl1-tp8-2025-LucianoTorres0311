// See https://aka.ms/new-console-template for more information
using creadorTareas;
int decision;
Tarea tarea = new Tarea();
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();
do
{
    Console.WriteLine("[1] Agregar Tareas");
    Console.WriteLine("[2] Marcar Tareas como Realizada");
    Console.WriteLine("[3] Mostrar Tareas Pendientes");
    Console.WriteLine("[4] Mostrar Tareas Realizadas");
    Console.WriteLine("[5] Buscar Por Descripcion");
    Console.WriteLine("[0] Salir");
    decision = int.Parse(Console.ReadLine());
    switch (decision)
    {
        case 1:
        tarea.anadirTarea(tarea, tareasPendientes);
        break;
        case 2:
            tarea.marcarComoRealizada(tareasPendientes,tareasRealizadas);
        break;

        case 3:
           tarea.mostrarListaPen(tareasPendientes);
        break;
        case 4:
            tarea.mostrarListaReal(tareasRealizadas);
            break;
        case 5:
            tarea.buscarTarea(tareasPendientes);
            break;
    }
} while (decision != 0);