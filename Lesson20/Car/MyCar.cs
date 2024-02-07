namespace Car
{
    public class MyCar
    {
        private int age;

        private void CarMethod(string value)
        {
            if (age < 5)
            {
                throw new Exception("Try again");
            }

            Console.WriteLine(value);
        }
    }
}
