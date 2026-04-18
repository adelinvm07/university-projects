namespace PracticaEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestor de estados.\n");
            Console.WriteLine("Bienvenid@");

            bool validarOpcionMenu;
            int opcionMenu = 0;
            //Lista para almacenar los clientes registrados
            List<Solicitud> clientes = new List<Solicitud>();

            do
            {
                Console.Write("\n¿Qué desea realizar? \n1- Registrar una nueva solicitud \n2- Mostrar todas las solicitudes" +
                    "\n3- Buscar una solicitud por ID \n4- Modificar estado de una solicitud \n5- Salir \nOpción: ");
                //Validando entrada
                do
                {
                    validarOpcionMenu = int.TryParse(Console.ReadLine(), out opcionMenu);
                    if (!validarOpcionMenu || opcionMenu < 1 || opcionMenu > 5)
                    {
                        Console.Write("Opción no válida. Opción: ");
                    }
                } while (!validarOpcionMenu || opcionMenu < 1 || opcionMenu > 5);

                //Instancia del enumerador para el menu
                MenuServicios menu = (MenuServicios)opcionMenu;
                switch (menu)
                {
                    case MenuServicios.Registrar:
                        //Instancia del objeto
                        Solicitud solicitud = new Solicitud();

                        Console.WriteLine("╔───────────────────────────╗");
                        Console.WriteLine("│   Registro del cliente    │");
                        Console.WriteLine("╚───────────────────────────╝");
                        solicitud.setID(clientes);
                        solicitud.setNombreCliente();
                        solicitud.setDescripcion();
                        solicitud.setEstadoSolicitud();

                        clientes.Add(solicitud);

                        Console.WriteLine("\n\t Registro del cliente completado exitosamente");
                        Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
                        break;

                    case MenuServicios.MostrarTodo:

                        Console.WriteLine("╔───────────────────────────╗");
                        Console.WriteLine("│   Clientes registrados    │");
                        Console.WriteLine("╚───────────────────────────╝");
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine("No hay clientes registrados.");
                        }
                        for (int i = 0; i < clientes.Count; i++)
                        {
                            clientes[i].MostrarDatosCliente(i);
                        }
                        break;

                    case MenuServicios.Buscar:
                        Console.WriteLine("╔─────────────────────────────╗");
                        Console.WriteLine("│ Buscar clientes registrados │");
                        Console.WriteLine("╚─────────────────────────────╝");
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine("No hay clientes registrados.");
                        }
                        else
                        {
                            Console.Write(" * ID del cliente: ");
                            string idBuscado = "";
                            do
                            {
                                idBuscado = Console.ReadLine();
                                if (string.IsNullOrEmpty(idBuscado))
                                {
                                    Console.WriteLine("Introduzca el ID.");
                                }

                            } while (string.IsNullOrEmpty(idBuscado));

                            //Lógica para encontrar al cliente
                            Solicitud idEncontrado = clientes.Find(Solicitud => Solicitud.GetID() == idBuscado);

                            if (idEncontrado != null)
                            {
                                //Guarda la posición que tenía ese cliente para mostrarla con los datos
                                int posicionEncontrada = clientes.IndexOf(idEncontrado);
                                idEncontrado.MostrarDatosCliente(posicionEncontrada);
                            }
                            else
                            {
                                Console.WriteLine("El ID ingresado no se encuentra registrado en el sistema.");
                            }
                        }
                        break;

                    case MenuServicios.Modificar:

                        Console.WriteLine("╔───────────────────────────────╗");
                        Console.WriteLine("│ Modificar estado de solicitud │");
                        Console.WriteLine("╚───────────────────────────────╝");

                        if (clientes.Count == 0)
                        {
                            Console.WriteLine("No hay clientes registrados.");
                        }
                        else
                        {
                            Console.WriteLine("\n \t Clientes registrados. \n");
                            for (int i = 0; i < clientes.Count; i++)
                            {
                                clientes[i].MostrarDatosCliente(i);
                                Console.Write("¿De qué cliente quiere modificar el estado de la solicitud? ");
                                bool validarModificar;
                                int modificar;
                                do
                                {
                                    validarModificar = int.TryParse(Console.ReadLine(), out modificar);
                                    if (!validarModificar || modificar < 0 || modificar > clientes.Count)
                                    {
                                        Console.Write("No válido. Cliente a modificar: ");
                                    }

                                } while (!validarModificar || modificar < 0 || modificar > clientes.Count);

                                //Para modificar el estado del cliente 
                                clientes[modificar - 1].setEstadoSolicitud();
                            }
                        }
                        break;

                    case MenuServicios.Salir:
                        Console.WriteLine("Hasta pronto!");
                        break;
                }
            } while (opcionMenu != 5);

        }
    }
}

