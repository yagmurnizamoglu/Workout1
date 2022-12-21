class Program
{
    static void Main()
    {
        int widthOfRectangle=0, heightOfRectangle=0, area=0, perimeter=0;


        Console.WriteLine("Insert the width of the rectangle :");
        widthOfRectangle = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Insert the height of the rectangle :");
        heightOfRectangle = int.Parse(Console.ReadLine());

       

        area = widthOfRectangle * heightOfRectangle;
        perimeter = (widthOfRectangle + heightOfRectangle) * 2;


        Console.WriteLine("Area Of The Rectangle: {0}", area);
        Console.WriteLine("Perimeter Of The Rectangle: {0}", perimeter);

        Console.ReadKey();
    }
}