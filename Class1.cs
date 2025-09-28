using System;

namespace PersonalLifeNumberLib1
{
    public class LifeNumber
    {
        // Input
        public DateTime BirthDate { get; set; }

        // Ham tinh so chu dao
        public int GetLifePathNumber()
        {
            string digits = BirthDate.ToString("ddMMyyyy");
            int sum = 0;
            foreach (char c in digits)
                sum += (c - '0');

            // Rut gon den khi con 1 chu so (tru so 11, 22 giu nguyen)
            while (sum > 9 && sum != 11 && sum != 22)
            {
                int temp = 0;
                while (sum > 0)
                {
                    temp += sum % 10;
                    sum /= 10;
                }
                sum = temp;
            }
            return sum;
        }

        // Tra ve y nghia (Gợi ý nghề nghiệp)
        public string GetMeaning()
        {
            int num = GetLifePathNumber();
            switch (num)
            {
                case 1:
                    return "Số 1 (Người Tiên Phong): Phù hợp làm Lãnh đạo/Quản lý cấp cao, Doanh nhân, Giám đốc điều hành, Nhà thiết kế độc lập.";
                case 2:
                    return "Số 2 (Người Hợp Tác): Phù hợp làm Nhà ngoại giao, Cố vấn/Tham vấn, Giáo viên, Y tá, Thư ký, hoặc các công việc đòi hỏi làm việc nhóm và sự nhạy cảm.";
                case 3:
                    return "Số 3 (Người Sáng Tạo): Phù hợp làm Nghệ sĩ, Diễn viên, Nhà văn/Biên kịch, MC/Người truyền thông, Chuyên gia Marketing, Nhà thiết kế thời trang.";
                case 4:
                    return "Số 4 (Người Xây Dựng): Phù hợp làm Kỹ sư, Kiến trúc sư, Quản lý dự án, Kế toán, Chuyên gia công nghệ thông tin (IT), hoặc các công việc liên quan đến hệ thống và cấu trúc.";
                case 5:
                    return "Số 5 (Người Tự Do): Phù hợp làm Đại diện bán hàng, Hướng dẫn viên du lịch, Phóng viên, Nhà tổ chức sự kiện, Nhà phê bình ẩm thực, hoặc các công việc thay đổi liên tục.";
                case 6:
                    return "Số 6 (Người Chăm Sóc): Phù hợp làm Bác sĩ/Y tá, Chuyên gia trị liệu, Giáo viên, Nhà thiết kế nội thất, Cố vấn hôn nhân gia đình, hoặc các công việc vì cộng đồng.";
                case 7:
                    return "Số 7 (Người Nghiên Cứu): Phù hợp làm Nhà khoa học, Triết gia, Nhà phân tích dữ liệu, Thám tử, Giáo sư đại học, hoặc các công việc đòi hỏi sự chuyên sâu và cô độc.";
                case 8:
                    return "Số 8 (Người Quyền Lực): Phù hợp làm Giám đốc tài chính, Đầu tư, Môi giới bất động sản, Luật sư kinh doanh, Chính trị gia, hoặc các công việc về quyền lực và tiền bạc.";
                case 9:
                    return "Số 9 (Người Nhân Văn): Phù hợp làm Nhà hoạt động xã hội, Nhà từ thiện, Nhà trị liệu, Công tác xã hội, Bác sĩ, hoặc các công việc mang lại lợi ích lớn cho cộng đồng.";
                case 11:
                    return "Số 11 (Bậc Thầy Trực Giác): Phù hợp làm Cố vấn tinh thần, Diễn giả truyền cảm hứng, Nhà tâm lý học, Nhà sáng lập các phong trào xã hội.";
                case 22:
                    return "Số 22 (Bậc Thầy Xây Dựng): Phù hợp làm Nhà kiến trúc sư vĩ đại, Kỹ sư trưởng, Người lãnh đạo tập đoàn đa quốc gia, hoặc người tạo ra các dự án quy mô lớn cho thế giới.";
                default:
                    return "Không xác định.";
            }
        }
    }
}
