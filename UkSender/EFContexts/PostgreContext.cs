using System.Data.Entity;
using UkSender.Models;

namespace UkSender.EFContexts
{
    public class PostgreContext : DbContext
    {
        private const string _schema = "UkSender";

        public PostgreContext(string connectionString)
          : base(connectionString)
        { }
        public DbSet<UserAuthorizeModel> UsersAuthorizeData { get; set; }        
        /// <summary>
        /// Набор данных-модель для письма
        /// </summary>
        public DbSet<EmailModel> EmailData { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema(_schema);
            base.OnModelCreating(builder);
        }
    }
}
