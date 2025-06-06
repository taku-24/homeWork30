namespace ex2;

class Program
{
    static void Main(string[] args)
    {
        MessageManager manager = new MessageManager();
        Phone phone = new Phone();
        Mail mail = new Mail();

        phone.Subscribe(manager);
        mail.Subscribe(manager);

        Console.WriteLine("Отправка сообщения");
        try
        {
            Console.Write("Введите тип сообщения (sms/email): ");
            string type = Console.ReadLine();

            Console.Write("Введите сообщение: ");
            string content = Console.ReadLine();

            MyMessage message = new MyMessage(type, content);

            manager.SendMessage(message);
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine($"Ошибка ввода: {argEx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
        }
        
    }
}


