using System.ComponentModel.DataAnnotations;

namespace UrnaEletronica.Application.DTOs
{
    public class StartElectionDto
    {
        [Range(1, short.MaxValue, ErrorMessage = "Invalid election year")]
        public ushort ElectionYear { get; set; }
        public ICollection<StartElectionCycleDto>? ElectionCycles { get; set; }
    }
}
