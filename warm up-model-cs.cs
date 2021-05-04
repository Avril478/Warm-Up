using System;
using System.Linq;
class Program {
    static void Main () {
        var In = Console.In;
        var inputString = In.ReadToEnd();
        string[] stringArray = inputString.Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
        try{
            var intArray = stringArray.Select (i =>Int32.Parse(i));
            var evenArray = intArray.Where (n => n % 2 == 0);
            var oddArray = intArray.Where (n => n % 2 != 0);
            var halfEvenArray =  evenArray.Select( i => i / 2 );
            var finalArray = halfEvenArray.Union(oddArray);
            var sum = finalArray.Sum();
            Console.Write(sum);
        } catch(Exception exception){
            Console.WriteLine($"*** {exception.Message}");      
        }
    }
}