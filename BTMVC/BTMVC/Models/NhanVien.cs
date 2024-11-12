using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTMVC.Models
{
    public class NhanVien
    {
        [Required(ErrorMessage = "Mã Nhân Viên là bắt buộc.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ tên là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Họ tên không được vượt quá 100 ký tự.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ngày sinh là bắt buộc.")]
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }

        [Required(ErrorMessage = "Giới tính là bắt buộc.")]
        [RegularExpression("^(Male|Female|Other)$", ErrorMessage = "Giới tính không hợp lệ.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Điện thoại là bắt buộc.")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Hệ số lương là bắt buộc.")]
        [Range(0.0, double.MaxValue, ErrorMessage = "Hệ số lương phải lớn hơn hoặc bằng 0.")]
        public double SalaryCoefficient { get; set; }

        [Required(ErrorMessage = "Lương là bắt buộc.")]
        [Range(0.0, double.MaxValue, ErrorMessage = "Lương phải lớn hơn hoặc bằng 0.")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "Tên phòng là bắt buộc.")]
        [StringLength(50, ErrorMessage = "Tên phòng không được vượt quá 50 ký tự.")]
        public string DepartName { get; set; }
    }
}