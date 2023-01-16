﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB_EF_CF.Models
{
    public class Group
    {
        public Group()
        {
            this.Donors = new HashSet<Donor>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Donor> Donors { get; set; }
    }
}
