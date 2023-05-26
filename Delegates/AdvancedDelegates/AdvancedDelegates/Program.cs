using AdvancedDelegates;

public delegate int myDelegate(int i);
public delegate void voidDelegate();
public delegate void delegate3(int x);
public class Program
{
    public static void Main(string[] args)
    {
        DelegateClass delegateClass = new DelegateClass();
        myDelegate delegate1 = new myDelegate(MethodSum);
       

        Console.WriteLine(delegate1.Invoke(8));

        voidDelegate vDelegate = new voidDelegate(CheckInput);
        vDelegate();

        //Delegates with classes
        delegate3 del3 = new delegate3(delegateClass.multiple);
        int userInput = int.Parse(Console.ReadLine());
        del3.Invoke(userInput);
    }
    public static int MethodSum(int i)
    {
        return (i + i);
    }
    public static void CheckInput()
    {
        int number;

        try
        {
            Console.WriteLine("Enter any value");
            number = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}