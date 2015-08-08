using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entitie
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Corpo { get; set; }

        public List<Comentario> Comentarios { get; set; }

    }
}
