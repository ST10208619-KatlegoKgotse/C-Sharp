public delegate void myDelegate(int i);
public class Program
{
    public static void Main(string[] args)
    {
        
        myDelegate delegate1 = new myDelegate(MethodSum);
        myDelegate delegate2 = new myDelegate(MethodProd);
        myDelegate delegate3;
        delegate1.Invoke(5);
        delegate2(6);
        delegate3 = delegate1;
        //Multi casting of delegates when 1 delegate will be able to run more delegates
        delegate3 += delegate2;
        delegate3(10);

        delegate3 -= delegate1;//We are removing the reference to delegate 1 when doing in delegate 3
        delegate3(3);
    }
    public static void MethodSum(int i) {
        Console.WriteLine((i + i));
    }
    public static void MethodProd(int i)
    {
        Console.WriteLine((i*i));
    }
}