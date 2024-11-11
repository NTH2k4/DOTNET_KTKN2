/*
Câu 1: Chủ đề OOP (Virtual Methods - Phương thức ảo):

a) Định nghĩa lớp BaseClass với phương thức ảo Display(). (1 điểm)
b) Tạo lớp DerivedClass kế thừa BaseClass và ghi đè phương thức Display(). (1 điểm)
c) Tạo đối tượng của DerivedClass và gọi phương thức Display(). (1.5 điểm)
d) Minh họa sự khác biệt khi gọi phương thức thông qua lớp cha và lớp con. (1.5 điểm)
 

Câu 2: Chủ đề Event:
a) Định nghĩa một event OnProcessCompleted trong lớp Process.
b) Tạo phương thức CompleteProcess() để kích hoạt event.
c) Đăng ký một phương thức xử lý event để hiển thị thông báo khi quá trình hoàn tất.
d) Kích hoạt event và hiển thị kết quả.
*/
//----------------------------Câu 1----------------------------//
class BaseClass {
    public virtual void Display(){
        Console.WriteLine("Do something...");
    }
}
class DerivedClass : BaseClass {
    public override void Display()
    {
        Console.WriteLine("This is Derived class!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Process {
    public event Action<string> OnProcessCompleted;
    public void CompleteProcess(){
        OnProcessCompleted?.Invoke("On process completed");
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
                DerivedClass cls = new DerivedClass();
                cls.Display();
            }
            else if (lc == 2) {
                Process process = new Process();
                process.OnProcessCompleted += (mess) => {
                    Console.WriteLine(mess);
                };
                process.CompleteProcess();
            }
            else break;
        }
    }
}