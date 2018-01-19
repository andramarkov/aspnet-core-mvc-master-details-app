﻿using aspnetcoremaster.core.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace aspnetcoremaster.core.Model
{
    [Table("Inventory")]
    public class InventoryModel : BaseModel
    {
        [Required]
        [DisplayName("Order No")]
        public string InventoryCode { get; set; }

        [Required]
        public float TotalAmount { get; set; }
        public string Status { get; set; }
        public float GivenAmount { get; set; }
        public float ChangeAmount { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public CustomerModel CustomerModel { get; set; }
    }
}
