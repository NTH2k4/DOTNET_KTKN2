/*
Câu 1: Chủ đề OOP (Tính đa hình):

a) Định nghĩa lớp Shape với phương thức Draw() không có nội dung. (1 điểm)
b) Tạo lớp Circle kế thừa Shape, ghi đè phương thức Draw() để vẽ hình tròn. (1 điểm)
c) Tạo lớp Rectangle kế thừa Shape, ghi đè phương thức Draw() để vẽ hình chữ nhật. (1.5 điểm)
d) Sử dụng đa hình để tạo danh sách các đối tượng Shape và gọi phương thức Draw(). (1.5 điểm)
 

Câu 2: Chủ đề nâng cao (Events):

a) Định nghĩa một event OnCompleted trong lớp Task. (1 điểm)
b) Tạo phương thức CompleteTask() để kích hoạt event OnCompleted. (1 điểm)
c) Đăng ký một phương thức xử lý event để thông báo khi task hoàn thành. (1.5 điểm)
d) Tạo một đối tượng của Task và kích hoạt event OnCompleted. (1.5 điểm)
*/
//----------------------------Câu 1----------------------------//
using System.Runtime.InteropServices;

internal class Shape{
    public virtual void Draw(){}
}
internal class Circle : Shape{
    public override void Draw() {
        Console.WriteLine("Draw circle!");
    }
}
internal class Rectangle : Shape {
    public override void Draw()
    {
        Console.WriteLine("Draw rectagle!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
internal class Task {
    public event Action<string> OnCompleted;
    public void CompleteTask(string mess){
        OnCompleted?.Invoke(mess);
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
                List<Shape> shapes = new List<Shape> {
                    new Circle(),
                    new Rectangle()
                };

                foreach (var shape in shapes) {
                    shape.Draw();
                }
            }
            else if (lc == 2) {
                Task task = new Task();
                task.OnCompleted += (mess) => {
                    Console.WriteLine(mess);
                };
                task.CompleteTask("Task is completed!");
            }
            else break;
        }
    }
}