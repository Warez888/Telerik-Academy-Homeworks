﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ComputersEntities : DbContext
    {
        public ComputersEntities()
            : base("name=ComputersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<Cpu> Cpus { get; set; }
        public virtual DbSet<Gpu> Gpus { get; set; }
        public virtual DbSet<StorageDevice> StorageDevices { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
