/*
Câu 1: Chủ đề OOP (Interface Inheritance):

a) Định nghĩa interface IMovable với phương thức Move().
b) Định nghĩa interface IFlyable kế thừa từ IMovable và thêm phương thức Fly().
c) Tạo lớp Helicopter triển khai interface IFlyable.
d) Tạo đối tượng Helicopter và kiểm tra các phương thức Move() và Fly().
 

Câu 2: Chủ đề nâng cao:

a) Định nghĩa event OnMessageReceived trong lớp Messenger.
b) Tạo phương thức ReceiveMessage() để kích hoạt event khi có tin nhắn đến.
c) Đăng ký phương thức xử lý event để hiển thị tin nhắn đã nhận.
d) Kích hoạt event và hiển thị nội dung tin nhắn.
*/
//----------------------------Câu 1----------------------------//
interface IMovable {
    void Move();
}
interface IFlyable : IMovable {
    public void Fly();
}
class Helicopter : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Helicopter is flying!");
    }

    public void Move()
    {
        Console.WriteLine("Helicopter is moving!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Messenger {
    public event Action<string> OnMessageReceived;
    public void ReceiveMessage() {
        OnMessageReceived?.Invoke("Message is received!");
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
                Helicopter helicopter = new Helicopter();
                helicopter.Fly();
                helicopter.Move();
            }
            else if (lc == 2) {
                Messenger mess = new Messenger();
                mess.OnMessageReceived += (mess) => Console.WriteLine(mess);
                mess.ReceiveMessage();
            }
            else break;
        }
    }
}