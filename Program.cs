namespace loopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int myNumber = 0;

            //while(myNumber <= 5)
            //{
            //    Console.WriteLine(myNumber);
            //    myNumber++;
            //}

            //string myPassword = "12345";
            //string userInput = "";

            //while(userInput != myPassword)
            //{
            //    Console.WriteLine("Skriv lösenord while looop: ");
            //    userInput = Console.ReadLine();
            //} 

            //do
            //{
            //    Console.WriteLine("Skriv lösenord: ");
            //    userInput = Console.ReadLine();
            //}
            //while (userInput != myPassword);

            //int number = 0;
            //Console.WriteLine("While-loop sartar här:");
            //while (number <= 10)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}
            //Console.WriteLine("For-loop startar här:");
            //for (int number1 = 0; number1 <= 10; number1++)
            //{
            //    Console.WriteLine(number1);
            //}

            //char[] helloWorld = { 'h', 'e', 'l', 'l', 'o' };
            //string myString = "Hello World";
            //for (int i = 0; i < myString.Length; i++)
            //{
            //    Console.WriteLine(helloWorld[i]);
            //}




            //Skapar en array med 3 världen
            string[] users = { "Josefin", "Felix", "Agnes" };

            //for (int i = 0; i < users.Length; i++)
            //{
            //    Console.WriteLine(users[i]);
            //}

            foreach(string user in users)
            {
                Console.WriteLine(user);
            }




            //--------------------------------------------------------------------------------------
        }
    }
}