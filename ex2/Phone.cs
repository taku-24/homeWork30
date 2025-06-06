namespace ex2;

class Phone
{
    public void Subscribe(MessageManager manager)
    {
        try
        {
            manager.NewMessage += ReceiveSms;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при подписке телефона: {ex.Message}");
        }
    }

    private void ReceiveSms(MyMessage msg)
    {
        if (msg.MessageType == "sms")
        {
            Console.WriteLine($"Получил смс: {msg.Message}");
        }
    }
}