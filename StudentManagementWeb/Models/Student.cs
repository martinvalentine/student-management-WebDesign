using System.ComponentModel.DataAnnotations;

namespace StudentManagementWeb.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên

        [Required(ErrorMessage = "Tên bắt buộc phải được nhập")]
        [RegularExpression(@"^[A-Za-z\s]{4,100}$")] 
        public string? Name { get; set; } //Họ tên

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+[A-Za-z0-9._%+-].com")] // Tất cả đuôi email đều đc
        public string? Email { get; set; } //Email

        [StringLength(100, MinimumLength = 8)]
        [Required(ErrorMessage = "Mk bắt buộc phải được nhập")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()_+])[A-Za-z\d!@#$%^&*()_+]{8,}$")]
        public string? Password { get; set; }//Mật khẩu

        [Required(ErrorMessage = "Ngành bắt buộc phải được nhập")]
        public Branch? Branch { get; set; }//Ngành học

        [Required(ErrorMessage = "Điểm không được để trống")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
        public string? Point { get; set; } //Điểm

        [Required(ErrorMessage = "Giới tính bắt buộc phải được nhập")]
        public Gender? Gender { get; set; }//Giới tính

        [Required(ErrorMessage = "Hệ bắt buộc phải được nhập")]
        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải được nhập")]
        public string? Address { get; set; }//Địa chỉ

        [Required(ErrorMessage = "Hãy nhập ngày tháng năm sinh")]

        [Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage = "Hãy nhập ngày tháng năm sinh trước 2005 và sau 1963")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }//Ngày sinh
    }
}
