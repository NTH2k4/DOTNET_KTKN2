/*
Câu 1: Chủ đề OOP (Encapsulation - Tính đóng gói):
a) Định nghĩa lớp BankAccount với thuộc tính balance.
b) Tạo phương thức Deposit và Withdraw để thay đổi giá trị của balance.
c) Đảm bảo balance không thể bị chỉnh sửa trực tiếp từ bên ngoài.
d) Tạo đối tượng BankAccount và thực hiện các phương thức để kiểm tra tính

Câu 2: Chủ đề nâng cao:
a) Định nghĩa event OnTemperatureChanged trong lớp Thermometer.
b) Tạo phương thức UpdateTemperature() để kích hoạt event khi nhiệt độ thay đổi.
c) Đăng ký phương thức xử lý event để hiển thị nhiệt độ mới.
d) Kích hoạt event và hiển thị giá trị nhiệt độ mới.
*/
//----------------------------Câu 1----------------------------//
using System.ComponentModel;

class BankAccount {
    private double balance;
    public double Balance {
        get { return balance; }
        private set { balance = value; }
    }
    public void Deposit(int val) {
        if (val > 0) balance += val;
    }
    public void Withdraw(int val) {
        if (val >= 0 && val <= balance) balance -= val;
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Thermometer {
    public event Action<string> OnTemperatureChanged;
    public void UpdateTemperature() {
        OnTemperatureChanged?.Invoke("Temperature is changed!");
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
                BankAccount bank = new BankAccount();
                bank.Deposit(2000);
                Console.WriteLine("Balance: " + bank.Balance);
                bank.Withdraw(1234);
                Console.WriteLine("Balance: " + bank.Balance);
            }
            else if (lc == 2) {
                Thermometer ther = new Thermometer();
                ther.OnTemperatureChanged += (mess) => Console.WriteLine(mess);
                ther.UpdateTemperature();
            }
            else break;
        }
    }
}