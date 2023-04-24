class program {
  static void Main(string[] arg) {
        string[] A = UserInputType(Typee[]);
        string[] B = UserInputName(Namee[]);
        
        string search = Console.ReadLine();
        
        if(search == "Show All") {
            for(int i = 0;i < 10;i++) {
                Console.WriteLine("{0}",B[i]);
                Console.WriteLine();
            } if(search = A[i]) {
                Console.WriteLine("{0}",B[i]);
                Console.WriteLine();
            } else {
                Console.WriteLine("End");
            }
     }


  static string UserInputType(string[] Typee) {
        string[] input = new string[10];
    for (int i = 0;i < 10; i++) {
        input[i] = Console.ReadLine();
    }
        return input[10];
    }

    static string UserInputName(string[] Namee) {
        string[] input = new string[10];
    for (int i = 0;i < 10; i++) {
        input[i] = Console.ReadLine();
    }
        return input[10];
    }
}
}
    