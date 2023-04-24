class program {
  static void Main(string[] arg) {
        string[] A = UserInputType(Type);
        string[] B = UserInputName(Name);
        
        string search = Console.ReadLine();
        
        if(search == "Show All")
            for(int i = 0;i < 10;i++) {
                Console.WriteLine(name[i]);
            }
     }


  static string UserInputType(string[] Type) {
        string[] Type = new string[10];
    for (int i = 0;i < 10; i++) {
        Type[i] = Console.ReadLine();
    }
        return Type[10];
    }

    static string UserInputName(string[] Name) {
        string[] Name = new string[10];
    for (int i = 0;i < 10; i++) {
        Name[i] = Console.ReadLine();
    }
        return Name[10];
    }
}
    