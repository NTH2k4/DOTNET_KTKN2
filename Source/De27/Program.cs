/*
Câu 1: Chủ đề OOP (Tính kế thừa):

a) Định nghĩa lớp Animal với thuộc tính Name.
b) Tạo lớp Dog kế thừa từ Animal.
c) Thêm thuộc tính Breed cho lớp Dog.
d) Tạo đối tượng Dog và hiển thị thông tin.
 

Câu 2: Chủ đề nâng cao (Events):

a) Định nghĩa một event OnFinished trong lớp Task.
b) Tạo phương thức CompleteTask() để kích hoạt event.
c) Đăng ký một phương thức xử lý event để hiển thị thông báo.
d) Kích hoạt event và hiển thị kết quả.
*/
//----------------------------Câu 1----------------------------//
class Animal {
    public string Name;
}
class Dog : Animal {
    public string Breed;
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Task {
    public event Action<string> OnFinished;
    public void CompleteTask() {
        OnFinished?.Invoke("Task is completed!");
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
                Dog dog = new Dog();
                dog.Name = "Mikky";
                dog.Breed = "Gau gau";
                Console.WriteLine($"Dog name: {dog.Name}\nBreed: {dog.Breed}");
            }
            else if (lc == 2) {
                Task task = new Task();
                task.OnFinished += (mess) => Console.WriteLine(mess);
                task.CompleteTask();
            }
            else break;
        }
    }
}