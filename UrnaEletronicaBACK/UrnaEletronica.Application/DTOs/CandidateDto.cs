using UrnaEletronica.Domain.Enum;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.DTOs
{
    public class CandidateDto
    {
        public string? FullName { get; set; }
        public PoliticalRole PoliticalRole { get; set; }
        public ElectionCycle? ElectionCycle { get; set; }
        public Party? Party { get; set; }
    }
}
