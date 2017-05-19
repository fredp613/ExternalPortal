﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternalPortal.Models
{
    public class AccountAddress
    {
        [Key]
        public Guid AccountAddressId { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public Account Account { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Guid UpdatedByInternalUserId { get; set; }
        [ForeignKey("UpdatedByInternalUserId")]
        public InternalUser InternalUpdatedBy { get; set; }
        public Guid CreatedByUserId { get; set; }
        public Guid UpdatedByUserId { get; set; }
        [ForeignKey("CreatedByUserId")]
        public User CreatedBy { get; set; }
        [ForeignKey("UpdatedByUserId")]
        public User UpdatedBy { get; set; }
    }
}
