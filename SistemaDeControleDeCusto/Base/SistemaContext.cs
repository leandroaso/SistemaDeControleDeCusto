﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using SistemaDeControleDeCusto.Models;

namespace SistemaDeControleDeCusto.Base
{
    public class SistemaContext : DbContext
    {
        public SistemaContext() : base("SistemaContext2") { }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}