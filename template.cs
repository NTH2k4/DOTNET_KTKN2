/*

*/
//----------------------------Câu 1----------------------------//

//-------------------------------------------------------------//

//----------------------------Câu 2----------------------------//

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
                
            }
            else if (lc == 2) {
                
            }
            else break;
        }
    }
}