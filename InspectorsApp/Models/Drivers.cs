namespace InspectorsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        public int? PassportSerial { get; set; }

        public int? PassportNumber { get; set; }

        public int? PostCode { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string AddressLife { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(50)]
        public string JobName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
