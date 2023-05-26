namespace AdvancedDelegates
{
    public class DelegateClass
    {
        public void multiple(int i)
        {
            int multiple;
            if (i > 10)
            {
                Console.WriteLine($"Thr value must be less than 10");
            }
            else
            {
                multiple = i * 4;
                Console.WriteLine($"{multiple} is a multiple of {i}");
            }

        }
    }
}

