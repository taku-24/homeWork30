namespace ex2;

class MyMessage
{
    public string MessageType { get; set; }
    public string Message { get; set; }

    public MyMessage(string type, string message)
    {
        if (string.IsNullOrWhiteSpace(type))
            throw new ArgumentException("Тип сообщения не может быть пустым.");

        if (string.IsNullOrWhiteSpace(message))
            throw new ArgumentException("Текст сообщения не может быть пустым.");

        MessageType = type.ToLower();
        Message = message;
    }
}