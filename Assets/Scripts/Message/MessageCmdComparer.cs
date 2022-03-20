using UnityEngine;

namespace Message
{
    public struct MessageCmdComparer : IEqualityComparer<Message.MessageCmd>
    {
        // Methods
        public bool Equals(Message.MessageCmd x, Message.MessageCmd y)
        {
            return (bool)(x == y) ? 1 : 0;
        }
        public int GetHashCode(Message.MessageCmd obj)
        {
            return (int)obj;
        }
    
    }

}
