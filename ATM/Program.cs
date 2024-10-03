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
    }
    
}