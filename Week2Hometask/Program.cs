namespace Week2Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to us");


            string name;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            string surname;
            Console.WriteLine("Please enter your surname: ");
            surname = Console.ReadLine();

            string middleName;
            Console.WriteLine("Please enter your middle name: ");
            middleName = Console.ReadLine();

            string gender;
            Console.WriteLine("Please enter gender: ");
            gender = Console.ReadLine();

            int dateOfBirth;
            Console.WriteLine("Please enter date of birth: ");
            dateOfBirth = int.Parse(Console.ReadLine());

            string address;
            Console.WriteLine("Please enter your official address: ");
            address = Console.ReadLine();

            int age = DateTime.Now.Year-dateOfBirth;
            string category;            

            if (age <= 10)
            {                
                  category = "uşaqliq";
            }

            else if (age > 10 && age <= 20)
            {
                category = "yeniyetmelik";
            }
            else if (age > 20 && age <= 30)
            {
                category = "erken genclik";
            }
            else if (age > 30 && age <= 40)
            {
                category = "genclik";
            }
            else if (age > 40 && age <= 50)
            {
                category = "orta yaş";
            }

            else
            {
                category = "qocalıq";
            }



            bool isRegistered=false;            

            if (category == "genclik")
            {
                isRegistered = true;
            }
            else
            {
                isRegistered = false;
            }


            Console.WriteLine("Result : ");
            Console.WriteLine("Siz, " + surname + " " + name + " " + middleName + " " + ((gender=="kisi")?"oglu":"qizi") + " " + dateOfBirth + " tarixinde doguldugunuz üçün hal-hazirda " + age + " yasiniz var. Azerbaycan qanunvericiliyine uygun olaraq " + category + " dövrünüzü yasamaqdasiniz. Bu is yerine sadece genclik döneminde olan sexsler müraciet ede bilerler. Bu telebi nezere alaraq sizin müracietiniz " + ((isRegistered)? "qeyde alinmisdir" : "qeyde alinmamişdir") + ".");
        }
    }
}