namespace MobileOperator
{
    public class ActionEventArgs
    {
        public string Message { get; }
        public int Receiver { get; }

        public ActionEventArgs(int receiver)
        {
            Message = string.Empty;
            Receiver = receiver;
        }

        public ActionEventArgs(string message)
        {
            Message = message;
            Receiver = 0;
        }

        public ActionEventArgs(int receiver, string message)
        {
            Message = message;
            Receiver = receiver;
        }
    }
}
