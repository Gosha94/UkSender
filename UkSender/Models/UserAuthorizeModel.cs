using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkSender.Models
{
    [Table("UkSender.tUsers")]
    public class UserAuthorizeModel
    {
        [Key]
        public int Id           { get; set; }
        public string Login     { get; set; }
        public string Pwd       { get; set; }
    }
}
