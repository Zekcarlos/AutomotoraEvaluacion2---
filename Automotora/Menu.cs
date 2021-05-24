using System;
using System.Collections.Generic;
using System.Text;

namespace Automotora
{
    class Menu
    {
            static void Main(string[] args)
            {
                List<Local> local2 = new List<Local>();
                List<Modelo> modelo2 = new List<Modelo>();
                Compra compra;
            Local local1 = null;
            Modelo modelo1 = null;

                int input;
                bool itemsFetched;
                try
                {
                    for (int i = 0; i < 13; i++)
                    {
                        var store = Local.fetchStoreData(i);
                        local2.Add(store);

                        var item = Modelo.fetchItemData(i);
                        modelo2.Add(item);
                    }

                    itemsFetched = true;

                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                    Console.WriteLine();

                    itemsFetched = false;
                }

                while (itemsFetched)
                {

                    Console.WriteLine();
                    Console.WriteLine("********************************************");
                    Console.WriteLine("                    Menu");
                    Console.WriteLine("                                            ");
                    Console.WriteLine(" 1- SELECCIONE LOCAL DE RETIRO DE VEHICULO  ");
                    Console.WriteLine(" 2- SELECCIONE MODELO DE VEHICULO A COMPRAR ");
                    Console.WriteLine(" 3- COMPRAR VEHICULO                        ");
                    Console.WriteLine(" 4- SALIR                                   ");
                    Console.WriteLine("                                            ");
                    Console.WriteLine("********************************************");
                    Console.WriteLine();

                    try
                    {
                        input = validar.readInput();
                        switch (input)
                        {
                            case 1:
                                Console.Clear();

                            Local view = new Local();
                                view.listData();

                                Console.WriteLine();
                                Console.WriteLine("Escriba la ID del local donde comprará el vehiculo.");
                                Console.WriteLine();

                                input = validar.readInput();
                                Console.Clear();

                                Console.WriteLine(local2[input].ToString());
                                local1 = local2[input];

                                break;

                            case 2:
                                Console.Clear();

                                foreach (var show in modelo2)
                                {
                                    Console.WriteLine(show.ToString());
                                }

                                Console.WriteLine();
                                Console.WriteLine("Escriba la ID del modelo del vehiculo que comprará.");
                                Console.WriteLine();

                                input = validar.readInput();
                                Console.Clear();

                                Console.WriteLine(modelo2[input].ToString());
                                modelo1 = modelo2[input];
                                break;

                            case 3:
                                Console.Clear();

                                if (local1 == null || modelo1 == null)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("NO SE HA SELECCIONADO UN LOCAL O MODELO CORRECTOS!!.");
                                    Console.WriteLine();
                                    break;
                                }

                                compra = Compra.createCompra(modelo1.ItemId, modelo1.PrecioVehiculo, modelo1.NameVehiculo, local1.Retiro);

                                Console.WriteLine();
                                Console.WriteLine("                               COMPRA FINALIZADA, GRACIAS POR PREFERIRNOS! c:");
                                Console.WriteLine();

                                local1 = null;
                                modelo1 = null;
                                Console.WriteLine(compra.ToString());
                                Console.WriteLine();
                                break;

                            case 4:
                            
                            Environment.Exit(0);
                            
                            break;

                            default:

                                break;
                        }
                    }
                    catch (InvalidCastException error)
                    {
                        Console.WriteLine(error);
                    }
                }
            }
        }
    }
