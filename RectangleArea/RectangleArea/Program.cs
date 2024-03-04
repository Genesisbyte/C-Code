//Title: Area of a rectangle
//Author: Genesisbyte
//Date: 04-Mar-2024
//Description:Calculating an area of a rectangle


//Creating an object named rectangle
Rectangle rectangle = new Rectangle();
rectangle.Display();
rectangle.Info();
Console.ReadLine();

//Creating class of rectangle
class Rectangle
{
    //Setting length and width of rectangle to double and private
    //Private means it can only be accessed by code in same class
    private double length;
    private double width;


    //Method to display the user input
    public void Display()
    {
        Console.Write("Enter length: ");
        length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter width: ");
        width = Convert.ToDouble(Console.ReadLine());
    }

    //Method to calculate the area 
    public double CalculateArea()
    {
        return width * length;
    }

    //Method to print out final information
    public void Info()
    {
        Console.WriteLine("Length: {0}", length);
        Console.WriteLine("Width: {0}", width);
        Console.WriteLine("Area: {0}", CalculateArea());
    }
}
