public interface IMediator
{
    void SendMessage(string message, Colleague colleague);
}
public abstract class Colleague
{
    protected IMediator _mediator; 

    public Colleague(IMediator mediator)
    {
        _mediator = mediator;
    }
    public abstract void RecieveMessage(string Message);
}

public class ChatMediator : IMediator
{
    private List<Colleague> colleagues;
    
    public ChatMediator()
    {
        _colleagues = new List<Colleague>();

    }

    public viod RegisterColleague(Colleague colleague)
    {
        _colleagues.Add(colleague);
    }

    public void SendMessage(string message, Colleague sender)
    {
        foreach (var colleague in _colleagues)
        {
            if (colleague != sender)
            {
                colleague.RecieveMessage(message);
            }
        }
    } 
}


public class User : Colleague
{
      private string _name; 

      public User(IMediator mediator, string name) : base(mediator)
      {
        _name = name
      }

      public void Send(string message)
      {
        Console.WriteLine($"{_name} send message: {message}");
        _mediator.SendMessage(message, this);
      }
      public ovveride void RecieveMessage(string mssage)
      {
        Console.WriteLine($"{_name} received message: {message}" );
      }
}

class Program 
{
    static void Main(string[] args)
    {
        ChatMediator chatMediator = new ChatMediator();

        User user1 = new User(chatMediator, "Nuric");
        User user2 = new User(chatMediator, "Nurbol");
        User user3 = new User(chatMediator, "Temir");

        chatMediator.RegisterColleague(user1);
        chatMediator.RegisterColleague(user2);
        chatMediator.RegisterColleague(user3);

        user1.Send("Hello")
        user2.Send("Bye")
        user3.Send("How are you?")
    }
}