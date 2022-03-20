using UnityEngine;

namespace View.CommonItem
{
    public class GuideMask : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform TransformBg;
        
        // Methods
        public void SetGuideMaskBgState(bool isShow)
        {
            this.TransformBg.gameObject.SetActive(value:  isShow);
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.Boolean>(cmd:  32, action:  new System.Action<System.Boolean>(object:  this, method:  public System.Void View.CommonItem.GuideMask::SetGuideMaskBgState(bool isShow)));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Boolean>(cmd:  32, action:  new System.Action<System.Boolean>(object:  this, method:  public System.Void View.CommonItem.GuideMask::SetGuideMaskBgState(bool isShow)));
        }
        public GuideMask()
        {
        
        }
    
    }

}
