﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace diceware_netapi.Models
{
    public class Wordlist
    {
        [Key]
        public int Roll { get; set; }
        public string Word { get; set; }
    }
}
