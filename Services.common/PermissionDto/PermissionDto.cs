﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.common.PermissionDto
{
    public class PermissionDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}