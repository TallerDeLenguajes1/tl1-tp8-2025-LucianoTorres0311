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

        public void cargarTarea()
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
