using Example;
internal class Program
{
    private static void Main(string[] args)
    {
        // Create a list of parts.
        List<Parts> parts = new List<Parts>();

        // Add parts to the list.
        parts.Add(new Parts() { PartName = Console.ReadLine(), PartId = Convert.ToInt32(Console.ReadLine()) });

        // Write out the parts in the list. This will call the overridden ToString method
        // in the Part class.
        Console.WriteLine();
        foreach (Parts aPart in parts)
        {
            Console.WriteLine(aPart);
        }  
    }
}