/*
Câu 1: Chủ đề OOP (Tính kế thừa):

a) Định nghĩa lớp Employee với thuộc tính Name và Position. (1 điểm)
b) Tạo lớp Manager kế thừa từ Employee, thêm thuộc tính Department. (1 điểm)
c) Tạo lớp Developer kế thừa từ Employee, thêm thuộc tính ProgrammingLanguage. (1.5 điểm)
d) Tạo các đối tượng Manager và Developer, hiển thị thông tin của từng đối tượng. (1.5 điểm)
 

Câu 2: Chủ đề nâng cao (Delegate & Events):

a) Định nghĩa một delegate CalculationHandler nhận vào hai số nguyên. (1 điểm)
b) Định nghĩa phương thức Multiply để thực hiện phép nhân. (1 điểm)
c) Sử dụng delegate để gọi phương thức Multiply và thực hiện phép tính. (1.5 điểm)
d) Định nghĩa event OnCalculationComplete, kích hoạt event khi phép tính hoàn thành (1.5 điểm)
*/
//----------------------------Câu 1----------------------------//
internal class Employee {
    public string Name, Position;
}
internal class Manager : Employee {
    public string Department;
}
internal class Developer : Employee {
    public string ProgrammingLanguage;
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
public delegate int CalculationHandler(int a, int b);
internal class Task {
    public int Multiply(int a, int b) {
        return a * b;
    }
    public event Action<string> OnCalculationComplete;
    public void CompleteTask(string mess) {
        OnCalculationComplete?.Invoke(mess);
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
                Manager manage = new Manager {
                    Name = "Nguyen Trung Hieu",
                    Position = "Giam doc",
                    Department = "201a"
                };
                Developer develop = new Developer{
                    Name = "Vu Dinh Dat",
                    Position = "Pho giam doc",
                    ProgrammingLanguage = "C#"
                };
                Console.WriteLine("MANAGER\nName: " + manage.Name + "\nPosition: " + manage.Position + "\nDepartment: " + manage.Department);
                Console.WriteLine("DEVELOPER\nName: " + develop.Name + "\nPosition: " + develop.Position + "\nDepartment: " + develop.ProgrammingLanguage);

            }
            else if (lc == 2) {
                Task task = new Task();
                CalculationHandler cal = task.Multiply;
                task.OnCalculationComplete += (mess) => {
                    Console.WriteLine(mess);
                };
                int result = cal(5, 10);
                task.CompleteTask("Result is: " + result);
            }
            else break;
        }
    }
}