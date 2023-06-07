﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Developer> Developers { get; set; }
        
    }
}
