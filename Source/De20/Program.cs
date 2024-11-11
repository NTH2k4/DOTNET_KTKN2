/*
Câu 1: Chủ đề OOP (Inheritance and Composition):

a) Định nghĩa lớp Engine với phương thức Start().
b) Tạo lớp Vehicle có thuộc tính Engine.
c) Tạo lớp Car kế thừa Vehicle và gọi phương thức Start() từ Engine.
d) Tạo đối tượng Car và kiểm tra phương thức Start().
 

Câu 2: Chủ đề nâng cao:

a) Định nghĩa event OnLoginSuccess trong lớp LoginManager.
b) Tạo phương thức Login() để kích hoạt event khi đăng nhập thành công.
c) Đăng ký phương thức xử lý event để thông báo khi người dùng đăng nhập thành công.
d) Kích hoạt event và hiển thị kết quả.
*/
//----------------------------Câu 1----------------------------//
using System.Net.Http.Headers;

class Engine {
    public void Start() {
        Console.WriteLine("Engine is started.");
    }
}
class Vehicle {
    public Engine engine = new Engine();
}
class Car : Vehicle {
    public void Start() {
        base.engine.Start();
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class LoginManager {
    public event Action<string> OnLoginSuccess;
    public void Login() {
        OnLoginSuccess?.Invoke("Login successed!");
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
                car.Start();
            }
            else if (lc == 2) {
                LoginManager log = new LoginManager();
                log.OnLoginSuccess += (mess) => Console.WriteLine(mess);
                log.Login();
            }
            else break;
        }
    }
}