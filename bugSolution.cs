public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Add a null check before accessing MyProperty
        if (this != null && MyProperty != null)
        {
            Console.WriteLine(MyProperty * 2);
        }
        else
        {
            Console.WriteLine("MyProperty is null.");
        }
    }
} 