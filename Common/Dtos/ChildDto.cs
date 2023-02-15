using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class ChildDto
    {
        public string Identity { get; set; } = null!;

        public string ParentId { get; set; } = null!;

        public DateTime BornDate { get; set; }

        public string Name { get; set; } = null!;
      
    }
}
