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
        public int CandidateId { get; set; }

        public DateTime VoteDate { get; set; }

        [ForeignKey("CandidateId")]
        public Candidate Candidate { get; set; }
    }
}
