using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaPlayStore.Core.Domains
{
    public class Artist
    {
        public int ArtistId { get; set; }


        [Required(ErrorMessage = "Artist Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Artist Name must be between 3 and 50 chars")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Country is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Country must be between 3 and 20 chars")]
        public string Country { get; set; }
    }
}