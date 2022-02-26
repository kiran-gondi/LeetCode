class HelloWorld {
    static void Main() {
        
        //1. Initialize
        int[] a0 = new int[5];
        int[] a1 = {1, 2, 3};
        
        //2. Get Length
        System.Console.WriteLine("The size of a1 is: ", a1.Length);
        
        //3. Access Element
        System.Console.WriteLine("The first element is: {0}", a1[0]);
        
        //4. Iterate all emements
        System.Console.WriteLine("[Version 1] The contents of a1 are:");
        for(int i = 0; i < a1.Length; i++){
            System.Console.WriteLine(" " + a1[i]);
        }
        
        //5. Modify Element
        a1[0] = 4;
        System.Console.WriteLine("[Version 2] Updated contents of a1 are:");
        for(int i = 0; i < a1.Length; i++){
            System.Console.WriteLine(" " + a1[i]);
        }
        
        //6. Sort
        Array.Sort(a1);
        System.Console.WriteLine("[Version 3] Sorted contents of a1 are:");
        for(int i = 0; i < a1.Length; i++){
            System.Console.WriteLine(" " + a1[i]);
        }
        
    }
}