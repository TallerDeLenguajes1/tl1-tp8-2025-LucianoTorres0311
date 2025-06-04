using System.Runtime.InteropServices;

namespace creadorTareas
{
    public class Tarea

    {
        public int TareaID
        {
            get; set;
        }
        public string Descripcion
        {
            get; set;
        }
        public int Duracion
        {
            get; set;
        }

        public void crearTarea()
        {
            Console.Write("Ingrese el id de la tarea:");
            TareaID = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la descripción de la tarea: ");
            Descripcion = Console.ReadLine();
            Console.Write("Ingrese la duración (entre 10 y 100): ");
            Duracion = int.Parse(Console.ReadLine());
            if (Duracion < 10 || Duracion > 100)
            {
                do
                {
                    Console.Write("Ingrese Una duracion valida:");
                    Duracion = int.Parse(Console.ReadLine());
                } while (Duracion < 10 || Duracion > 100);
            }
        }
        public void anadirTarea(Tarea tarea, List<Tarea> tareasPendientes)
        {
            Random aleatorio = new Random();
            int cantTareas = aleatorio.Next();
            for (int i = 0; i < cantTareas; i++)
        {
            tarea.crearTarea();
            tareasPendientes.Add(tarea);
        }
        }


        public void marcarComoRealizada(List<Tarea> tareasPendientes, List<Tarea> tareasRealizadas)
        {
            int id;
            Console.WriteLine("Ingrese el id de cual tarea quiere marcar como realizada");
            id = int.Parse(Console.ReadLine());
            for (int i = 0; i < tareasPendientes.Count; i++)
            {
                if (tareasPendientes[i].TareaID == id)
                {
                    tareasRealizadas.Add(tareasPendientes[i]);
                    tareasPendientes.RemoveAt(i);
                    Console.WriteLine("La tarea fue marcada como realizada");
                }
                else
                {
                    Console.WriteLine("La tarea con ese id no se pudo encontrar");
                }
            }
        }

        public void mostrarListaPen(List<Tarea> tareasPendientes)
        {
             foreach (var tareasPen in tareasPendientes)
            {
                Console.WriteLine($"Id:{tareasPen.TareaID}");
                Console.WriteLine($"Descripcion de la tarea:{tareasPen.Descripcion}");
                Console.WriteLine($"Duracion:{tareasPen.Duracion}");
            }
            if (tareasPendientes.Count == 0)
            {
                Console.WriteLine("La lista esta vacia");
            }
        }

        public void mostrarListaReal(List<Tarea> tareasRealizadas)
        {
            foreach (var tareasReal in tareasRealizadas)
            {
                Console.WriteLine($"Id:{tareasReal.TareaID}");
                Console.WriteLine($"Descripcion de la tarea:{tareasReal.Descripcion}");
                Console.WriteLine($"Duracion:{tareasReal.Duracion}");
            }
            if (tareasRealizadas.Count == 0)
            {
                Console.WriteLine("La lista esta vacia");
            }
        }
        public void buscarTarea(List<Tarea> tareasPendientes)
        {
            string aux;
            Console.WriteLine("Ingrese la descripcion que desea buscar");
            aux = Console.ReadLine();
            foreach (var tareasPen in tareasPendientes)
            {
                if (tareasPen.Descripcion == aux)
                {
                    Console.WriteLine("La tarea que usted busco es:");
                    Console.WriteLine($"ID de la tarea:{tareasPen.TareaID}");
                    Console.WriteLine($"Descripcion de la tarea:{tareasPen.Descripcion}");
                    Console.WriteLine($"Duracion de la tarea:{tareasPen.Duracion}");
                }
            }
        }
    }
}
