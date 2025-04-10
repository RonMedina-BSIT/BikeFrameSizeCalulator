using System.Drawing;
using BFSC_BusinessDataLogic;
using BFSC_Common;
namespace BikeFrameSizeCalulator
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to Bike Frame Size Calulator");
            AddandDelete();

        }
        public static void AddandDelete()
        {
            Console.Write("Please enter your inseam in cm: ");
            int inseam = Convert.ToInt16(Console.ReadLine());

            FrameSizes sizes =BFSC_Service.CalculateFrameSize(inseam);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Your bike frame size for: " + "\n" + "Trekking: " + sizes.TrekkingFrameSize + "\n" + "Road Bikes: " + sizes.RoadFrameSize + "\n" + "Mountain Bikes: " + sizes.MountainFrameSize);

            Console.WriteLine("-------------------------");
            Console.Write("Do you want to Delete Something?(Y/N): ");
            string response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Please select the item you want to delete: ");
                string[] actions = new string[] { "[1] Trekking", "[2] Road Bikes", "[3] Mountain Bikes" };
                Console.WriteLine("ACTIONS");

                foreach (var action in actions)
                {
                    Console.WriteLine(action);
                }
                Console.WriteLine("-------------------------");
                Console.Write("Enter Action: ");


                int userAction = Convert.ToInt16(Console.ReadLine());

                switch (userAction)
                {
                    case 1:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Your bike frame size for: " + "\n" + "Road Bikes: " + sizes.RoadFrameSize + "\n" + "Mountain Bikes: " + sizes.MountainFrameSize);
                        Update();
                        break;
                    case 2:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Your bike frame size for: " + "\n" + "Trekking: " + sizes.TrekkingFrameSize + "\n" + "Mountain Bikes: " + sizes.MountainFrameSize);
                        Update();
                        break;
                    case 3:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Your bike frame size for: " + "\n" + "Trekking: " + sizes.TrekkingFrameSize + "\n" + "Road Bikes: " + sizes.RoadFrameSize);
                        Update();
                        break;
                        default:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Invalid input, please try again.");
                        break;

                }
            }
            else
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Thank you for using the Bike Frame Size Calulator");
                Console.WriteLine("Have a nice day!");
                Update();
            }
        }
        public static void Update()
        {
            Console.WriteLine("-------------------------");
            Console.Write("Do you want to Change your inseam?(Y/N): ");
            string response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                AddandDelete();
            }
            else
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Thank you for using the Bike Frame Size Calulator");
                Console.WriteLine("Have a nice day!");
            }
        }
    }
}
