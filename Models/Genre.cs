using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaPlayStore.Core.Domains
{
    public class Genre
    {
        public int GenreId { get; set; }

        [Required(ErrorMessage = "Genre Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Genre Name must be between 3 and 50 chars")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description  is Required")]
        public string Desc { get; set; }
        public ICollection<Album> Albums { get; set; }

    }
}
