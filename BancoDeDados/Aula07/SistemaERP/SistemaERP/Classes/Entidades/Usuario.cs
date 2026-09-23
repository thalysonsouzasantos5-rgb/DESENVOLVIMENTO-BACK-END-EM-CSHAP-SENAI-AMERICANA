using Microsoft.EntityFrameworkCore;
using SistemaERP.Classes.Entidades;

namespace SistemaERP.Classes.Entidades
{
    internal class Usuario
    {
        //Propiedades
        public int Id { get; set; }
        public string NomeDoUsuario { get; set; }
        public string SenhaDoUsuario { get; set; }
        public int Regra { get; set; }
        
        //Construtor
        public Usuario(string nomeDoUsuario, string senhaDoUsuario, int regra)
        {
            NomeDoUsuario = nomeDoUsuario;
            SenhaDoUsuario = senhaDoUsuario;
            Regra = rregra;
        }
    }
}
