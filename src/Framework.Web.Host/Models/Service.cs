using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;    

namespace Framework.Web.Models
{
    public class Service
    {
        [Key]
        public string ServiceId { get; set; }
        [Required]
        public string ServiceName { get; set; }
        public string Describe { get; set; }
        [Required]
        public float ServiceCharge { get; set; }
        public string Cycle { get; set; }
        [Required]
        public string TypeService { get; set; }
        public string ResponsibleUnit { get; set; }
    }
}
