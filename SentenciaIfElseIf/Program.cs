public class Program
{
    public static void Main(string[] args)
    {

        bool areYouHungry = true;
        bool youHaveMoney = true;

        if (areYouHungry && youHaveMoney && IsOpenRestaurant("pepe", 9))
        {
            Console.WriteLine("eat something");

        }

        else
        {
            Console.WriteLine("dont eat something");
        }



        static bool IsOpenRestaurant(string name, int hour = 0)

        {

            if (name == "pepe" && hour > 8 && hour < 23)
            { return true; }
            else if (name == "Restaurant 24 horas")
            { return true; }
            else
            { return false; }

        }




    }



 


}

