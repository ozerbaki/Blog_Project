﻿using HS4_Blog_Project.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS4_Blog_Project.Infrastructure.EntityTypeConfig
{
    internal abstract class BaseEntityConfig<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired(true); 
            builder.Property(x => x.DeleteDate).IsRequired(false); 
            builder.Property(x => x.UpdateDate).IsRequired(false); 
            builder.Property(x => x.Status).IsRequired(true);
        }
    }
}
