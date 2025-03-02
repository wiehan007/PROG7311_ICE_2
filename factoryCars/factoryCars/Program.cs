namespace factoryCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactury factory = new CarFactury();

            while (true)
            {
                Console.WriteLine("Please enter the Type of Audi car you are trying to buy (Sedan, SUV or Sport): ");
                String selectCar = Console.ReadLine();
                ICar vehice = factory.getVehicle(selectCar);
                if (vehice != null)
                {
                    Console.WriteLine("Vehicle Name: {0} \nVehicle Model: {1} \nCar Price: {2} \nNumber Of Seats: {3} " +
                    "\nWheel Size: {4} \nTop Speed: {5}\n",
                    vehice.getName(),
                    vehice.getModel(),
                    vehice.getCarPrice(),
                    vehice.getNumberOfSeats(),
                    vehice.getWheelSize(),
                    vehice.getTopSpeed());
                }
                else
                {
                    Console.WriteLine("We Couldnt find the type of car you are looking for. Type Sedan, SUV or Sports");
                }
            }
            
            
        }
    }
}
