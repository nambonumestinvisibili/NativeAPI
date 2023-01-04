﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        public Guid Guid { get; set; } = Guid.NewGuid();

    }
}
