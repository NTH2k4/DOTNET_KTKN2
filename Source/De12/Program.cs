/*
Câu 1: Chủ đề OOP (Polymorphism - Tính đa hình):

a) Định nghĩa lớp Bird với phương thức Fly(). (1 điểm)
b) Tạo lớp Eagle kế thừa Bird và ghi đè phương thức Fly(). (1 điểm)
c) Tạo lớp Penguin kế thừa Bird và ghi đè phương thức Fly() (không bay được). (1.5 điểm)
d) Tạo danh sách các đối tượng Bird và gọi phương thức Fly(). (1.5 điểm)
 

Câu 2: Chủ đề nâng cao (Multicast Delegates):

a) Định nghĩa một multicast delegate NotificationHandler. (1 điểm)
b) Tạo các phương thức EmailNotification() và SmsNotification(). (1 điểm)
c) Đăng ký cả hai phương thức vào multicast delegate. (1.5 điểm)
d) Kích hoạt delegate và kiểm tra các phương thức được gọi. (1.5 điểm)
*/
//----------------------------Câu 1----------------------------//

class Bird {
    public virtual void Fly(){
        Console.WriteLine("Bird is flying");
    }
}
class Eagle : Bird {
    public override void Fly()
    {
        Console.WriteLine("Eagle is flying!");
    }
}
class Penguin : Bird {
    public override void Fly()
    {
        Console.WriteLine("Penguin can't fly!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
delegate void NotificationHandler();
class Notify {
    public void EmailNotification() {
        Console.WriteLine("Email notification!");
    }
    public void SmsNotification(){
        Console.WriteLine("Sms notification!");
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
                List<Bird> birds = new List<Bird> {
                    new Eagle(),
                    new Penguin()
                };
                foreach (var item in birds) {
                    item.Fly();
                }
            }
            else if (lc == 2) {
                NotificationHandler noti = null;
                Notify notify = new Notify();
                noti += notify.EmailNotification;
                noti += notify.SmsNotification;
                noti.Invoke();
            }
            else break;
        }
    }
}