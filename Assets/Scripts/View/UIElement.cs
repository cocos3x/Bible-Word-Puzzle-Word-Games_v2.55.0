using UnityEngine;

namespace View
{
    public class UIElement : MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup canvasGroup;
        
        // Properties
        public virtual float Alpha { get; set; }
        public virtual bool Interactable { get; set; }
        public virtual bool BlocksRaycasts { get; set; }
        public virtual bool IgnoreParentGroups { get; set; }
        
        // Methods
        public virtual float get_Alpha()
        {
            this.InitializeComponents();
            return this.canvasGroup.alpha;
        }
        public virtual void set_Alpha(float value)
        {
            this.InitializeComponents();
            this.canvasGroup.alpha = value;
        }
        public virtual bool get_Interactable()
        {
            this.InitializeComponents();
            return this.canvasGroup.interactable;
        }
        public virtual void set_Interactable(bool value)
        {
            this.InitializeComponents();
            value = value;
            this.canvasGroup.interactable = value;
        }
        public virtual bool get_BlocksRaycasts()
        {
            this.InitializeComponents();
            return this.canvasGroup.blocksRaycasts;
        }
        public virtual void set_BlocksRaycasts(bool value)
        {
            this.InitializeComponents();
            value = value;
            this.canvasGroup.blocksRaycasts = value;
        }
        public virtual bool get_IgnoreParentGroups()
        {
            this.InitializeComponents();
            return this.canvasGroup.ignoreParentGroups;
        }
        public virtual void set_IgnoreParentGroups(bool value)
        {
            this.InitializeComponents();
            value = value;
            this.canvasGroup.ignoreParentGroups = value;
        }
        private void InitializeComponents()
        {
            if(this.canvasGroup != 0)
            {
                    return;
            }
            
            this.canvasGroup = this.GetComponent<UnityEngine.CanvasGroup>();
        }
        public virtual void SetVisible(bool visible, float alpha = 1)
        {
            var val_1 = (visible != true) ? alpha : 0f;
            bool val_2 = visible;
            goto typeof(View.UIElement).__il2cppRuntimeField_1C0;
        }
        public virtual void SetActive(bool active)
        {
            if(this.gameObject.activeSelf ^ active == false)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  active);
        }
        public virtual void SetParent(UnityEngine.Transform transform)
        {
            this.transform.SetParent(p:  transform);
        }
        public virtual void SetAsLastSibling()
        {
            this.transform.SetAsLastSibling();
        }
        public virtual void SetAsFirstSibling()
        {
            this.transform.SetAsFirstSibling();
        }
        public virtual void SetSiblingIndex(int index)
        {
            this.transform.SetSiblingIndex(index:  index);
        }
        public UIElement()
        {
        
        }
    
    }

}
