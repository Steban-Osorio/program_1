using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace G10_F4_StebanOsorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir = "N";
            List<Participantes> listParticipantes = new List<Participantes>();
            List<Categoria> listCategoria = new List<Categoria>();
            while (salir != "S")
            {
                Participantes participantes = new Participantes();
                Categoria categoria = new Categoria();
                Informacion info = new Informacion();
                Console.WriteLine(info.nombreDelPrograma);
                Console.WriteLine(info.autor);
                Console.WriteLine(info.usoDeLaAplicacion);
                Console.WriteLine(info.menu);
                int menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine(info.usoDeLaAplicacion);
                    Console.WriteLine(info.menuRegitrar);
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion == 1)
                    {
                        Console.WriteLine(info.mensajeParticipantes);
                        int indentificacion = Convert.ToInt32(Console.ReadLine());
                        string nombre = Console.ReadLine();
                        int categoriaParticipante = Convert.ToInt32(Console.ReadLine());

                        participantes.setIdentificacion(indentificacion);
                        participantes.setNombre(nombre);
                        participantes.setCategoria(categoriaParticipante);
                        listParticipantes.Add(participantes);
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine(info.mensajeCategoria);
                        string nombreCategoria = Console.ReadLine();
                        double valorPremio = Convert.ToDouble(Console.ReadLine());
                        string consultaCategoria = Console.ReadLine();
                        categoria.setNombreCategoria(nombreCategoria);
                        categoria.setValorPremio(valorPremio);
                        categoria.setconsultaCategoria(consultaCategoria);
                        listCategoria.Add(categoria);
                    }
                    else if (opcion == 3)
                    {
                        Console.WriteLine(info.mensajeConsulta);
                        string CategoriaConsul = Console.ReadLine();
                        categoria.setconsultaCategoria(CategoriaConsul);
                        listCategoria.Add(categoria);
                    }
                    else if (opcion == 4) 
                    {
                        Console.WriteLine(info.mensajeModificacion);
                        string Modificacion = Console.ReadLine();
                        categoria.setModificacion(Modificacion);
                        listCategoria.Add(categoria);
                    }

                }
                    else
                    {
                        Console.WriteLine(info.mensajeError);
                    }
                } else if (menu == 2){
                    Console.WriteLine(info.usoDeLaAplicacion);
                    Console.WriteLine(info.menuImprimir);
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion == 1)
                    {
                        Console.WriteLine(info.tituloParticipantes);
                        for (int i = 0; i < listParticipantes.Count; i++)
                        {
                            Console.WriteLine(listParticipantes[i].identificacion + " "
                                + listParticipantes[i].nombre + " "
                                + listParticipantes[i].categoria);
                        }
                    } else if (opcion == 2){
                        Console.WriteLine(info.tituloCategoria);
                    for (int i = 0; i < listCategoria.Count; i++)
                    {
                        Console.WriteLine(listCategoria[i].nombreCategoria + " "
                            + listCategoria[i].valorPremio);
                         
                        }

                    } else {
                        Console.WriteLine(info.mensajeError);
                    }
                } else {
                    Console.WriteLine(info.mensajeError);
                }
                
                Console.WriteLine(info.mensajeSalir);
                salir = Convert.ToString(Console.ReadLine());
            }
        }
    }
}
