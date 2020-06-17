using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Web.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        public int AlbumId { get; set; }
        public string SongName { get; set; }
        public string Songdescription { get; set; }
        public DateTime SongTime { get; set; }        

    }
}
