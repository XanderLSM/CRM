using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Shared.Domain
{
    public class Blogcomment : BaseDomainModel
    {
        public string? Author { get; set; }
        public string? Text { get; set; }
        public int BlogpostId { get; set; }
        public Blogpost? Blogpost { get; set; }
    }
}
