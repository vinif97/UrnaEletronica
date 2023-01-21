using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Domain.Model
{
    public class State
    {
        public int StateId { get; set; }
        public string? StateName { get; set; }
        public Country? Country { get; set; }
        public ICollection<City>? Cities { get; set; }
    }
}
