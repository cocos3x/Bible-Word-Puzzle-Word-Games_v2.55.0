using UnityEngine;

namespace View.CommonItem
{
    public class ChapterProgressBar : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Image progressBar;
        private UnityEngine.Vector2 _maxProgressLength;
        private float _singleLength;
        private int _maxProgress;
        private int targetProgress;
        
        // Methods
        public void Init()
        {
            UnityEngine.RectTransform val_1 = this.progressBar.rectTransform;
            UnityEngine.Vector2 val_2 = val_1.sizeDelta;
            this._maxProgressLength = val_2;
            mem[1152921512849111172] = val_2.y;
            UnityEngine.Rect val_5 = val_1.parent.GetComponent<UnityEngine.RectTransform>().rect;
            float val_6 = val_5.m_XMin.width;
            val_6 = val_6 + (-30f);
            this._maxProgressLength = val_6;
            val_6 = val_6 / (float)this._maxProgress;
            this._singleLength = val_6;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  0f, y:  val_5.m_YMin);
            val_1.sizeDelta = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            val_1.gameObject.SetActive(value:  true);
        }
        public void Init(int progress)
        {
            UnityEngine.RectTransform val_1 = this.progressBar.rectTransform;
            UnityEngine.Vector2 val_2 = val_1.sizeDelta;
            this._maxProgressLength = val_2;
            mem[1152921512849264132] = val_2.y;
            UnityEngine.Rect val_5 = val_1.parent.GetComponent<UnityEngine.RectTransform>().rect;
            float val_6 = val_5.m_XMin.width;
            val_6 = val_6 + (-30f);
            this._maxProgressLength = val_6;
            val_6 = val_6 / (float)this._maxProgress;
            this._singleLength = val_6;
            val_6 = val_6 * (float)progress;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_6, y:  val_5.m_YMin);
            val_1.sizeDelta = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            val_1.gameObject.SetActive(value:  true);
        }
        public void SetMaxProgress(int maxProgress)
        {
            this._maxProgress = maxProgress;
        }
        public void UpdateProgress(int progress)
        {
            this.targetProgress = progress;
            if(progress >= 1)
            {
                    int val_5 = this.targetProgress;
                float val_6 = this._singleLength;
                val_5 = val_5 - 1;
                val_6 = val_6 * (float)val_5;
                UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_6, y:  null);
                this.progressBar.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            }
            
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.UpdateProgressInternal(progress:  progress));
        }
        private System.Collections.IEnumerator UpdateProgressInternal(int progress)
        {
            typeof(ChapterProgressBar.<UpdateProgressInternal>d__9).__il2cppRuntimeField_10 = 0;
            typeof(ChapterProgressBar.<UpdateProgressInternal>d__9).__il2cppRuntimeField_28 = this;
            typeof(ChapterProgressBar.<UpdateProgressInternal>d__9).__il2cppRuntimeField_20 = progress;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public ChapterProgressBar()
        {
        
        }
    
    }

}
