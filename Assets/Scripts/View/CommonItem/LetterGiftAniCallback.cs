using UnityEngine;

namespace View.CommonItem
{
    public class LetterGiftAniCallback : MonoBehaviour
    {
        // Methods
        public void GiftBoxDeathCallback()
        {
            Message.Messager.Dispatch(cmd:  68);
        }
        public LetterGiftAniCallback()
        {
        
        }
    
    }

}
