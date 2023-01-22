using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.DTOs
{
    public class CitizenDto
    {
        public string? CPF { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
