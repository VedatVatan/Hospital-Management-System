﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Entity.Entities
{
    public class Hospital : BaseEntity
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int AdminId { get; set; }

        public virtual List<Doctor> Doctors { get; set; }
        public virtual Admin Admin { get; set; }

    }
}
