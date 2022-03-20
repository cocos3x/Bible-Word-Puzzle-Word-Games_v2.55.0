using UnityEngine;

namespace View
{
    public class UIView : UIElement
    {
        // Fields
        private UnityEngine.Canvas <Canvas>k__BackingField;
        
        // Properties
        public UnityEngine.Canvas Canvas { get; set; }
        public int SortingOrder { get; }
        
        // Methods
        public UnityEngine.Canvas get_Canvas()
        {
            return (UnityEngine.Canvas)this.<Canvas>k__BackingField;
        }
        private void set_Canvas(UnityEngine.Canvas value)
        {
            this.<Canvas>k__BackingField = value;
        }
        public int get_SortingOrder()
        {
            if((this.<Canvas>k__BackingField) != null)
            {
                    return this.<Canvas>k__BackingField.sortingOrder;
            }
            
            throw new NullReferenceException();
        }
        public void InitializeComponents()
        {
            this.<Canvas>k__BackingField = Utils.Extensions.GameObjectExtension.GetOrAddComponent<UnityEngine.Canvas>(target:  this.gameObject);
        }
        public virtual void Show()
        {
            this.gameObject.SetActive(value:  true);
            this.SetAsLastSibling();
            goto typeof(View.UIView).__il2cppRuntimeField_260;
        }
        protected virtual void OnShow()
        {
        
        }
        public virtual void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        protected virtual void Adapte()
        {
        
        }
        public UIView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
