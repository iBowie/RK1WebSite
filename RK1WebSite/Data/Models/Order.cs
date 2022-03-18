using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace RK1WebSite.Data.Models
{
    public class Order
    {
        [BindNever]
        public int ID { get; set; }
        [Display(Name = "Имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не более 25 символов")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина фамилии не более 25 символов")]
        public string Surname { get; set; }
        [Display(Name = "Адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина адреса не более 35 символов")]
        public string Address { get; set; }
        [Display(Name = "Номер телефона")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина номера телефона не более 20 символов")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Адрес электронной почты")]
        [StringLength(25)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Длина электронной почты не более 25 символов")]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> Details { get; set; } = new List<OrderDetail>();
    }
}
