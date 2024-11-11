/*
Câu 1: Chủ đề OOP (Encapsulation - Tính đóng gói):

a) Định nghĩa lớp Account với thuộc tính balance (được encapsulate). (1 điểm)
b) Tạo các phương thức Deposit và Withdraw để cập nhật giá trị balance. (1 điểm)
c) Đảm bảo tính bảo mật cho thuộc tính balance khi không cho phép trực tiếp thay đổi từ bên ngoài. (1.5 điểm)
d) Tạo đối tượng Account và kiểm tra các phương thức Deposit và Withdraw. (1.5 điểm)
 

Câu 2: Chủ đề Delegate:

a) Định nghĩa delegate MathOperation nhận hai tham số.
b) Tạo phương thức Subtract(int a, int b) để thực hiện phép trừ.
c) Gọi delegate và hiển thị kết quả phép trừ.
d) Thực hiện tính toán với hai số bất kỳ.
*/
//----------------------------Câu 1----------------------------//
internal class Account {
    private double balance;
    public double Balance {
        get { return balance; }
        private set { balance = value; }
    }
    public void Deposit(double val) {
        if (val > 0) {
            balance += val;
        }
    }
    public void Withdraw(double val) {
        if (val > 0 && val <= balance) {
            balance -= val;
        }
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
delegate int MathOperation(int a, int b);
internal class Math {
    public int Substract(int a, int b) {
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
                Account acc = new Account();
                acc.Deposit(2000);
                Console.WriteLine("Balance: " + acc.Balance);
                acc.Withdraw(1250);
                Console.WriteLine("Balance: " + acc.Balance);
            }
            else if (lc == 2) {
                MathOperation opera = new Math().Substract;
                Console.WriteLine("Result: " + opera(10, 2));
            }
            else break;
        }
    }
}