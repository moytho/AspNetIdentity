using AspNetIdentity.WebApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetIdentity.WebApi.Models
{
    public class Clinica
    {
        [Key]
        public int CodigoClinica { get; set; }
        public string Nombre{get;set;}
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }

    }
}