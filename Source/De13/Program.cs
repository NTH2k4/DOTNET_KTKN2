/*
Câu 1: Chủ đề OOP (Constructor Inheritance - Kế thừa constructor):

a) Định nghĩa lớp Person với constructor nhận tham số name. (1 điểm)
b) Tạo lớp Student kế thừa từ Person và sử dụng constructor của lớp cha. (1 điểm)
c) Tạo lớp Teacher kế thừa từ Person và sử dụng constructor của lớp cha. (1.5 điểm)
d) Tạo các đối tượng Student và Teacher, hiển thị thông tin. (1.5 điểm)
 

Câu 2: Chủ đề nâng cao (Delegate):

a) Định nghĩa delegate MathOperation nhận hai tham số.
b) Tạo phương thức Subtract(int a, int b) để thực hiện phép trừ.
c) Gọi delegate và hiển thị kết quả phép trừ.
d) Thực hiện phép tính với hai số bất kỳ.
*/
//----------------------------Câu 1----------------------------//
class Person {
    public string Name;
    public Person(string name) {
        Name = name;
    }
}
class Student : Person {
    public Student(string name) : base(name) {}
}
class Teacher : Person {
    public Teacher(string name) : base(name) {}
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
delegate int MathOperation(int a, int b);
class Math {
    public int Subtract(int a, int b) {
        return a - b;
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
                Student stu = new Student("Hieu");
                Teacher tec = new Teacher("Linh");
                Console.WriteLine("Student name: " + stu.Name + "\nTeacher name: " + tec.Name);
            }
            else if (lc == 2) {
                MathOperation opera = new Math().Subtract;
                Console.WriteLine("Result: " + opera(10, 4));
            }
            else break;
        }
    }
}