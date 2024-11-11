/*
Câu 1: Chủ đề OOP (Static Members - Thành viên tĩnh):

a) Định nghĩa lớp Counter với thuộc tính tĩnh count. 
b) Tạo phương thức tĩnh Increment() để tăng giá trị count. 
c) Tạo các đối tượng Counter và gọi phương thức Increment().
d) Kiểm tra giá trị của thuộc tính tĩnh count. 

Câu 2: Chủ đề Delegate:

a) Định nghĩa delegate CalculationHandler nhận hai tham số.
b) Tạo phương thức Add(int a, int b) để thực hiện phép cộng.
c) Gọi delegate và hiển thị kết quả phép cộng.
d) Thực hiện phép tính với hai số khác nhau.
*/
//----------------------------Câu 1----------------------------//
class Counter {
    public static int count = 0;
    public static void Increment(){
        count++;
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
                Counter.Increment();
                Console.WriteLine(Counter.count);
                Counter.Increment();
                Console.WriteLine(Counter.count);
            }
            else if (lc == 2) {
                CalculationHandler cal = new Calculator().Add;
                Console.WriteLine("Result: " + cal(10, 19));
            }
            else break;
        }
    }
}