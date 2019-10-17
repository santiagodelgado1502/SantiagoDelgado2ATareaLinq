using System;
using System.Collections.Generic;
using System.Text;

namespace Debertxt
{
    class Menu
    {
        public void menu()
        {
            Operaciones operaciones = new Operaciones();
            byte opcion;
            opcion = 0;
            do
            {
                try
                {
                    Console.WriteLine(" ====UNIVERSIDAD LAICA ELOY ALFARO DE MANABI==== ");
                    Console.WriteLine(" =======FACULTAD DE CIENCIAS INFORMATICAS========");
                    Console.WriteLine("                                                 ");
                    Console.WriteLine(" BIENVENIDOS A EL SISTEMA DE NOTAS DE ESTUDIANTES");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("=============== Menú de Opciones ================");
                    Console.WriteLine("1. Insertar ");
                    Console.WriteLine("2. Modificar ");
                    Console.WriteLine("3. Eliminar");
                    Console.WriteLine("4.Consultar por ID");
                    Console.WriteLine("5.Consulta General ");
                    Console.WriteLine("6. Salir");
                    Console.WriteLine(" Que deseas hacer ?..");
                    opcion = Convert.ToByte(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            operaciones.Crearachivo();
                            operaciones.Insertar();
                            break;
                        case 2:
                            operaciones.Modificaciones();
                            break;
                        case 3:
                            operaciones.Eliminar();
                            break;
                        case 4:
                            operaciones.Consultaid();
                            break;
                        case 5:
                            operaciones.ConsultaGeneral();
                            break;
                        case 6:
                            Console.WriteLine("******************************************");
                            Console.WriteLine("**********Aplicación Culminada************");
                            Console.WriteLine("******************************************");
                            break;
                        default:
                            Console.WriteLine("******************************************");
                            Console.WriteLine("Opcion incorrecta vuelva a teclar del 1 a el 6");
                            Console.WriteLine("******************************************");
                            break;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("******************************************");
                    Console.WriteLine(" Error !" + fe.Message);
                    Console.WriteLine("******************************************");
                }
                catch (Exception e)
                {
                    Console.WriteLine("******************************************");
                    Console.WriteLine(" Error !" + e.Message);
                    Console.WriteLine("******************************************");

                }

            } while (opcion != 6);
        }
    }
}
