using System;

class TV
{
    public string Brand { get; set; }
    private bool IsOn;
    private int Volume;
    private int Channel;

    public TV(string brand)
    {
        Brand = brand;
        IsOn = false;
        Volume = 10;
        Channel = 1;
    }

    public void Power()
    {
        IsOn = !IsOn;
        Console.WriteLine(IsOn ? "The TV is now ON." : "The TV is now OFF.");
    }

    public void IncreaseVolume()
    {
        if (IsOn && Volume < 100)
        {
            Volume++;
            Console.WriteLine("Volume: " + Volume);
        }
    }

    public void DecreaseVolume()
    {
        if (IsOn && Volume > 0)
        {
            Volume--;
            Console.WriteLine("Volume: " + Volume);
        }
    }

    public void ChangeChannel(int newChannel)
    {
        if (IsOn && newChannel > 0)
        {
            Channel = newChannel;
            Console.WriteLine("Channel changed to: " + Channel);
        }
    }
}

class Program
{
    static void Main()
    {
        TV myTV = new TV("Samsung");
        myTV.Power();
        myTV.IncreaseVolume();
        myTV.ChangeChannel(5);
        myTV.DecreaseVolume();
        myTV.Power();
    }
}
