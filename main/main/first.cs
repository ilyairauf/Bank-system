using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace main
{
    internal class first
    {
        static void Main(string[] args)
        {
            
            int operation = 0;


            //eslinde butun datalari bankaccount classinin icinde saxlamaq isteyirdim ama ya men bas aca bilmedim yada classin icindeki bir listin uzerinde deyisiklik etmek olmur
            List<BankAccount> bankData = new List<BankAccount>();
            List<Person> personData = new List<Person>();
        //normal sertler altinda her bir usera unique bir id vermek olardi ama digerin classdaki bir propertynin id sini nece artiracagimi bilmediyim ucun account id ni id kimi teyin edib her defe onu artiracagam
        int id = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to world bank!");
                Console.WriteLine("1. Create new Account");
                Console.WriteLine("2. Login to an existing account");
                Console.WriteLine("3. Exit");
                operation = int.Parse(Console.ReadLine());
                if (operation == 1)
                {
                    DateTime today = DateTime.Today;
                    BankAccount bank = new BankAccount();
                    Person person = new Person();
                    Console.WriteLine("Enter your name: "); person.PersonName = Console.ReadLine();
                    Console.WriteLine("Enter your password: "); bank.Password = Console.ReadLine();
                    bankData.Add(new BankAccount() {

                        AccountHolderID = id,
                        Balance = bank.Balance,
                        IsActive = bank.IsActive,
                        AccountName = person.PersonName,
                        OpenDate = today.ToString("dd/MM/yyyy"),
                        Password = bank.Password

                    });
                    person.PersonId = id;
                    personData.Add(new Person()
                    {
                        PersonId = person.PersonId,
                        PersonName = person.PersonName
                    });
                    id += 1;


                    #region
                    //bank.AccountHolderID = bank.AccountHolderID;
                    //bank.Balance = bank.Balance;
                    //bank.IsActive = bank.IsActive;
                    //bank.AccountName = person.PersonName;                    
                    //bank.OpenDate = today.ToString("dd/MM/yyyy");
                    #endregion
                    // bank obyektini liste elave edir bu list vasitesi ile butun datalara erisim mumkun olacaq


                }
                else if (operation == 2)
                {
                    BankAccount bank1 = new BankAccount();
                    Person person1 = new Person();
                    string name;
                    dynamic password;
                    Console.WriteLine("Enter your name: "); name = Console.ReadLine();
                    Console.WriteLine("Enter your password: "); password = Console.ReadLine();
                    foreach (Person _name in personData)
                    {
                        try
                        {
                            if (_name.PersonName == name)
                            {
                                foreach (BankAccount data in bankData)
                                {
                                    // userin eyni name'i eyni qoymaga calismagina qarsi error qoymaq olardi ama complexlesdirmemek adina etmirem
                                    try
                                    {
                                        if (_name.PersonId == data.AccountHolderID && data.Password == password)
                                        {

                                            while (true)
                                            {
                                                Console.Clear();
                                                Console.WriteLine(@"1. Deposit
2. Withdraw
3. check balance
4. Exit");
                                                operation = int.Parse(Console.ReadLine());
                                                switch (operation)
                                                {
                                                    case 1:


                                                        Console.WriteLine("How much would you like to deposit"); int money = int.Parse(Console.ReadLine());
                                                        data.Balance = bank1.Deposit(money, data.Balance);
                                                        Thread.Sleep(1000);
                                                        break;



                                                    case 2:

                                                        Console.WriteLine("How much would you like to withdraw"); int moneyw = int.Parse(Console.ReadLine());
                                                        data.Balance = bank1.Withdraw(moneyw, data.Balance);
                                                        Thread.Sleep(1000);
                                                        break;
                                                    case 3:

                                                        Console.WriteLine(data.Balance);
                                                        Thread.Sleep(1000);
                                                        break;

                                                }
                                                if (operation == 4) break;

                                            }
                                        }
                                    }
                                    catch { Console.WriteLine("Wrong password!"); Thread.Sleep(1000); }

                                }


                            }
                        }
                        catch { Console.WriteLine("Try again with a valid name or sign up"); Thread.Sleep(1000); }                        
                    }
                    Thread.Sleep(2000);


                }else if (operation == 3)
                {
                    Console.WriteLine("Exciting program...");
                    Thread.Sleep(1000);
                    break;
                }
            } 
        }
    }
}
