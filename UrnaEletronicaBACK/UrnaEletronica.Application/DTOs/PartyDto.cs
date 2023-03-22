using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.DTOs
{
    public class PartyDto
    { 
        public string? Name { get; set; }
        public string? Acronym { get; set; }
        public string? Description { get; set; }
    }
}
