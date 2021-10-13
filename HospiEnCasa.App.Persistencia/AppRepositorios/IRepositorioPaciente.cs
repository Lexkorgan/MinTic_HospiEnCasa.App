using System.Collections.Generic;
using HospiEnCasa.App.Dominio;


namespace HospiEnCasa.App.Dominio
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int IdPaciente);
        Paciente Getpaciente(int idPaciente);
    }
}
