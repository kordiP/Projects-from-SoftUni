﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSite.Services.Contracts
{
    public interface ICategoriesService
    {
        int CreateCategory(string name);
    }
}
