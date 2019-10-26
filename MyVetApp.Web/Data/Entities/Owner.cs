﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyVetApp.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        public User User { get; set; }
        public ICollection<Pet> Pets { get; set; }
        public ICollection<Agenda> Agendas{ get; set; }

    }
}
