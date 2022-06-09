namespace WebAPIContactManagementEg.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        public int ContactId { get; set; }

        public int? GroupId { get; set; }

        [StringLength(40)]
        public string ContactName { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(1)]
        public string Discontinued { get; set; }

        public int? StateId { get; set; }
    }
}
