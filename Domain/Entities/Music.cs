using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Table("Musics")]
    public class Music
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MusicID { get; set; }
        public string Name { get; set; }
        public byte[] File { get; set; }
    }
}
