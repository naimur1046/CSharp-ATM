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
            Console.WriteLine("");
        }
    }
    
}