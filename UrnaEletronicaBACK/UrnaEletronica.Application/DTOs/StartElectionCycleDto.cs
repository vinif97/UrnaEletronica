using System.ComponentModel.DataAnnotations;
using UrnaEletronica.Domain.Enum;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.DTOs
{
    public class StartElectionCycleDto
    {
        [Required(ErrorMessage = "Election political role cannot be null")]
        [EnumDataType(typeof(PoliticalRole))]
        public PoliticalRole PoliticalRole { get; set; }
    }
}
