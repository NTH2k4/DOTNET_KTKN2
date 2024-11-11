/*
Câu 1: Chủ đề OOP (Abstract Class - Lớp trừu tượng):

a) Định nghĩa lớp trừu tượng Vehicle với phương thức Start() và Stop(). (1 điểm)
b) Tạo lớp Car kế thừa từ Vehicle và triển khai các phương thức. (1 điểm)
c) Tạo lớp Motorbike kế thừa từ Vehicle và triển khai các phương thức. (1.5 điểm)
d) Tạo danh sách các đối tượng Vehicle và gọi phương thức Start() và Stop(). (1.5 điểm)
 

Câu 2: Chủ đề nâng cao (Lambda Expressions):

a) Định nghĩa delegate CompareHandler. (1 điểm)
b) Sử dụng biểu thức lambda để so sánh hai chuỗi và trả về kết quả. (1 điểm)
c) Gọi biểu thức lambda với hai chuỗi bất kỳ. (1.5 điểm)
d) Giải thích cách biểu thức lambda rút gọn cú pháp của phương thức. (1.5 điểm)
*/
//----------------------------Câu 1----------------------------//
using System.Reflection.Metadata.Ecma335;

abstract class Vehicle {
    public abstract void Start();
    public abstract void Stop();
}
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is start!");
    }

    public override void Stop()
    {
        Console.WriteLine("Car is stop!");
    }
}
class Motorbike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Motobike is start!");
    }

    public override void Stop()
    {
        Console.WriteLine("Motobike is stop!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
delegate int CompareHandler(string a, string b);
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
                List<Vehicle> vehicles = new List<Vehicle> {
                    new Car(),
                    new Motorbike()
                };
                foreach (var item in vehicles) {
                    item.Start();
                    item.Stop();
                }
            }
            else if (lc == 2) {
                CompareHandler compare = (x, y) => string.Compare(x, y);
                string a = "Hello", b = "World";
                if (compare(a, b) > 0) {
                    Console.WriteLine("String a > string b");
                }
                else if (compare(a, b) == 0) {
                    Console.WriteLine("String a == string b");
                }
                else {
                    Console.WriteLine("String a < string b");
                }
            }
            else break;
        }
    }
}