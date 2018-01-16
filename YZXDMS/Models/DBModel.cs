using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Models
{

    [Table("users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }

        public string Account { get; set; }
        public string PWD { get; set; }
        public string Title { get; set; }
    }
}
