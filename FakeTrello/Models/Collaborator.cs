using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Collaborator//manual join table
    {
        [Key]
        public int CollaboratorId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [Required]
        public int CardId { get; set; }
    }
}