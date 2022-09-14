using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MyApplication.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

       
        public string UserName { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        public string Company { get; set; }
    }
}
