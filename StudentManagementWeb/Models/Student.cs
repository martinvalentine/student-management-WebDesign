namespace StudentManagementWeb.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        public string? Name { get; set; } //Họ tên
        public string? Email { get; set; } //Email
        public string? Password { get; set; }//Mật khẩu
        public Branch? Branch { get; set; }//Ngành học
        public Gender? Gender { get; set; }//Giới tính
        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi chinh quy
        public string? Address { get; set; }//Địa chỉ
        public DateTime DateOfBirth { get; set; }//Ngày sinh
    }
}
