﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace курсовая
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LiteratureServiceEntities : DbContext
    {
        public LiteratureServiceEntities()
            : base("name=LiteratureServiceEntities")
        {
        }

        private static LiteratureServiceEntities _context;
        public static LiteratureServiceEntities GetContext()
        {
            if (_context == null)
            {
                _context = new LiteratureServiceEntities();
            }
            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<Role_> Role_ { get; set; }
        public virtual DbSet<Source_> Source_ { get; set; }
        public virtual DbSet<SourceEditHistory> SourceEditHistory { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<User_> User_ { get; set; }
    }
}
