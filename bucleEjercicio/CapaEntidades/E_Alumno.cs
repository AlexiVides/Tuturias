﻿using System;

namespace CapaEntidades
{
    public class E_Alumno
    {
        private int id;
        private string nombres;
        private string apellidos;
        private int edad;
        private double promedio;

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Promedio { get => promedio; set => promedio = value; }

        public E_Alumno() { }

        public E_Alumno(int id, string nombres, string apellidos, int edad, double promedio)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
            this.promedio = promedio;
        }
        public E_Alumno(int id, string nombres, string apellidos, int edad)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
        }
        
        public override string ToString()
        {
            return string.Format("Id: {0}, Nombre: {1} {2}, Edad: {3}, Promedio: {4}", id, nombres, apellidos, edad, promedio);
        }
        

    }
}
