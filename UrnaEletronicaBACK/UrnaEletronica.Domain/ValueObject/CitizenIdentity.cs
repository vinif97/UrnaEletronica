using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Domain.ValueObject
{
    public class CitizenIdentity
    {
        public string CPF { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public CitizenIdentity(string cpf, string firstName, string lastName)
        {
            FirstName = firstName;
            CPF = CleanCPF(cpf);
            LastName = lastName;
        }

        private string CleanCPF(string cpf)
        {
            return cpf.Trim().Replace("-", "").Replace(".", "");
        }
    }
}
