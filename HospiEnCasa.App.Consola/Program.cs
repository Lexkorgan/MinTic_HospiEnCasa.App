using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Consola
{
    class Program
    {

private static IRepositorioPaciente _repoPaciente= new RepoPaciente(new AppContext())


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!!");
            //AddPaciente();
        }BuscarPaciente(1);


        private static void AddPaciente()´
        {
            var paciente = new Paciente{
                Nombre="Nicolay",
                Apellidos="Perez",
                NumeroTelefono = " 3001455",
                Genero =  Genero.Masculino,
                Direccion = " Callle 64 N 112 B 22",
                Longitud = 5.44554,
                Latitud = -474196,
                Ciudad = "Manizales",
                FechaNaciemiento = new DateTime(1990, 04, 12)
            };
            _repoPaciente.AddPaciente(paciente);

        }

        private static void BuscarPaciente(ind idPaciente)
        {
            var paciente = _repoPaciente.getPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+ " "+paciente.Apellidos);

        }

    }
}
