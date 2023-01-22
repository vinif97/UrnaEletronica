using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.DTOs
{
    public class AddressDto
    {
        public string? StreetAddress { get; set; }
        public short Number { get; set; }
        public string? Complement { get; set; }
        public string? Reference { get; set; }
        public string? Zipcode { get; set; }
        public CityDto? City { get; set; }
    }
}
