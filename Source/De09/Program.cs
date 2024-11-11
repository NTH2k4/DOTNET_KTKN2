/*
Câu 1: Chủ đề OOP (Inheritance - Kế thừa):

a) Định nghĩa lớp Animal với phương thức MakeSound(). (1 điểm)
b) Tạo lớp Dog kế thừa Animal và ghi đè phương thức MakeSound(). (1 điểm)
c) Tạo lớp Cat kế thừa Animal và ghi đè phương thức MakeSound(). (1.5 điểm)
d) Tạo danh sách các đối tượng Animal và gọi phương thức MakeSound(). (1.5 điểm)
 

Câu 2: Chủ đề nâng cao (Events and Delegates):

a) Định nghĩa một event OnDataReceived. (1 điểm)
b) Tạo phương thức kích hoạt event khi dữ liệu được nhận. (1 điểm)
c) Đăng ký một phương thức xử lý event để hiển thị thông báo. (1.5 điểm)
d) Kích hoạt event và kiểm tra phương thức xử lý. (1.5 điểm)
*/
//----------------------------Câu 1----------------------------//
using System.Runtime.InteropServices.Marshalling;

class Animal {
    public virtual void MakeSound(){
        Console.WriteLine("Animal make sound...");
    }
}
class Dog : Animal {
    public override void MakeSound(){
        Console.WriteLine("Gau gau...");
    }
}
class Cat : Animal {
    public override void MakeSound()
    {
        Console.WriteLine("Meow meow...");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Data {
    public event Action<string> OnDataReceived;
    public void ReceiveData(string mess) {
        OnDataReceived?.Invoke(mess);
    }
    public void ActiveEvent(string mess) {
        Console.WriteLine("Data received: " + mess);
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
                List<Animal> animals = new List<Animal> {
                    new Dog(),
                    new Cat()
                };
                foreach (var item in animals) {
                    item.MakeSound();
                }
            }
            else if (lc == 2) {
                Data data = new Data();
                data.OnDataReceived += data.ActiveEvent;
                data.ReceiveData("Hello World!");
            }
            else break;
        }
    }
}