﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadekoBot.Services.Database.Models
{
    public class CommandCooldown : DbEntity
    {
        public int Seconds { get; set; }
        public string CommandName { get; set; }
    }
}
