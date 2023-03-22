using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.DTOs
{
    public class PartyDto
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [MaxLength(6)]
        public string? Acronym { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
