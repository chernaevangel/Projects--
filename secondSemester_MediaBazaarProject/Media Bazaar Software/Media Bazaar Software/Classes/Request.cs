using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Bazaar_Software.Classes
{
    public class Request
    {
        public Employee Requester { get; private set; }
        public Item RequestedItem { get; private set; }
        public int Amount { get; private set; }
        public string RequestMessage { get; private set; }

        public Request(Item requestedItem, int amount)
        {
            RequestedItem = requestedItem;
            Amount = amount;
        }
        public Request(Employee requester, string requestMessage)
        {
            Requester = requester;
            RequestMessage = requestMessage;
        }

        public override string ToString()
        {
            if (RequestMessage == null)
            { return $"Restock Request: {Amount} {RequestedItem.Name}"; }
            else { return $"{Requester.FirstName}({Requester.Department}) requests {RequestMessage}"; }
        }
    }
}
