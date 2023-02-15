using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class DetailDto
    {
        
        public string Idenentity { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime BornDate { get; set; }

        public string Gender { get; set; } = null!;

        public string Hmo { get; set; } = null!;
    }
}
