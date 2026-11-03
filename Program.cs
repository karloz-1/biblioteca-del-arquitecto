using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bienvenido a la biblioteca del arquitecto");
        byte exitNumber;
        byte userOption;
        do
        {
            exitNumber = DisplayMenu("principal", new List<string> { "Libros", "Usuarios", "Préstamos", "Búsquedas y reportes", "Guardar / Cargar datos" });
            userOption = ReadOption();

            switch (userOption)
            {
                case 1:
                    BooksMenu();
                    break;
                case 2:
                    UsersMenu();
                    break;
                case 3:
                    LoansMenu();
                    break;
                case 4:
                    SearchAndReportsMenu();
                    break;
                case 5:
                    SaveLoadMenu();
                    break;
                case 6:
                    ExitRoutine();
                    break;
                default:
                    System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                    System.Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (userOption != exitNumber);
    }

    static byte ReadOption()
    {
        System.Console.WriteLine("Ingrese el número de la opción que desee: ");
        // Se maneja un TryParse básico para evitar caídas si el usuario ingresa letras en lugar de números.
        if (byte.TryParse(Console.ReadLine(), out byte userOption))
        {
            return userOption;
        }
        return 0; // Retorna 0 que caerá en el default (Opción inválida)
    }

    static byte DisplayMenu(string title, IEnumerable<string> values)
    {
        Console.Clear();
        List<string> menuLines = new List<string> { $"=== Menú {title} ===" };
        byte i = 1;
        foreach (string value in values)
        {
            menuLines.Add($"{i}. {value}");
            i += 1;
        }
        menuLines.Add($"{i}. Salir");
        Console.WriteLine(string.Join(Environment.NewLine, menuLines));
        return i;
    }

    static void ExitRoutine()
    {
        Console.Clear();
        System.Console.WriteLine("=== Salir ===");
        System.Console.WriteLine("¿Guardar los datos antes de salir? (S/N): ");
        string answer = Console.ReadLine()?.Trim().ToUpper();
        if (answer == "S")
        {
            System.Console.WriteLine("Guardando datos...");
            System.Console.WriteLine("Datos guardados exitosamente.");
        }
        System.Console.WriteLine("Saliendo del sistema... ¡Hasta pronto!");
        System.Console.WriteLine("Presione cualquier tecla para cerrar.");
        Console.ReadKey();
    }

    static void BooksMenu()
    {
        byte exitNumber;
        byte userOption;
        do
        {
            exitNumber = DisplayMenu("Libros", new List<string> { "Registrar libro", "Listar libros", "Ver detalle de libro", "Actualizar libro", "Eliminar libro" });
            userOption = ReadOption();
            switch (userOption)
            {
                case 1:
                    RegisterBook();
                    break;
                case 2:
                    ListBooks();
                    break;
                case 3:
                    SeeBookDetails();
                    break;
                case 4:
                    UpdateBook();
                    break;
                case 5:
                    DeleteBook();
                    break;
                case 6:
                    break;
                default:
                    System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                    System.Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (userOption != exitNumber);

        static void RegisterBook()
        {
            Console.Clear();
            System.Console.WriteLine("=== Registrar Libro ===");
            System.Console.WriteLine("Registrando libros...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }

        static void ListBooks()
        {
            byte exitNumber;
            byte userOption;

            do
            {
                exitNumber = DisplayMenu("Listar libros", new List<string> { "Listar todos", "Listar Disponibles", "Listar Prestados" });
                userOption = ReadOption();
                switch (userOption)
                {
                    case 1:
                        ListAllBooks();
                        break;
                    case 2:
                        ListAvailableBooks();
                        break;
                    case 3:
                        ListBorrowedBooks();
                        break;
                    case 4:
                        break;
                    default:
                        System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                        System.Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (userOption != exitNumber);

            static void ListAllBooks()
            {
                Console.Clear();
                System.Console.WriteLine("=== Mostrar todos los libros ===");
                System.Console.WriteLine("Mostrando todos libros...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }

            static void ListAvailableBooks()
            {
                Console.Clear();
                System.Console.WriteLine("=== Mostrar todos los libros disponibles ===");
                System.Console.WriteLine("Mostrando libros disponibles...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }

            static void ListBorrowedBooks()
            {
                Console.Clear();
                System.Console.WriteLine("=== Mostrar libros prestados ===");
                System.Console.WriteLine("Mostrando libros prestados...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }
        }

        static void SeeBookDetails()
        {
            Console.Clear();
            System.Console.WriteLine("=== Ver detalles del libro ===");
            System.Console.WriteLine("Mostrando detalles del libro...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }

        static void UpdateBook()
        {
            byte exitNumber;
            byte userOption;

            do
            {
                exitNumber = DisplayMenu("Actualizar libro", new List<string> { "Editar título", "Editar autor", "Editar año / categoría" });
                userOption = ReadOption();
                switch (userOption)
                {
                    case 1:
                        EditBookTitle();
                        break;
                    case 2:
                        EditBookAuthor();
                        break;
                    case 3:
                        EditBookYearCategory();
                        break;
                    case 4:
                        break;
                    default:
                        System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                        System.Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (userOption != exitNumber);

            static void EditBookTitle()
            {
                Console.Clear();
                System.Console.WriteLine("=== Editar titulo del Libro ===");
                System.Console.WriteLine("Editando titulo del Libro...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }
            static void EditBookAuthor()
            {
                Console.Clear();
                System.Console.WriteLine("=== Editar autor del Libro ===");
                System.Console.WriteLine("Editando autor del Libro...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }
            static void EditBookYearCategory()
            {
                Console.Clear();
                System.Console.WriteLine("=== Editar año o categoria del Libro ===");
                System.Console.WriteLine("Editando año o categoria del Libro...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }
        }

        static void DeleteBook()
        {
            Console.Clear();
            System.Console.WriteLine("=== Eliminar Libro ===");
            System.Console.WriteLine("Eliminando libro (validando que no esté prestado)...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }

    static void UsersMenu()
    {
        byte exitNumber;
        byte userOption;
        do
        {
            exitNumber = DisplayMenu("Usuarios", new List<string> { "Registrar usuario", "Listar usuarios", "Ver detalle de usuario", "Actualizar usuario", "Eliminar usuario" });
            userOption = ReadOption();
            switch (userOption)
            {
                case 1:
                    RegisterUser();
                    break;
                case 2:
                    ListUsers();
                    break;
                case 3:
                    SeeUserDetails();
                    break;
                case 4:
                    UpdateUser();
                    break;
                case 5:
                    DeleteUser();
                    break;
                case 6:
                    break;
                default:
                    System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                    System.Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (userOption != exitNumber);

        static void RegisterUser()
        {
            Console.Clear();
            System.Console.WriteLine("=== Registrar Usuario ===");
            System.Console.WriteLine("Registrando usuario...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }

        static void ListUsers()
        {
            Console.Clear();
            System.Console.WriteLine("=== Listar Usuarios ===");
            System.Console.WriteLine("Mostrando lista de usuarios...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }

        static void SeeUserDetails()
        {
            Console.Clear();
            System.Console.WriteLine("=== Ver detalle de usuario ===");
            System.Console.WriteLine("Mostrando detalle del usuario (por ID/documento)...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }

        static void UpdateUser()
        {
            byte exitNumber;
            byte userOption;

            do
            {
                exitNumber = DisplayMenu("Actualizar usuario", new List<string> { "Editar nombre", "Editar contacto", "Activar / desactivar" });
                userOption = ReadOption();
                switch (userOption)
                {
                    case 1:
                        EditUserName();
                        break;
                    case 2:
                        EditUserContact();
                        break;
                    case 3:
                        ToggleUserStatus();
                        break;
                    case 4:
                        break;
                    default:
                        System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                        System.Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (userOption != exitNumber);

            static void EditUserName()
            {
                Console.Clear();
                System.Console.WriteLine("=== Editar nombre de usuario ===");
                System.Console.WriteLine("Editando nombre...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }

            static void EditUserContact()
            {
                Console.Clear();
                System.Console.WriteLine("=== Editar contacto de usuario ===");
                System.Console.WriteLine("Editando contacto...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }

            static void ToggleUserStatus()
            {
                Console.Clear();
                System.Console.WriteLine("=== Activar / Desactivar usuario ===");
                System.Console.WriteLine("Cambiando estado del usuario...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }
        }

        static void DeleteUser()
        {
            Console.Clear();
            System.Console.WriteLine("=== Eliminar Usuario ===");
            System.Console.WriteLine("Eliminando usuario (validando préstamos activos)...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }

    static void LoansMenu()
    {
        byte exitNumber;
        byte userOption;
        do
        {
            exitNumber = DisplayMenu("Préstamos", new List<string> { "Crear préstamo", "Listar préstamos", "Ver detalle de préstamo", "Registrar devolución", "Eliminar préstamo" });
            userOption = ReadOption();
            switch (userOption)
            {
                case 1:
                    CreateLoan();
                    break;
                case 2:
                    ListLoans();
                    break;
                case 3:
                    SeeLoanDetails();
                    break;
                case 4:
                    RegisterReturn();
                    break;
                case 5:
                    DeleteLoan();
                    break;
                case 6:
                    break;
                default:
                    System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                    System.Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (userOption != exitNumber);

        static void CreateLoan()
        {
            Console.Clear();
            System.Console.WriteLine("=== Crear préstamo ===");
            System.Console.WriteLine("Validando usuario y libro. Creando préstamo...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }

        static void ListLoans()
        {
            byte exitNumber;
            byte userOption;

            do
            {
                exitNumber = DisplayMenu("Listar préstamos", new List<string> { "Todos", "Activos", "Cerrados (devueltos)" });
                userOption = ReadOption();
                switch (userOption)
                {
                    case 1:
                        ListAllLoans();
                        break;
                    case 2:
                        ListActiveLoans();
                        break;
                    case 3:
                        ListClosedLoans();
                        break;
                    case 4:
                        break;
                    default:
                        System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                        System.Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (userOption != exitNumber);

            static void ListAllLoans()
            {
                Console.Clear();
                System.Console.WriteLine("=== Mostrar todos los préstamos ===");
                System.Console.WriteLine("Mostrando...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }

            static void ListActiveLoans()
            {
                Console.Clear();
                System.Console.WriteLine("=== Mostrar préstamos activos ===");
                System.Console.WriteLine("Mostrando...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }

            static void ListClosedLoans()
            {
                Console.Clear();
                System.Console.WriteLine("=== Mostrar préstamos cerrados ===");
                System.Console.WriteLine("Mostrando...");
                System.Console.WriteLine("Presione cualquier tecla para salir: ");
                Console.ReadKey();
            }
        }

        static void SeeLoanDetails()
        {
            Console.Clear();
            System.Console.WriteLine("=== Ver detalle de préstamo ===");
            System.Console.WriteLine("Mostrando detalles por ID...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }

        static void RegisterReturn()
        {
            Console.Clear();
            System.Console.WriteLine("=== Registrar devolución ===");
            System.Console.WriteLine("Marcando libro como disponible y cerrando préstamo...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }

        static void DeleteLoan()
        {
            Console.Clear();
            System.Console.WriteLine("=== Eliminar préstamo ===");
            System.Console.WriteLine("Eliminando registro de préstamo...");
            System.Console.WriteLine("Presione cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }

    static void SearchAndReportsMenu()
    {
        byte exitNumber;
        byte userOption;
        do
        {
            exitNumber = DisplayMenu("Búsquedas y reportes", new List<string> { "Buscar libro", "Buscar usuario", "Reportes" });
            userOption = ReadOption();
            switch (userOption)
            {
                case 1:
                    SearchBook();
                    break;
                case 2:
                    SearchUser();
                    break;
                case 3:
                    Reports();
                    break;
                case 4:
                    break;
                default:
                    System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                    System.Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (userOption != exitNumber);

        static void SearchBook()
        {
            byte exitNumber;
            byte userOption;
            do
            {
                exitNumber = DisplayMenu("Buscar libro", new List<string> { "Por título", "Por autor", "Por ID/ISBN", "Por categoría" });
                userOption = ReadOption();
                switch (userOption)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.Clear();
                        System.Console.WriteLine("=== Buscando libro ===");
                        System.Console.WriteLine("Mostrando resultados de la búsqueda...");
                        System.Console.WriteLine("Presione cualquier tecla para salir: ");
                        Console.ReadKey();
                        break;
                    case 5:
                        break;
                    default:
                        System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                        System.Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (userOption != exitNumber);
        }

        static void SearchUser()
        {
            byte exitNumber;
            byte userOption;
            do
            {
                exitNumber = DisplayMenu("Buscar usuario", new List<string> { "Por nombre", "Por ID/documento" });
                userOption = ReadOption();
                switch (userOption)
                {
                    case 1:
                    case 2:
                        Console.Clear();
                        System.Console.WriteLine("=== Buscando usuario ===");
                        System.Console.WriteLine("Mostrando resultados de la búsqueda...");
                        System.Console.WriteLine("Presione cualquier tecla para salir: ");
                        Console.ReadKey();
                        break;
                    case 3:
                        break;
                    default:
                        System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                        System.Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (userOption != exitNumber);
        }

        static void Reports()
        {
            byte exitNumber;
            byte userOption;
            do
            {
                exitNumber = DisplayMenu("Reportes", new List<string> { "Préstamos por usuario", "Préstamos por libro", "Préstamos vencidos", "Resumen general" });
                userOption = ReadOption();
                switch (userOption)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.Clear();
                        System.Console.WriteLine("=== Generando reporte ===");
                        System.Console.WriteLine("Mostrando información del reporte solicitado...");
                        System.Console.WriteLine("Presione cualquier tecla para salir: ");
                        Console.ReadKey();
                        break;
                    case 5:
                        break;
                    default:
                        System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                        System.Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (userOption != exitNumber);
        }
    }

    static void SaveLoadMenu()
    {
        byte exitNumber;
        byte userOption;
        do
        {
            exitNumber = DisplayMenu("Guardar / Cargar datos", new List<string> { "Guardar datos", "Cargar datos", "Reiniciar datos (vaciar todo)" });
            userOption = ReadOption();
            switch (userOption)
            {
                case 1:
                    Console.Clear();
                    System.Console.WriteLine("=== Guardar datos ===");
                    System.Console.WriteLine("Guardando información de libros, usuarios y préstamos...");
                    System.Console.WriteLine("Presione cualquier tecla para salir: ");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    System.Console.WriteLine("=== Cargar datos ===");
                    System.Console.WriteLine("Cargando información al sistema...");
                    System.Console.WriteLine("Presione cualquier tecla para salir: ");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    System.Console.WriteLine("=== Reiniciar datos ===");
                    System.Console.WriteLine("¿Está seguro que desea vaciar todo? (S/N): ");
                    string answer = Console.ReadLine()?.Trim().ToUpper();
                    if (answer == "S")
                    {
                        System.Console.WriteLine("Datos reiniciados con éxito.");
                    }
                    else
                    {
                        System.Console.WriteLine("Operación cancelada.");
                    }
                    System.Console.WriteLine("Presione cualquier tecla para salir: ");
                    Console.ReadKey();
                    break;
                case 4:
                    break;
                default:
                    System.Console.WriteLine("Opción invalida, por favor intente de nuevo");
                    System.Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (userOption != exitNumber);
    }
}