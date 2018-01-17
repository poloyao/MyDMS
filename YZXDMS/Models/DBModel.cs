using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Models
{

    [Table("Users")]
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


    [Table("waitdetection")]
    public class WaitDetection
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "车辆信息ID")]
        public int CarInfoId { get; set; }
        [Display(Name = "检验流水号")]
        public string jylsh { get; set; }
        [Display(Name = "检测线号")]
        public Nullable<int> LineID { get; set; }
        [Display(Name = "状态")]
        public int Status { get; set; }
        [Display(Name = "操作时间")]
        public System.DateTime UDP { get; set; }
    }
}
