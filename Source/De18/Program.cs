/*
Câu 1: Chủ đề OOP (Polymorphism through Interfaces):

a) Định nghĩa interface IDrive với phương thức Drive().
b) Tạo lớp Car và Truck triển khai IDrive.
c) Tạo danh sách kiểu IDrive chứa các đối tượng Car và Truck.
d) Gọi phương thức Drive() trên từng đối tượng trong danh sách.
 

Câu 2: Chủ đề nâng cao:

a) Định nghĩa event OnButtonClick trong lớp Button.
b) Tạo phương thức Click() để kích hoạt event.
c) Đăng ký phương thức xử lý event để thông báo khi người dùng nhấn nút.
d) Kích hoạt event và hiển thị thông báo nhấn nút
*/
//----------------------------Câu 1----------------------------//
interface IDrive {
    public void Drive();
}
class Car : IDrive {
    public void Drive() {
        Console.WriteLine("Car is driving!");
    }
}
class Truck : IDrive
{
    public void Drive()
    {
        Console.WriteLine("Truck is driving!");
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Button {
    public event Action<string> OnButtonClick;
    public void Click() {
        OnButtonClick?.Invoke("Button is clicked!");
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
                List<IDrive> drives = new List<IDrive> {
                    new Car(), 
                    new Truck()
                };
                foreach (var item in drives) {
                    item.Drive();
                }
            }
            else if (lc == 2) {
                Button btn = new Button();
                btn.OnButtonClick += (mess) => Console.WriteLine(mess);
                btn.Click();
            }
            else break;
        }
    }
}