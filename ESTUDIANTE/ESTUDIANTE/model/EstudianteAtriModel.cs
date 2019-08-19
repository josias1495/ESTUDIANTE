using System;
using System.Collections.Generic;
using System.Text;
using ESTUDIANTE.service;

namespace ESTUDIANTE.model
{
    public class EstudianteAtriModel : Notificacion
    {
        private int _IDestudiante;

        public int IDEstudiante
        {
            get { return _IDestudiante; }
            set { _IDestudiante = value; OnPropertyChanged(); }
        }

        private string _NombreEstudiante;

        public string NombreEstudiante
        {
            get { return _NombreEstudiante; }
            set { _NombreEstudiante = value; OnPropertyChanged(); }
        }

        private string _ApellidoEstudiante;

        public string ApellidoEstudiante
        {
            get { return _ApellidoEstudiante; }
            set { _ApellidoEstudiante = value; OnPropertyChanged(); }
        }

        private string _Edad;

        public string Edad
        {
            get { return _Edad; }
            set { _Edad = value; OnPropertyChanged(); }
        }

        private string _Curso;

        public string Curso
        {
            get { return _Curso; }
            set { _Curso = value; OnPropertyChanged(); }
        }

        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; OnPropertyChanged(); }
        }

        private string _Responsable;

        public string Responsable 
        {
            get { return _Responsable; }
            set { _Responsable = value; OnPropertyChanged(); }
        }



     


    }
}
