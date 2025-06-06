namespace ex2;
class Mail
{
    public void Subscribe(MessageManager manager)
    {
        try
        {
            manager.NewMessage += ReceiveMail;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при подписке почты: {ex.Message}");
        }
    }

    private void ReceiveMail(MyMessage msg)
    {
        if (msg.MessageType == "email")
        {
            Console.WriteLine($"Получил письмо: {msg.Message}");
        }
    }
}