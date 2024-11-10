/*
Câu 1: Chủ đề OOP (Interface):

a) Định nghĩa một interface IMovable với phương thức Move(). 
b) Tạo lớp Car và Bike triển khai interface IMovable.
c) Ghi đè phương thức Move() cho từng lớp.
d) Tạo danh sách các đối tượng IMovable và gọi phương thức Move(). 
 

Câu 2: Chủ đề Delegate:

a) Định nghĩa delegate OperationHandler.
b) Tạo phương thức Multiply(int a, int b) để thực hiện phép nhân.
c) Gọi delegate và hiển thị kết quả.
d) Kiểm tra kết quả phép nhân với hai số bất kỳ.
*/
//----------------------------Câu 1----------------------------//
interface IMovable {
    public void Move();
}
class Car : IMovable {
    public void Move() {
        Console.WriteLine("Car is moving!");
    }
}
class Bike : IMovable {
    public void Move() {
        Console.WriteLine("Bike is moving!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
delegate int OperationHandler(int a, int b);
internal class Operation {
    public int Multiply(int a, int b) {
        return a * b;
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
                List<IMovable> movables = new List<IMovable>{
                    new Car(),
                    new Bike()
                };
                foreach (var item in movables) {
                    item.Move();
                }
            }
            else if (lc == 2) {
                OperationHandler opera = new Operation().Multiply;
                Console.WriteLine("Resul: " + opera(12, 34));
            }
            else break;
        }
    }
}