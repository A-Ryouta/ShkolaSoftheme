namespace MobileOperator
{
    internal class ActionEventArgs
    {
        public string Message { get; }
        public int Receiver { get; }

        public ActionEventArgs(int receiver)
        {
            Message = string.Empty;
            Receiver = receiver;
        }

        public ActionEventArgs(int receiver, string message)
        {
            Message = message;
            Receiver = receiver;
        }
    }
}
