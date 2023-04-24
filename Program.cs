class program {
  static void Main(string[] arg) {

    string[] Type = new string[10];
    for (int i = 0;i < 10; i++) {
        Type[i] = Console.ReadLine();
    }
    Console.WriteLine(Type[1]);
     }

  static string UserInputType(string[] Type) {
        string input;

        while(true) {
        Console.Write("Input Item Type : ");
        input = Console.ReadLine();
        } 
        return input;
    }

    static string UserInputItem(string[] BagAll) {
        string input;

        while(true) {
        Console.Write("Input Item Name : ");
        input = Console.ReadLine();
        } 
        return input;
    }
static void PrintBoard(char[] Type) {
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", Type[0],Type[1],Type[2]);
        Console.WriteLine("_____|_____|_____");
}
}