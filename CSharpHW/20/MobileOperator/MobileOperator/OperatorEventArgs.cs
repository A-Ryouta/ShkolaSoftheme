namespace MobileOperator
{
    internal class ActionEventArgs
    {
        public string Message { get; }
        public int Receiver { get; }
        
        public ActionEventArgs(int receiver = 0, string message = null)
        {
            Message = message;
            Receiver = receiver;
        }
    }
}
