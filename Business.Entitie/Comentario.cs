﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entitie
{
    [Table("Post")]
    public class Comentario
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid IdPost { get; set; }
        [ForeignKey("IdPost")]
        public virtual Post Post { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Mensagem { get; set; }

    }
}
