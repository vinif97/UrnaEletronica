using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace UrnaEletronica.Model
{
    public class Vote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Range(10, 101, ErrorMessage = "Id do candidato deve ter 2 dígitos.")]
        public int CandidateId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime VoteDate { get; set; }

        [ForeignKey("CandidateId")]
        public Candidate Candidate { get; set; }
    }
}
