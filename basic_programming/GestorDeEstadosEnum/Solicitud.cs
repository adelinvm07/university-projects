using System.Globalization;

namespace PracticaEnum
{
    public class Solicitud
    {
        private string ID;
        private string NombreCliente;
        private string Descripcion;
        private int EstadoSolicitud;

        public void MostrarDatosCliente(int i)
        {
            Console.WriteLine($"Cliente {i + 1}");
            Console.WriteLine($"ID: {ID} \nNombre: {NombreCliente} \nDescripción: {Descripcion} \nEstado: {(EstadoSolicitud)EstadoSolicitud} \n");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>>");
        }

        // Getters
        public string GetID() => ID;
        public string GetNombreCliente() => NombreCliente;
        public string GetDescripcion() => Descripcion;
        public int GetEstadoSolicitud() => EstadoSolicitud;

        // Setters
        public void setID(List<Solicitud> clientes)
        {
            string id = "";
            bool idRepetido = false;
            do
            {
                idRepetido = false;

                Console.Write("ID: ");
                id = Console.ReadLine();

                for (int i = 0; i < clientes.Count; i++)
                {
                    if (clientes[i].GetID() == id)
                    {
                        Console.WriteLine("Ya existe un cliente con ese ID.");
                        idRepetido = true;
                        break;
                    }
                }
                if (string.IsNullOrWhiteSpace(id))
                {
                    Console.WriteLine("ID no válido.");
                }
            } while (string.IsNullOrWhiteSpace(id) || idRepetido);

            this.ID = id;
        }
        public void setNombreCliente()
        {
            string nombreCliente = "";
            do
            {
                Console.Write("Nombre del cliente: ");
                nombreCliente = Console.ReadLine();

                if (string.IsNullOrEmpty(nombreCliente))
                {
                    Console.WriteLine("Nombre no válido.");
                }
            } while (string.IsNullOrEmpty(nombreCliente));

            this.NombreCliente = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombreCliente.ToLower());
        }
        public void setDescripcion()
        {
            string descripcion = "";
            do
            {
                Console.Write("Descripción: ");
                descripcion = Console.ReadLine();

                if (string.IsNullOrEmpty(descripcion))
                {
                    Console.WriteLine("Escriba una descripción.");
                }

            } while (string.IsNullOrEmpty(descripcion));

            this.Descripcion = descripcion;
        }
        public void setEstadoSolicitud()
        {
            int estadoSolicitud = 0;
            bool validarEstadoSolicitud;
            int totalEstados = 0;

            Console.WriteLine("\n* Seleccione en que estado se encuentra: ");
            foreach (var v in Enum.GetValues<EstadoSolicitud>())
            {
                Console.WriteLine($"{(int)v} - {v}");
                totalEstados++;
            }
            do
            {
                Console.Write("Estado de la solicitud: ");
                validarEstadoSolicitud = int.TryParse(Console.ReadLine(), out estadoSolicitud);

                if (!validarEstadoSolicitud || estadoSolicitud < 1 || estadoSolicitud > totalEstados)
                {
                    Console.WriteLine("Estado no válido.");
                }

            } while (!validarEstadoSolicitud || estadoSolicitud < 1 || estadoSolicitud > totalEstados);

            this.EstadoSolicitud = estadoSolicitud;
        }
    }
    enum EstadoSolicitud
    {
        Pendiente = 1,
        EnProceso = 2,
        Completada = 3,
        Cancelada = 4
    }
    enum MenuServicios
    {
        Registrar = 1,
        MostrarTodo = 2,
        Buscar = 3,
        Modificar = 4,
        Salir = 5
    }
}
