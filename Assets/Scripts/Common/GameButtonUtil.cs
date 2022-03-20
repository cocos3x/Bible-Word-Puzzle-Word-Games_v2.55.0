using UnityEngine;

namespace Common
{
    public class GameButtonUtil
    {
        // Methods
        public static void AddVideoListener(UnityEngine.UI.Button btn, string adFrom, string position, UnityEngine.Events.UnityAction onClick, UnityEngine.Events.UnityAction onSkip, UnityEngine.Events.UnityAction onFinish, bool clearListenner = True)
        {
            typeof(GameButtonUtil.<>c__DisplayClass0_0).__il2cppRuntimeField_10 = onClick;
            typeof(GameButtonUtil.<>c__DisplayClass0_0).__il2cppRuntimeField_18 = onFinish;
            typeof(GameButtonUtil.<>c__DisplayClass0_0).__il2cppRuntimeField_20 = onSkip;
            typeof(GameButtonUtil.<>c__DisplayClass0_0).__il2cppRuntimeField_28 = adFrom;
            typeof(GameButtonUtil.<>c__DisplayClass0_0).__il2cppRuntimeField_30 = position;
            if(btn == 0)
            {
                    return;
            }
            
            if(clearListenner != false)
            {
                    btn.m_OnClick.RemoveAllListeners();
            }
            
            btn.enabled = true;
            btn.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  new System.Object(), method:  System.Void GameButtonUtil.<>c__DisplayClass0_0::<AddVideoListener>b__0()));
        }
    
    }

}
