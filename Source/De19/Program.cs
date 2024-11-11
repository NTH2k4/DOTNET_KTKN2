/*
Câu 1: Chủ đề OOP (Abstract vs Concrete Methods):

a) Định nghĩa lớp trừu tượng Appliance với phương thức trừu tượng TurnOn().
b) Tạo lớp Fan kế thừa từ Appliance và triển khai phương thức TurnOn().
c) Tạo lớp AirConditioner kế thừa từ Appliance và triển khai phương thức TurnOn().
d) Tạo đối tượng của Fan và AirConditioner, gọi phương thức TurnOn().
 

Câu 2: Chủ đề nâng cao:

a) Định nghĩa event OnFileUploaded trong lớp Uploader.
b) Tạo phương thức UploadFile() để kích hoạt event.
c) Đăng ký phương thức xử lý event để thông báo khi tệp đã được tải lên thành công.
d) Kích hoạt event và kiểm tra kết quả
*/
//----------------------------Câu 1----------------------------//
abstract class Appliance {
    public abstract void TurnOn();
}
class Fan : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Turn on fan.");
    }
}
class AirConditioner : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Turn on Air Conditioner.");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Uploader {
    public event Action<string> OnFileUploaded;
    public void UploadFile() {
        OnFileUploaded?.Invoke("File is uploaded!");
    }
}
//-------------------------------------------------------------//
class Program
{
    static void Main(string[] args)
    {
        while (true) {
            Console.Write("Lua chon cau: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int lc)) {
                Console.WriteLine("Vui long nhap so!");
                continue;
            }
            if (lc == 1) {
                Fan fan = new Fan();
                fan.TurnOn();
                AirConditioner air = new AirConditioner();
                air.TurnOn();
            }
            else if (lc == 2) {
                Uploader up = new Uploader();
                up.OnFileUploaded += (mess) => Console.WriteLine(mess);
                up.UploadFile();
            }
            else break;
        }
    }
}