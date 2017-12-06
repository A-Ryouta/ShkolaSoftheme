namespace MobileOperator
{
    class Action
    {
        public static int Id { get; private set; }
        public int Sender { get; }
        public int Receiver { get; }
        public OperationTypes Type { get; }
        public string MessageText { get; }

        public Action(int sender, int receiver, OperationTypes type, string message = "")
        {
            Id++;
            Sender = sender;
            Receiver = receiver;
            Type = type;

            MessageText = (type == OperationTypes.Message) ? message : string.Empty;
        }
    }
}
