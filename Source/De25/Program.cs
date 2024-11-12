/*
Câu 1: Chủ đề OOP (Lớp và Đối tượng):

a) Định nghĩa một lớp Car với thuộc tính Make và Model.
b) Tạo phương thức DisplayInfo() để hiển thị thông tin xe.
c) Tạo đối tượng từ lớp Car và gán giá trị cho các thuộc tính.
d) Gọi phương thức DisplayInfo().
 

Câu 2: Chủ đề nâng cao (Delegate):

a) Định nghĩa delegate MathOperation nhận vào hai số nguyên.
b) Tạo phương thức Add để thực hiện phép cộng.
c) Gọi delegate để thực hiện phép cộng hai số bất kỳ.
d) Hiển thị kết quả phép cộng.
*/
//----------------------------Câu 1----------------------------//
class Car {
    public string Make, Model;
    public void DisplayInfo() {
        Console.WriteLine("Info car\nMake: " + Make + "\nModel: " + Model);
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
delegate T MathOperation<T> (T a, T b);
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
                Car car = new Car();
                car.Make = "Titanium";
                car.Model = "MEC";
                car.DisplayInfo();
            }
            else if (lc == 2) {
                MathOperation<int> math = new Calculator().Add;
                Console.WriteLine("result: " + math(10, 29));
            }
            else break;
        }
    }
}