﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apresentacao.Entidades;
namespace Apresentacao
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options) { }

        public DbSet<Clientes> CLIENTES { get; set; }
    }

}
