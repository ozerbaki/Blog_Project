﻿using HS4_Blog_Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS4_Blog_Project.Domain.Repositories
{
    public interface IAppUserRepository :IBaseRepository<AppUser>
    {
        //IAppUserRepository içinde kullanmak durumunda oldupumuz IBaseRepositoriy içerisinde olmayan meetotl imzalarını buraya yazıyoruz.
    }
}
