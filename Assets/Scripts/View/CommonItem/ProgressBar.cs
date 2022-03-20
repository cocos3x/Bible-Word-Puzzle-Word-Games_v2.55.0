using UnityEngine;

namespace View.CommonItem
{
    public class ProgressBar : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text text;
        public UnityEngine.UI.Image image;
        public UnityEngine.UI.Image mask;
        public bool canReduce;
        public int contentMinWidth;
        public int dtWidth;
        public float coverMoveSpeed;
        private UnityEngine.Events.UnityAction onProgressComplete;
        private UnityEngine.UI.Image coverImage;
        private float width;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.WaitInitWidth());
        }
        private void Update()
        {
            if(this.coverImage == 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_3 = this.coverImage.rectTransform.anchoredPosition;
            val_3.x = val_3.x + this.coverMoveSpeed;
            this = this.coverImage.rectTransform;
            UnityEngine.Vector2 val_7 = this.coverImage.rectTransform.anchoredPosition;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  (val_3.x < this.width) ? (val_3.x) : 0f, y:  val_7.y);
            this.anchoredPosition = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        }
        public void SetTitleText(string title)
        {
            if(this.text == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  "Progress bar title text object is null");
            }
        
        }
        public void SetOnCompleteListenter(UnityEngine.Events.UnityAction action)
        {
            this.onProgressComplete = action;
        }
        public void UpdateProgress(float progress, float time = 0.5, bool reCalculateWidth = False)
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.WaitUpdateProgress(progress:  progress, time:  time));
        }
        private System.Collections.IEnumerator WaitUpdateProgress(float progress, float time = 0.5)
        {
            typeof(ProgressBar.<WaitUpdateProgress>d__15).__il2cppRuntimeField_20 = this;
            typeof(ProgressBar.<WaitUpdateProgress>d__15).__il2cppRuntimeField_28 = progress;
            typeof(ProgressBar.<WaitUpdateProgress>d__15).__il2cppRuntimeField_38 = time;
            return (System.Collections.IEnumerator)new ProgressBar.<WaitUpdateProgress>d__15(<>1__state:  0);
        }
        private System.Collections.IEnumerator WaitInitWidth()
        {
            typeof(ProgressBar.<WaitInitWidth>d__16).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new ProgressBar.<WaitInitWidth>d__16(<>1__state:  0);
        }
        private void InitWidth()
        {
            UnityEngine.Rect val_3 = (null == null) ? this.transform : 0.rect;
            UnityEngine.Vector2 val_4 = val_3.m_XMin.size;
            val_4.x = val_4.x - (float)this.dtWidth;
            this.width = val_4.x;
            if(this.mask == 0)
            {
                    return;
            }
            
            this.coverImage = this.mask.transform.Find(n:  "Cover").GetComponent<UnityEngine.UI.Image>();
            UnityEngine.UI.Image val_11 = this.mask.transform.Find(n:  "Cover/Image").GetComponent<UnityEngine.UI.Image>();
            UnityEngine.Vector2 val_14 = this.coverImage.rectTransform.sizeDelta;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  this.width, y:  val_14.y);
            this.coverImage.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
            UnityEngine.Vector2 val_18 = val_11.rectTransform.sizeDelta;
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  this.width, y:  val_18.y);
            val_11.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_19.x, y = val_19.y};
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  -this.width, y:  0f);
            val_11.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_21.x, y = val_21.y};
        }
        private float GetCurrentWidth()
        {
            if(this.image == 0)
            {
                    return (float)val_3.x;
            }
            
            UnityEngine.Vector2 val_3 = this.image.rectTransform.sizeDelta;
            return (float)val_3.x;
        }
        private void SetCurrentWidth(float width)
        {
            if(this.image == 0)
            {
                    return;
            }
            
            this = this.image.rectTransform;
            UnityEngine.Vector2 val_4 = this.image.rectTransform.sizeDelta;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  width, y:  val_4.y);
            this.sizeDelta = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        }
        public ProgressBar()
        {
            this.dtWidth = 46;
            this.coverMoveSpeed = 2f;
        }
    
    }

}
