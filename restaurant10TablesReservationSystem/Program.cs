using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Validar si es usuario existente o si debe registrar y registrarse
//2. El programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe
//3. El programa debe repetirse hasta que se registren las 10 personas
namespace restaurant10TablesReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           

                string[] userNames = new string[10] { "CESAR", "HERA", "POLLY", "ARES", "UNA", "PRUEBA", "MAS", "LLENO", "NOMBRE", "ASD" };
                bool userType;
                int arrayCurrentIndex = 0;
                Console.WriteLine("Bienvenido");
                while ( arrayCurrentIndex < 10)
                {
                try
                {
                    //if(arrayCurrentIndex == 10)
                    //{
                    //    Console.WriteLine("Ya no hay lugares disponibles, trate de nuevo el proximo año");
                    //    Environment.Exit(0);
                    //}
                    Console.WriteLine("Esta registrado? Escriba true o false para registrarse");
                    userType = Convert.ToBoolean(Console.ReadLine());

                    if (userType)
                    {
                        Console.WriteLine("Hola, eres un usuario registrado, por favor ingrese su usuario");
                        string userToSearch = Console.ReadLine();
                        Console.WriteLine("The user you searched is {0}", userToSearch);
                        int index = Array.IndexOf(userNames, userToSearch.ToUpper());
                        //-1 significa que no existe en el array
                        if(index == -1)
                        {
                            Console.WriteLine("Usuario no encontrado, registrese");
                            addUser();
                        }
                        else
                        {
                            Console.WriteLine("Welcome {0}, es un placer alimentarte",userNames[index].ToUpper());
                        }
                    }
                    else
                    {
                        addUser();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrio un error: {ex.Message}");
                }
            }

            Console.WriteLine("Ya no hay lugares disponibles, trate de nuevo el proximo año \n Esta es la lista");
            int auxIndex = 0;
            foreach(string element in userNames)
            {
                Console.WriteLine("{0} {1}", auxIndex+1,userNames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);

            void addUser()
            {
                Console.WriteLine("Por favor introduzca su nombre");
                userNames[arrayCurrentIndex] = Console.ReadLine().ToUpper();
                Console.WriteLine($"Listo, usuario {userNames[arrayCurrentIndex].ToUpper()} agregado");
                arrayCurrentIndex++;
            }


          

        }
    }
}
