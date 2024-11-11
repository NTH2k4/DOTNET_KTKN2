/*
Câu 1: Chủ đề OOP (Abstraction):

a) Định nghĩa một lớp trừu tượng Appliance với phương thức TurnOn() và TurnOff(). (1 điểm)
b) Tạo lớp WashingMachine kế thừa từ Appliance và triển khai các phương thức. (1 điểm)
c) Tạo lớp Refrigerator kế thừa từ Appliance và triển khai các phương thức. (1.5 điểm)
d) Tạo danh sách các đối tượng Appliance và gọi các phương thức TurnOn() và TurnOff(). (1.5 điểm)


Câu 2: Chủ đề nâng cao (Anonymous Methods & Lambda Expressions):

a) Định nghĩa delegate MathOperation. (1 điểm)
b) Sử dụng phương thức vô danh (anonymous method) để tính phép chia. (1 điểm)
c) Sử dụng biểu thức lambda để thực hiện phép nhân. (1.5 điểm)
d) So sánh cách sử dụng giữa phương thức vô danh và biểu thức lambda. (1.5 điểm)
*/
//----------------------------Câu 1----------------------------//
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

abstract class Appliance {
    public abstract void TurnOn();
    public abstract void TurnOff();
}
class WashingMachine : Appliance
{
    public override void TurnOff()
    {
        Console.WriteLine("Washing Machine is turn off!");
    }

    public override void TurnOn()
    {
        Console.WriteLine("Washing Machine is turn on!");
    }
}
class Refrigerator : Appliance
{
    public override void TurnOff()
    {
        Console.WriteLine("Refrigerator is turn off!");
    }

    public override void TurnOn()
    {
        Console.WriteLine("Refrigerator is turn on!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
delegate int MathOperation(int a, int b);
//-------------------------------------------------------------//
class Program {
    static void Main(string[] args) {
        while (true) {
            Console.Write("Lua chon cau: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int lc)) {
                Console.WriteLine("Vui long nhap so!");
                continue;
            }
            if (lc == 1) {
                List<Appliance> app = new List<Appliance> {
                    new WashingMachine(), 
                    new Refrigerator()
                };
                foreach (var item in app) {
                    item.TurnOn();
                    item.TurnOff();
                }
            }
            else if (lc == 2) {
                MathOperation divide = delegate(int a, int b) {
                    return a / b;
                };
                MathOperation multiply = (x, y) => x * y;
                Console.WriteLine("Anonymous method result: " + divide(12, 4));
                Console.WriteLine("Lambda expression result: " + multiply(12, 3));
            }
            else break;
        }
    }
}