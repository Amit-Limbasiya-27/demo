namespace CollectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 12, 15, 23, 34, 45 };
            //Console.WriteLine(Array.BinarySearch(arr, 25));
            //var t = Tuple.Create( 1 );
            var person = (PersonId: 1, FName: "Bill", LName: "Gates");
            Console.WriteLine(person.PersonId); // returns 1
            Console.WriteLine(person.FName); // returns "Bill"
            Console.WriteLine(person.LName); // returns "Gates"

        }
    }
}