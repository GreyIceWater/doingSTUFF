// See https://aka.ms/new-console-template for more information
using doingSTUFF;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

public class Customer : IDisplayable
{
    public string Phone
    {
        get
        {
            return this.Phone;
        }
        set
        {
            if (!Regex.IsMatch(value, @"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"))
            {
                this.DisplayMessage();
            }
            else
            {
                this.Phone = value;
            }
        }        
    }

    public void DisplayMessage()
    {
        Console.WriteLine("HEY I AM A WEB APP AND I AM PISSED");
    }
}


public class poops : IDisplayable
{
    public string Phone
    {
        get
        {
            return this.Phone;
        }
        set
        {
            if (!Regex.IsMatch(value, @"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"))
            {
                this.DisplayMessage();
            }
            else
            {
                this.Phone = value;
            }
        }
    }

    public void DisplayMessage()
    {
        this.HolographicMessageDisplay("THIS IS DEFINITELY NOT CONSOLE.WRITELINE, NOPE");
    }

    public void HolographicMessageDisplay(string message)
    {
        Console.WriteLine(message);
    }
}