using System;
using System.Collections.Generic;
using System.Data.Entity;
using UkSender.Models;

namespace UkSender.EFContexts
{
    public class MSSQLContext : DbContext
    {
        /// <summary>
        /// Контекст-подключение к БД, связано с подключением в App.config
        /// </summary>
        public MSSQLContext() : base("MeteringDataConnection")
        { }
        
        /// <summary>
        /// Набор данных-модель для записи показаний в БД
        /// </summary>
        public DbSet<MeteringDataModel> MeteringData { get; set; }
        
        /// <summary>
        /// Модель для строки подключения БД, отличных от MS SQL Server
        /// </summary>
        public DbSet<ConnectionStringModel> ConnectionString { get; set; }
        
        /// <summary>
        /// Метод очистки миграций
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MSSQLContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
