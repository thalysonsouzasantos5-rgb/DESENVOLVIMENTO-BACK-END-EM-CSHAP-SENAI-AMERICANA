using Microsoft.EntityFrameworkCore;
using SistemaERP.Classes.Entidades;

namespace SistemaERP.Classes.Contextos
{
    internal class ContextoUsuario : DbContext
    {
        //Propriedades
        public DbSet<Usuario> Usuarios { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesConstrucao)
        {
            string hostname = "dpg-daoqgcm0tbcc73fahoog-a.oregon-postgres.render.com";
            string porta = "5432";
            string nomeDoBancoDeDados = "dbdevback_hhzg";
            string nomeDoUsuario = "dbdevback_hhzg_user";
            string senha = "Xyr9PYu202zZsaO83Md1EJSMLwQTDQfi";

            string stringDeConexao = $"" +
                $"Host = {hostname};" +
                $"Port = {porta};" +
                $"Database = {nomeDoBancoDeDados};" +
                $"Username = {nomeDoUsuario};" +
                $"Password = {senha};" +
                $"SSL Mode = Require" +
                $"Trust Server Certificate=True;";

            opcoesConstrucao.UseNpgsql(stringDeConexao);
        }
            
        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Usuario>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.NomeDoUsuario);
                entidade.Property(e => e.SenhaDoUsuario);
                entidade.Property(e => e.Regra);
              
            });
        }
    }
}
