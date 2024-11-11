/*
Câu 1: Chủ đề OOP (Interface with Multiple Inheritance):

a) Định nghĩa interface IDriveable với phương thức Drive(). (1 điểm)
b) Định nghĩa interface IFlyable với phương thức Fly(). (1 điểm)
c) Tạo lớp CarPlane triển khai cả hai interface IDriveable và IFlyable. (1.5 điểm)
d) Tạo đối tượng CarPlane và gọi các phương thức Drive() và Fly(). (1.5 điểm)
 

Câu 2: Chủ đề nâng cao:

a) Định nghĩa event OnDownloadCompleted trong lớp Downloader.
b) Tạo phương thức FinishDownload() để kích hoạt event.
c) Đăng ký phương thức xử lý event để thông báo khi quá trình tải xuống kết thúc.
d) Kích hoạt event và hiển thị thông báo.
*/
//----------------------------Câu 1----------------------------//
using System.Net;

interface IDriveable {
    public void Drive();
}
interface IFlyable {
    public void Fly();
}
class CarPlane : IDriveable, IFlyable
{
    public void Drive()
    {
        Console.WriteLine("CarPlane is drive!");
    }

    public void Fly()
    {
        Console.WriteLine("CarPlane is fly!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class DownLoader {
    public event Action<string> OnDownloadCompleted;
    public void FinishDownload() {
        OnDownloadCompleted?.Invoke("Download completed!");
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
                CarPlane carPlane = new CarPlane();
                carPlane.Drive();
                carPlane.Fly();
            }
            else if (lc == 2) {
                DownLoader downLoader = new DownLoader();
                downLoader.OnDownloadCompleted += (mess) => Console.WriteLine(mess);
                downLoader.FinishDownload();
            }
            else break;
        }
    }
}