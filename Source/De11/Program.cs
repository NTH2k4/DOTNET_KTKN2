/*
Câu 1: Chủ đề OOP (Interface Implementation):

a) Định nghĩa interface IDrawable với phương thức Draw(). (1 điểm)
b) Tạo lớp Shape và Circle triển khai interface IDrawable. (1 điểm)
c) Ghi đè phương thức Draw() trong lớp Circle. (1.5 điểm)
d) Tạo đối tượng Circle và gọi phương thức Draw(). (1.5 điểm)
 

Câu 2: Chủ đề nâng cao 

a) Định nghĩa delegate CalculationHandler nhận hai tham số.
b) Tạo phương thức Add(int a, int b) để thực hiện phép cộng.
c) Gọi delegate và hiển thị kết quả phép cộng.
d) Thực hiện phép tính với hai số khác nhau.
*/
//----------------------------Câu 1----------------------------//
interface IDrawable {
    public void Draw();
}
class Shape : IDrawable
{
    public void Draw() {
        Console.WriteLine("Draw shape!");
    }
}
class Circle : IDrawable {
    public void Draw() {
        Console.WriteLine("Draw circle!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
delegate int CalculationHandler(int a, int b);
class Calculator {
    public int Add(int a, int b) {
        return a + b;
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
                Circle cicle = new Circle();
                cicle.Draw();
            }
            else if (lc == 2) {
                CalculationHandler cal = new Calculator().Add;
                Console.WriteLine("Result: " + cal(10, 21));
            }
            else break;
        }
    }
}