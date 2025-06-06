namespace ex2;

class MessageManager
{
    public event Action<MyMessage> NewMessage;

    public void SendMessage(MyMessage msg)
    {
        try
        {
            Console.WriteLine("\nПолучатель:");
            NewMessage?.Invoke(msg);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при обработке сообщения: {ex.Message}");
        }
    }
}