using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList myArrList = new ArrayList();
        int[] numbers = { 8, 9, 10 };

        //Adding data into an array list
        myArrList.Add("Sydney");
        myArrList.Add(4.5);
        myArrList.Add(false);
        myArrList.AddRange(numbers); //allows to add all the information in another array. 

        //Inserting data into an array list
        myArrList.Insert(1, "Thato");
        myArrList.InsertRange(0, numbers);

        //Removing data from an array list
        myArrList.Add(8);
        myArrList.Remove(8);
        myArrList.RemoveAt(5);

        for (int i = 0; i < myArrList.Count; i++)
        {
            Console.WriteLine(myArrList[i]);
        }

        Console.WriteLine("+++++++++++++++++++");
        foreach (var items in myArrList)
        {
            Console.WriteLine(items);
        }
    }
}