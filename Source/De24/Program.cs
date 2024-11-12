/*
Câu 1: Chủ đề OOP (Abstract Class Implementation):

a) Định nghĩa lớp trừu tượng Instrument với phương thức Play().
b) Tạo lớp Guitar kế thừa từ Instrument và triển khai phương thức Play().
c) Tạo lớp Piano kế thừa từ Instrument và triển khai phương thức Play().
d) Tạo danh sách các đối tượng Instrument và gọi phương thức Play().
 

Câu 2: Chủ đề nâng cao (Multicast Delegates):

a) Định nghĩa một delegate NotificationHandler để xử lý thông báo.
b) Tạo các phương thức EmailNotification và SMSNotification.
c) Đăng ký cả hai phương thức vào multicast delegate.
d) Kích hoạt delegate và kiểm tra các phương thức được gọi.
*/
//----------------------------Câu 1----------------------------//
abstract class Instrument {
    public abstract void Play();
}
class Guitar : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Playing guitar.");
    }
}
class Piano : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Playing piano.");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate void NotificationHandler();
class Notify {
    public void EmailNotification() {
        Console.WriteLine("You have an Email!");
    }
    public void SmsNotification() {
        Console.WriteLine("You have a SMS!");
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
                List<Instrument> ins = new List<Instrument> {
                    new Guitar(),
                    new Piano()
                };
                foreach (var item in ins) {
                    item.Play();
                }
            }
            else if (lc == 2) {
                Notify notify = new Notify();
                NotificationHandler noti = null;
                noti += notify.EmailNotification;
                noti += notify.SmsNotification;
                noti?.Invoke();
            }
            else break;
        }
    }
}