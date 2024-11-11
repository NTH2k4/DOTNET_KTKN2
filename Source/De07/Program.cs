/*
Câu 1: Chủ đề OOP (Constructor Overloading - Nạp chồng constructor):

a) Định nghĩa lớp Person với thuộc tính Name và Age. (1 điểm)
b) Tạo constructor mặc định không tham số. (1 điểm)
c) Tạo constructor có tham số để khởi tạo Name và Age. (1.5 điểm)
d) Tạo đối tượng Person với cả hai cách khởi tạo và hiển thị thông tin. (1.5 điểm)
 

Câu 2: Chủ đề Delegate:

a) Định nghĩa delegate MathOperation với hai tham số.
b) Tạo phương thức Divide(int a, int b) để thực hiện phép chia.
c) Gọi delegate và hiển thị kết quả phép chia.
d) Thực hiện tính toán với hai số bất kỳ.
*/
//----------------------------Câu 1----------------------------//
class Person {
    public string Name;
    public int Age;
    public Person(){}
    public Person(string name, int age) {
        Name = name;
        Age = age;
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
delegate int MathOperation(int a, int b);
class Math {
    public int Divide(int a, int b) {
        try {
            return a / b;
        } catch (DivideByZeroException) {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
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
                Person p1 = new Person();
                p1.Name = "Hieu";
                p1.Age = 20;
                Console.WriteLine("Person 1\nName: " + p1.Name + "\nAge: " + p1.Age);
                Person p2 = new Person("Dat", 21);
                Console.WriteLine("Person 2\nName: " + p2.Name + "\nAge: " + p2.Age);
            }
            else if (lc == 2) {
                MathOperation opera = new Math().Divide;
                Console.WriteLine("result: " + opera(4, 0));
            }
            else break;
        }
    }
}