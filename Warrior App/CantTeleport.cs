﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CantTeleport : Teleports
    {
        public string teleport()
        {
            return "Fails at Teleporting";
        }
    }
}
