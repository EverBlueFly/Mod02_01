using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace Mod02_01.Models
{
    public class Opera
    {
        [DisplayName("編號")]
        public int? OperaId { get; set; }
        [Required(ErrorMessage ="歌劇名稱不得為空白")]
        [StringLength(200)]  //最大長度
        [DisplayName("歌劇名稱")]
        public string Title { get; set; }
        [DisplayName("年代")]
        [CheckValidYear]
        public int? Year { get; set; }
        [Required]
        [DisplayName("作者")]
        public string Composer { get; set; }
    }
}