using System.ComponentModel.DataAnnotations;

namespace UrnaEletronica.Model
{
    public class CandidateDelete
    {
        [Range(10, 99, ErrorMessage = "Id do candidato deve ter 2 dígitos.")]
        public int Label { get; set; }
    }
}
