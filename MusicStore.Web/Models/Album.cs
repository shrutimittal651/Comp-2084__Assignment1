using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Web.Models
{
    public class Album
    {
        
        [Key]
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public DateTime AlbumReleaseDate { get; set; }
        public string Singer { get; set; }
        public virtual ICollection<Song> Song { get; set; }
    }
}
