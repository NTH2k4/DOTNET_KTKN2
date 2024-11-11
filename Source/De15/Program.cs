/*
Câu 1: Chủ đề OOP (Exception Handling - Xử lý ngoại lệ):

a) Định nghĩa phương thức Divide(int a, int b) để thực hiện phép chia. (1 điểm)
b) Xử lý ngoại lệ DivideByZeroException khi b = 0. (1 điểm)
c) Sử dụng try-catch-finally để đảm bảo tài nguyên được giải phóng. (1.5 điểm)
d) Gọi phương thức Divide() và kiểm tra xử lý ngoại lệ. (1.5 điểm)
 

Câu 2: Chủ đề nâng cao

a) Định nghĩa event OnTaskCompleted trong lớp Task.
b) Tạo phương thức CompleteTask() để kích hoạt event.
c) Đăng ký phương thức xử lý event để in ra thông báo hoàn thành.
d) Kích hoạt event và kiểm tra kết quả.
*/
//----------------------------Câu 1----------------------------//
class Calculator {
    public int Divide(int a, int b) {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }
        finally {
            Console.WriteLine("Division operation completed!");
        }
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Task {
    public event Action<string> OnTaskCompleted;
    public void CompleteTask() {
        OnTaskCompleted?.Invoke("Task is completed!");
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
                Console.WriteLine("Result: " + new Calculator().Divide(12, 0));
            }
            else if (lc == 2) {
                Task task = new Task();
                task.OnTaskCompleted += (mess) => Console.WriteLine(mess);
                task.CompleteTask();
            }
            else break;
        }
    }
}