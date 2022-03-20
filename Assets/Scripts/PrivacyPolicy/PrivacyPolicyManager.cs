using UnityEngine;

namespace PrivacyPolicy
{
    public static class PrivacyPolicyManager
    {
        // Fields
        private static PrivacyPolicy.Platform.IPrivacyPolicyImpl _impl;
        private static PrivacyPolicy.PrivacyPolicyUtil _util;
        private static System.Nullable<bool> isAcceptCcpa;
        
        // Methods
        private static PrivacyPolicyManager()
        {
            PrivacyPolicy.PrivacyPolicyManager._impl = new System.Object();
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "PrivacyPolicyUtil");
            hideFlags = 3;
            PrivacyPolicy.PrivacyPolicyManager._util = AddComponent<PrivacyPolicy.PrivacyPolicyUtil>();
        }
        public static void Agree(string key)
        {
            var val_3;
            typeof(PrivacyPolicyManager.<>c__DisplayClass5_0).__il2cppRuntimeField_10 = key;
            val_3 = null;
            val_3 = null;
            System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void PrivacyPolicyManager.<>c__DisplayClass5_0::<Agree>b__0());
            val_2.RunOnMainThread(runnable:  val_2);
        }
    
    }

}
