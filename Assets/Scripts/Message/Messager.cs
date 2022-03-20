using UnityEngine;

namespace Message
{
    public static class Messager
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<Message.MessageCmd, System.Delegate> MessageDict;
        
        // Methods
        private static void Add(Message.MessageCmd cmd, System.Delegate handle)
        {
            var val_4;
            var val_5;
            var val_6;
            System.Delegate val_1 = 0;
            val_4 = null;
            val_4 = null;
            if((Message.Messager.MessageDict.TryGetValue(key:  cmd, value: out  val_1)) != false)
            {
                    val_5 = null;
                val_5 = null;
                Message.Messager.MessageDict.set_Item(key:  cmd, value:  System.Delegate.Combine(a:  val_1, b:  handle));
                return;
            }
            
            val_6 = null;
            val_6 = null;
            Message.Messager.MessageDict.Add(key:  cmd, value:  handle);
        }
        public static void Add(Message.MessageCmd cmd, System.Action action)
        {
            Message.Messager.Add(cmd:  cmd, handle:  action);
        }
        public static void Add<T>(Message.MessageCmd cmd, System.Action<T> action)
        {
            Message.Messager.Add(cmd:  cmd, handle:  action);
        }
        public static void Add<T, U>(Message.MessageCmd cmd, System.Action<T, U> action)
        {
            Message.Messager.Add(cmd:  cmd, handle:  action);
        }
        private static void Remove(Message.MessageCmd cmd, System.Delegate handle)
        {
            var val_4;
            var val_5;
            System.Delegate val_1 = 0;
            val_4 = null;
            val_4 = null;
            if((Message.Messager.MessageDict.TryGetValue(key:  cmd, value: out  val_1)) == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            Message.Messager.MessageDict.set_Item(key:  cmd, value:  System.Delegate.Remove(source:  val_1, value:  handle));
        }
        public static void Remove(Message.MessageCmd cmd, System.Action action)
        {
            Message.Messager.Remove(cmd:  cmd, handle:  action);
        }
        public static void Remove<T>(Message.MessageCmd cmd, System.Action<T> action)
        {
            Message.Messager.Remove(cmd:  cmd, handle:  action);
        }
        public static void Remove<T, U>(Message.MessageCmd cmd, System.Action<T, U> action)
        {
            Message.Messager.Remove(cmd:  cmd, handle:  action);
        }
        public static void Dispatch(Message.MessageCmd cmd)
        {
            var val_3;
            System.Delegate val_1 = 0;
            val_3 = null;
            val_3 = null;
            if((Message.Messager.MessageDict.TryGetValue(key:  cmd, value: out  val_1)) == false)
            {
                    return;
            }
            
            if(val_1 == 0)
            {
                    return;
            }
            
            if(1179403647 == null)
            {
                    val_1.Invoke();
                return;
            }
        
        }
        public static void Dispatch<T>(Message.MessageCmd cmd, T t)
        {
            Message.MessageCmd val_4;
            var val_5;
            val_4 = cmd;
            System.Delegate val_1 = 0;
            val_5 = null;
            val_5 = null;
            if((Message.Messager.MessageDict.TryGetValue(key:  val_4, value: out  val_1)) == false)
            {
                    return;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 48];
            val_4 = __RuntimeMethodHiddenParam + 48;
            if(val_1 == 0)
            {
                    return;
            }
            
            if(X0 != false)
            {
                    bool val_3 = t;
                return;
            }
        
        }
        public static void Dispatch<T, U>(Message.MessageCmd cmd, T t, U u)
        {
            Message.MessageCmd val_3;
            var val_4;
            val_3 = cmd;
            System.Delegate val_1 = 0;
            val_4 = null;
            val_4 = null;
            if((Message.Messager.MessageDict.TryGetValue(key:  val_3, value: out  val_1)) == false)
            {
                    return;
            }
            
            val_3 = mem[__RuntimeMethodHiddenParam + 48];
            val_3 = __RuntimeMethodHiddenParam + 48;
            if(val_1 == 0)
            {
                    return;
            }
            
            if(X0 != false)
            {
                    return;
            }
        
        }
        private static Messager()
        {
            Message.Messager.MessageDict = new System.Collections.Generic.Dictionary<Message.MessageCmd, System.Delegate>(comparer:  0);
        }
    
    }

}
