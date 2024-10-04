using System;
public class cardHolder
{
    private String cardNumber;
    private String firstName;
    private String lastName;
    private double balance;
    int pin;
    public cardHolder(String cardNumber, String firstName, String lastName, double balance,int pin) {
        
        this.cardNumber = cardNumber;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
        this.pin = pin;
    }
    public String getCardNumber()
    {
        return cardNumber;
    }
    public int getPin()
    {
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }
    public String getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }
    public void setBalance(double balance)
    {
        this.balance = balance;
    }
    public void setFirstName(String name)
    {
        this.firstName = name;
    }
    public void setLastName(String lastName)
    {
        this.lastName = lastName;
    } 

    public static void Main(string[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please one of the following options ... ");
            Console.WriteLine("1.Deposit option");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much tk do you want to deposit");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit+currentUser.getBalance());
            Console.WriteLine("Thank you for your money! Your current balance is tk "+currentUser.getBalance());

        }
        void widraw(cardHolder currentUser)
        {
            Console.WriteLine("How much tk do you want to withdraw");
            double withdraw=Double.Parse(Console.ReadLine());
            if(currentUser.getBalance()<=withdraw)
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("Your Balance withdraw is Successfull!");
            }
            else
            {
                Console.WriteLine("Your Balance withdrawal is Failed");
            }

        }
        void printBalance(cardHolder currentUser)
        {
            Console.WriteLine("Your Balance is "+currentUser.getBalance());
        }

        List<cardHolder> listOfCardholders=new List<cardHolder>();
        listOfCardholders.Add(new cardHolder("123456", "Naimur", "Rahman", 1000, 123));
        listOfCardholders.Add(new cardHolder("123457", "Zawadul", "Karim", 1000, 124));
        listOfCardholders.Add(new cardHolder("123458", "Naim", "Arafat", 1000, 125));
        listOfCardholders.Add(new cardHolder("123459", "Arnob", "Sen", 1000, 126));

        Console.WriteLine("This is a simple ATM");

        Console.WriteLine("Please Enter your Debit Card");

        String debitCardNumber = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNumber=Console.ReadLine();

                // Check the Card Aganist Our DB;

                currentUser= listOfCardholders.FirstOrDefault(a=>a.cardNumber==debitCardNumber);

                if (currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The are no card of this card number. Please try again");
                }
            }
            catch (Exception e) { Console.WriteLine(e); }

            

           
        }
        Console.WriteLine("Please Enter your pin: ");
        int userPin = 0;
        int currentPin;
        while (true)
        {
            try
            {
                currentPin = int.Parse(Console.ReadLine());

                // Check the Pin Aganist Our DB;
                

                if (currentPin == currentUser.getPin())
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Your pin is invalid ! Please try again");
                }
            }
            catch { Console.WriteLine("Here are an error"); }
        }



    }
    
}