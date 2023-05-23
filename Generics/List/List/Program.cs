public class Program
{
    public static void Main(string[] args)
    {
        List<int> myList = new List<int>() { 5, 15 };
        int[] numbers = { 16, 25, 30 };
        int num;

        //Error handling
        try
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            myList.Add(num);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
           // Console.WriteLine("!!-I didn't crash-!!");
        }

        //linq query 
        var copyList = from item in myList
                       select item;

        //displaying all the information inside the list
        foreach (var list in myList)
        {
            Console.WriteLine(list);
        }
        Console.WriteLine("===============COPY===============");
        foreach (var items in copyList)
        {
            Console.WriteLine(items);
        }
    }
}