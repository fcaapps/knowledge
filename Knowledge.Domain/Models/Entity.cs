﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Knowledge.Domain.Models
{
    public class Entity
    {
        public Guid Id { get; set; }
        public DateTime DateInclusao { get; set; }
        public bool IsDeletado { get; set; }

    }
}
