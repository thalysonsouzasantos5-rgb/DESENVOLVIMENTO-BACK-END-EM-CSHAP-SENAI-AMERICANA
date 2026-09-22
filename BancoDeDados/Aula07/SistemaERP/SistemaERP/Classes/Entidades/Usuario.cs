using Microsoft.EntityFrameworkCore;
using SistemaERP.Classes.Entidades;

namespace SistemaERP.Classes.Entidades
{
    internal class Usuario
    {
        //Propiedades
        public int Id { get; set; }
        public string NomeDoUsuario { get; set; }
        public string Email { get; set; }
        public string SenhaDoUsuario { get; set; }
        public object Regra { get; internal set; }
    }
}
