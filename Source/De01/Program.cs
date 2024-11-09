/*
Câu 1: Chủ đề OOP (Lớp và đối tượng):
a) Định nghĩa một lớp Animal với các thuộc tính Name và Age. (1 điểm)
b) Tạo phương thức DisplayInfo() để hiển thị thông tin của đối tượng. (1 điểm)
c) Tạo lớp con Dog kế thừa từ Animal, thêm thuộc tính Breed. (1.5 điểm)
d) Tạo đối tượng từ lớp Dog và gọi phương thức DisplayInfo(). (1.5 điểm)
 
Câu 2: Chủ đề nâng cao (Delegate):
a) Định nghĩa một delegate có tên Operation nhận hai số nguyên và trả về kết quả. (1 điểm)
b) Viết một phương thức Add thực hiện phép cộng hai số nguyên. (1 điểm)
c) Sử dụng delegate để tham chiếu đến phương thức Add. (1.5 điểm)
d) Thực hiện delegate để tính tổng hai số 5 và 10. (1.5 điểm)
*/
//----------------------------Câu 1----------------------------//
internal class Animal
{
    public string Name;
    public int Age;
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name + "\nAge: " + Age);
    }
}

internal class Dog : Animal
{
    public string Breed;
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate int Operation(int a, int b);
internal class Math {
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
            int lc = int.Parse(Console.ReadLine());
            if (lc == 1) {
                Dog d1 = new Dog();
                d1.Name = "Micky";
                d1.Age = 3;
                d1.DisplayInfo();
            }
            else if (lc == 2) {
                Operation op = new Math().Add;
                Console.WriteLine("Result: " + op(5, 10));
            }
            else break;
        }
    }
}