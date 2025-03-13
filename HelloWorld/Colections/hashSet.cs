namespace HelloWorld.Colections;

class hashSet
{

    static void new1()
    {
        HashSet<int> hash = new HashSet<int>();

        hash.Add(1);
        hash.Add(2);
        hash.Add(1);
        hash.Add(2);

        Console.WriteLine(hash.Count); // teoricamente irá contabilizar somente 2 elementos, pois n contabiliza elementos repetidos

    }
}
