


class HelloWorld {
    static void Main() {
        // 1. initialize
        ArrayList v0 = new ArrayList();
        ArrayList v1; //v1==null
        System.Console.WriteLine("v0: {0}", v0.Count);
        
        //2. Cast an array to List
        int[] a = {0, 1, 2, 3, 4};
        v1 = new ArrayList(a);
        System.Console.WriteLine("v1: {0}", v1.Count);
        
        //3. Make a copy
        ArrayList v2 = v1; //another reference to v1
        System.Console.WriteLine("v2: {0}", v2.Count);
        ArrayList v3 = new ArrayList(v1); //make an actual copy of v1
        System.Console.WriteLine("v3: {0}", v3.Count);
        
        //3. Get Length
        System.Console.WriteLine("The size of v1 is: {0}", v1.Count);
        
        //4. Access element
        System.Console.WriteLine("The first element of v1 is: {0}", v1[0]);
        
        //5. Iterate the arraylist
        System.Console.WriteLine("[Version 1] The contents of v1 are: ");
        for(int i = 0; i < v1.Count; i++){
            System.Console.WriteLine(" " + v1[i]);
        }
        
        //6. modify element
        v2.Insert(0, 5); //modify v2 will actually modify v1.
        System.Console.WriteLine("The first element in v1 is: {0}", v1[0]);
        System.Console.WriteLine("The first element in v2 is: {0}", v2[0]);
        
        v3.Insert(0, -3);
        System.Console.WriteLine("The first element in v1 is: {0}", v3[0]);
        
        //7. Sort
        v1.Sort();
        System.Console.WriteLine("[Version 1] The contents of v1 after sorting are: ");
        for(int i = 0; i < v1.Count; i++){
            System.Console.WriteLine(" " + v1[i]);
        }
        System.Console.WriteLine("[Version 1] The contents of v1 after sorting");
        
        //8. add new element at the end of the arraylist
        v1.Add(-1);
        v1.Insert(1, 6);
        for(int i = 0; i < v1.Count; i++){
            System.Console.WriteLine(" " + v1[i]);
        }
        System.Console.WriteLine("add new element at the end of the arraylist");
        
        //9. delete the last element
        v1.RemoveAt(v1.Count-1);
        System.Console.WriteLine("delete the last element: ");
        for(int i = 0; i < v1.Count; i++){
            System.Console.WriteLine(" " + v1[i]);
        }
        System.Console.WriteLine("delete the last element");
    }
}