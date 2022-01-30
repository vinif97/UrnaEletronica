using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace UrnaEletronica.Model
{
    public class Candidate
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(100)]
        public string ViceName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime RegistryDate { get; set; }

        [Required]
        [Key]
        [Range(10, 100, ErrorMessage = "Id do candidato deve ter 2 dígitos.")]
        public int Label { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
