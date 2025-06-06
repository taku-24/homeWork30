namespace ConsoleApp18;
class Lamp
{
    public bool TurnedOn { get; set; }

    public string GetLampStatus()
    {
        return TurnedOn ? "Лампа включена" : "Лампа выключена";
    }
}
class Cat
{
    public string WhatIsDoingNow()
    {
        return "Кошка играет";
    }
}
class Man
{
    public string WhatHeIsDoingNow()
    {
        return "Человек спит";
    }
}

class Program
{
    public delegate string StateDelegate();

    static void Main(string[] args)
    {
        Lamp lamp = new Lamp { TurnedOn = true };
        Cat cat = new Cat();
        Man man = new Man();
        
        StateDelegate stateDelegate = null;
        stateDelegate += lamp.GetLampStatus;
        stateDelegate += cat.WhatIsDoingNow;
        stateDelegate += man.WhatHeIsDoingNow;
        
        ReadState(stateDelegate);
    }
    
    public static void ReadState(StateDelegate del)
    {
        Console.WriteLine("Состояния объектов:");
        int count = 1;
        
        foreach (Delegate d in del.GetInvocationList())
        {
            string result = d.DynamicInvoke() as string;
            Console.WriteLine($"{count}. {result}");
            count++;
        }
    }
}

