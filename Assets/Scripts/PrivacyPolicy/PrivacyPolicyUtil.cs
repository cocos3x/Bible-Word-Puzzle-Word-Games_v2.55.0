using UnityEngine;

namespace PrivacyPolicy
{
    public class PrivacyPolicyUtil : MonoBehaviour
    {
        // Fields
        private static readonly System.Collections.Generic.List<System.Action> _callbacks;
        private static bool _callbacksPending;
        
        // Methods
        private void Start()
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        private void Update()
        {
            var val_3;
            bool val_4;
            var val_5;
            object val_6;
            var val_7;
            System.Collections.Generic.List<System.Action> val_8;
            T[] val_9;
            var val_10;
            var val_11;
            val_3 = null;
            val_3 = null;
            val_4 = PrivacyPolicy.PrivacyPolicyUtil._callbacksPending;
            if(val_4 == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = PrivacyPolicy.PrivacyPolicyUtil._callbacks;
            bool val_1 = false;
            val_6 = val_4;
            System.Threading.Monitor.Enter(obj:  val_6, lockTaken: ref  val_1);
            val_7 = null;
            val_7 = null;
            val_8 = PrivacyPolicy.PrivacyPolicyUtil._callbacks;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((PrivacyPolicy.PrivacyPolicyUtil._callbacks + 24) != 0)
            {
                    val_8 = PrivacyPolicy.PrivacyPolicyUtil._callbacks;
                System.Action[] val_2 = new System.Action[0];
                val_9 = val_2;
                val_6 = PrivacyPolicy.PrivacyPolicyUtil._callbacks;
                if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_6.CopyTo(array:  val_2);
                val_6 = PrivacyPolicy.PrivacyPolicyUtil._callbacks;
                if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_6.Clear();
                val_10 = 0;
                val_11 = 0;
                PrivacyPolicy.PrivacyPolicyUtil._callbacksPending = false;
            }
            else
            {
                    val_10 = 0;
                val_11 = 0;
                val_9 = 0;
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_4);
            }
            
            if(val_11 == 0)
            {
                    if(val_10 != 1)
            {
                    if(126 == 126)
            {
                    return;
            }
            
            }
            
                if(val_9 == 0)
            {
                    throw new NullReferenceException();
            }
            
                if(4960416 < 1)
            {
                    return;
            }
            
                do
            {
                var val_3 = val_9 + 0;
                if(((val_9 + 0) + 32) == 0)
            {
                    throw new NullReferenceException();
            }
            
                (val_9 + 0) + 32.Invoke();
                val_4 = 0 + 1;
            }
            while(val_4 < 4960416);
            
                return;
            }
            
            val_6 = val_11;
            throw val_6;
        }
        public void RunOnMainThread(System.Action runnable)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  PrivacyPolicy.PrivacyPolicyUtil._callbacks, lockTaken: ref  val_1);
            val_3 = null;
            val_3 = null;
            PrivacyPolicy.PrivacyPolicyUtil._callbacks.Add(item:  runnable);
            PrivacyPolicy.PrivacyPolicyUtil._callbacksPending = true;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PrivacyPolicy.PrivacyPolicyUtil._callbacks);
            }
            
            if(0 != 0)
            {
                    throw 0;
            }
        
        }
        public PrivacyPolicyUtil()
        {
        
        }
        private static PrivacyPolicyUtil()
        {
            PrivacyPolicy.PrivacyPolicyUtil._callbacks = new System.Collections.Generic.List<System.Action>();
        }
    
    }

}
