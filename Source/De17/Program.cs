/*
Câu 1: Chủ đề OOP (Object Composition):

a) Định nghĩa lớp Engine với phương thức StartEngine().
b) Định nghĩa lớp Car với thuộc tính Engine.
c) Trong lớp Car, gọi phương thức StartEngine() từ đối tượng Engine.
d) Tạo đối tượng Car và kiểm tra phương thức StartEngine().
 

Câu 2: Chủ đề nâng cao:

a) Định nghĩa event OnOrderProcessed trong lớp OrderProcessor.
b) Tạo phương thức ProcessOrder() để kích hoạt event.
c) Đăng ký phương thức xử lý event để thông báo khi đơn hàng đã được xử lý.
d) Kích hoạt event và hiển thị kết quả xử lý đơn hàng.
*/
//----------------------------Câu 1----------------------------//
class Engine {
    public void StartEngine() {
        Console.WriteLine("Engine is started!");
    }
}
class Car {
    public Engine engine = new Engine();
    public void StartEngine() {
        engine.StartEngine();
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class OrderProcessor {
    public event Action<string> OnOrderProccessed;
    public void ProcessOrder() {
        OnOrderProccessed?.Invoke("Order is proccessed!");
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
                Car car = new Car();
                car.StartEngine();
            }
            else if (lc == 2) {
                OrderProcessor order = new OrderProcessor();
                order.OnOrderProccessed += delegate(string mess) {
                    Console.WriteLine(mess);
                };
                order.ProcessOrder();
            }
            else break;
        }
    }
}