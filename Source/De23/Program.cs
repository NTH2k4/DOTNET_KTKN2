/*
Câu 1: Chủ đề OOP (Constructor Chaining):

a) Định nghĩa lớp Person với constructor nhận một tham số name.
b) Tạo constructor thứ hai nhận cả name và age, sử dụng constructor chaining.
c) Gọi cả hai constructor để tạo đối tượng Person.
d) Hiển thị thông tin của đối tượng Person đã được tạo.
 

Câu 2: Chủ đề nâng cao:

a) Định nghĩa event OnGameOver trong lớp Game.
b) Tạo phương thức EndGame() để kích hoạt event khi trò chơi kết thúc.
c) Đăng ký phương thức xử lý event để hiển thị thông báo khi trò chơi kết thúc.
d) Kích hoạt event và kiểm tra thông báo trò chơi kết thúc.
*/
//----------------------------Câu 1----------------------------//
class Person {
    public string Name;
    public int Age;
    public Person(string name) {
        Name = name;
    }
    public Person(string name, int age) : this(name) {
        Age = age;
    }
}
//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//
class Game {
    public event Action<string> OnGameOver;
    public void EndGame() {
        OnGameOver?.Invoke("Game is over.");
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
                Person p1 = new Person("Hieu", 20);
                Console.WriteLine("Person 1\nName: " + p1.Name + "\nAge: " + p1.Age);
                Person p2 = new Person("Thien");
                Console.WriteLine("Person 2\nName: " + p2.Name + "\nAge: " + p2.Age);
            }
            else if (lc == 2) {
                Game game = new Game();
                game.OnGameOver += (mess) => Console.WriteLine(mess);
                game.EndGame();
            }
            else break;
        }
    }
}