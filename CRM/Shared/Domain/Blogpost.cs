using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Shared.Domain
{
    public class Blogpost : BaseDomainModel
    {
        public string? Title { get; set; }

        public string? Description { get; set; }
        public string? Content { get; set; }

        public string? Author { get; set; }

        public string? Url { get; set; }

        public String? Image { get; set; }

        public virtual Blogcategory? Category { get; set; }

        public int? CategoryId { get; set; }

        public virtual List<Blogcomment>? Comments { get; set; }

    }
}
