﻿using System;
using System.Collections.Generic;
using CapaNegocios;
using CapaEntidades;

namespace CapaVistas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetos que se usaran para 
            //consultar la capa de negocios, mostrar la lista de alumnos
            //y enviar los datos del alumno para agregar, editar y eliminar
            N_Alumnos negocios = new N_Alumnos();
            List<E_Alumno> listado = negocios.N_listaDeAlumnos();
            List<E_Alumno> listado1 = negocios.N_ListaDeMaestros();
            E_Alumno alumno = new E_Alumno();

            //Variable para detener o continuar el bucle While
            //y para saber que opción eligió el usuario
            int opcion = 1;

            //BUCLE WHILE
            while (opcion != 0)
            {
                //Menu de opciones que tiene el usuario
                Console.WriteLine("************ MENÚ ************" +
                    "\n1 - Ver lista de alumnos." +
                    "\n2 - Agregar un nuevo alumno." +
                    "\n3 - Editar un alumno existente." +
                    "\n4 - Eliminar un alumno existente." +
                    "\n5 - Ver lista de maestros." +
                    "\n0 - Salir del sistema.");
                opcion = int.Parse(Console.ReadLine());

                //"Limpiamos" la informacion del objeto alumno
                alumno = new E_Alumno();

                switch (opcion)
                {
                    //Caso 1 para mostrar lista de alumnos
                    case 1:
                        Console.WriteLine("************ LISTA DE ALUMNOS ************");

                        //Este foreach nos recorre la lista
                        // y nos muestra cada alumno
                        foreach (E_Alumno item in listado)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n\n\n");

                        break;

                    //Caso 2 para registrar un nuevo alumno
                    case 2:
                        Console.WriteLine("************ REGISTRANDO NUEVO ALUMNO ************");
                        //Consiguiendo nuevo ID
                        E_Alumno nuevoId = listado[listado.Count - 1];
                        alumno.Id = (nuevoId.Id + 1);
                        //Pedimos los datos del nuevo alumno
                        Console.WriteLine("Nombres: ");
                        alumno.Nombres = Console.ReadLine();
                        Console.WriteLine("Apellidos: ");
                        alumno.Apellidos = Console.ReadLine();
                        Console.WriteLine("Edad: ");
                        alumno.Edad = int.Parse(Console.ReadLine());

                        //Pedimos a la capa de negocios que nos agregue el alumno
                        negocios.N_agregarAlumno(alumno);

                        Console.WriteLine("Procesando..." +
                            "\nAgregando..." +
                            "\nAlumno registrado con éxito!");
                        Console.WriteLine("\n\n\n");

                        break;

                    //Caso 3 para editar la información de un alumno
                    case 3:
                        Console.WriteLine("************ EDITANDO ALUMNO ************");
                        //Para editar un alumno necesitamos su ID, para buscarlo en la lista
                        Console.WriteLine("ID:");
                        //Luego pedimos los datos que se quieren editar
                        alumno.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombres: ");
                        alumno.Nombres = Console.ReadLine();
                        Console.WriteLine("Apellidos: ");
                        alumno.Apellidos = Console.ReadLine();
                        Console.WriteLine("Edad: ");
                        alumno.Edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Promedio: ");
                        alumno.Promedio = double.Parse(Console.ReadLine());

                        //Pedimos a la capa de negocios que nos edite el alumno
                        negocios.N_editarAlumno(alumno);

                        Console.WriteLine("Procesando..." +
                            "\nEditando..." +
                            "\nAlumno editado con éxito!");
                        break;

                    //Caso 4 para eliminar un alumno
                    case 4:
                        Console.WriteLine("************ ELIMINANDO ALUMNO ************");
                        //Para eliminar un alumno nos basta con saber su ID
                        //Asi que lo solicitamos
                        Console.WriteLine("ID: ");
                        alumno.Id = int.Parse(Console.ReadLine());

                        //Pedimos a la capa de negocios que nos elimine el alumno
                        negocios.N_eliminarAlumno(alumno);
                        Console.WriteLine("Procesando..." +
                            "\nEliminando..." +
                            "\nAlumno eliminado con éxito!");
                        break;

                        //Caso 5 para mostrar lista de Maestros
                    case 5:
                        Console.WriteLine("************ LISA DE MAESTROS ************");

                        //Este foreach nos recorre la lista
                        // y nos muestra cada Maestro
                        foreach (E_Alumno item in listado1)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n\n\n");

                        break;

                    //Caso 0 para salir del bucle y que termine el programa
                    case 0:
                        Console.WriteLine("Adios!");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
