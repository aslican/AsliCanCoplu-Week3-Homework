using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternHW.Domain.Entities
{
    [Table("AnimationMovies")]
    public class AnimationMovie :BaseEntity
    {

        public string Studios { get; set; }
        public string Writer { get; set; }
        public string Stars { get; set; }
        public string BoxOffice { get; set; }

    }
}
