using UnityEngine;

namespace View.CommonItem
{
    public class SelectedPanel : MonoBehaviour
    {
        // Fields
        public float minScale;
        public View.CommonItem.SelectedLetter selectedLetterPrefab;
        public Coffee.UIEffects.UIGradient uIGradient;
        public UnityEngine.CanvasGroup bgImageGroup;
        private UnityEngine.Color normalBottom;
        private UnityEngine.Color normalTop;
        private UnityEngine.Color rightBottom;
        private UnityEngine.Color rightTop;
        private UnityEngine.Color errorBottom;
        private UnityEngine.Color errorTop;
        private UnityEngine.Color extraBottom;
        private UnityEngine.Color extraTop;
        private UnityEngine.Color reRightBottom;
        private UnityEngine.Color reRightTop;
        private UnityEngine.Coroutine lastCoroutine;
        private System.Collections.Generic.List<View.CommonItem.SelectedLetter> selectedLetters;
        private System.Collections.Generic.List<char> _selectLetters;
        
        // Methods
        public System.Collections.Generic.List<View.CommonItem.SelectedLetter> GetLetters()
        {
            return (System.Collections.Generic.List<View.CommonItem.SelectedLetter>)this.selectedLetters;
        }
        private void Awake()
        {
            float val_8 = this.minScale;
            float val_10 = 1f;
            val_8 = val_10 - val_8;
            float val_9 = (float)UnityEngine.Screen.width;
            val_9 = val_9 / (float)UnityEngine.Screen.height;
            val_9 = val_9 + (-0.5625f);
            val_9 = (val_8 / (-0.1875f)) * val_9;
            val_10 = val_9 + val_10;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  UnityEngine.Mathf.Min(a:  1f, b:  val_10));
            this.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public void AddLetter(char letter)
        {
            this.selectedLetters.Add(item:  View.CommonItem.SelectedLetter.Create(parent:  this.transform, selectedLetterPrefab:  this.selectedLetterPrefab, letter:  letter));
            this.OnSelectLetter();
            if(this.selectedLetters != 1)
            {
                    return;
            }
            
            this.bgImageGroup.alpha = 1f;
            this.uIGradient.color1 = new UnityEngine.Color() {r = this.normalTop};
            this.uIGradient.color2 = new UnityEngine.Color() {r = this.normalBottom};
        }
        public void RemoveLast()
        {
            System.Collections.Generic.List<View.CommonItem.SelectedLetter> val_3 = this.selectedLetters;
            if()
            {
                    val_3 = val_3 + ((W9 - 1) << 3);
                UnityEngine.Object.Destroy(obj:  13059.gameObject);
                this.selectedLetters.RemoveAt(index:  82481151);
            }
            
            this.OnSelectLetter();
        }
        public void RemoveAll()
        {
            this.lastCoroutine = this.StartCoroutine(routine:  this.Clear(delay:  0.5f));
        }
        public void RemoveAll(View.Game.CheckAnswerType type)
        {
            if(type <= 3)
            {
                    var val_3 = 15448364 + (type) << 2;
                val_3 = val_3 + 15448364;
            }
            else
            {
                    this.lastCoroutine = this.StartCoroutine(routine:  this.Clear(delay:  0.5f));
            }
        
        }
        private System.Collections.IEnumerator Clear(float delay)
        {
            typeof(SelectedPanel.<Clear>d__23).__il2cppRuntimeField_10 = 0;
            typeof(SelectedPanel.<Clear>d__23).__il2cppRuntimeField_28 = this;
            typeof(SelectedPanel.<Clear>d__23).__il2cppRuntimeField_20 = delay;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void DoClear()
        {
            if(this.selectedLetters == null)
            {
                    return;
            }
            
            if(true == 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.selectedLetters.GetEnumerator();
            label_7:
            if(0.MoveNext() == false)
            {
                goto label_3;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Object.Destroy(obj:  0.gameObject);
            goto label_7;
            label_3:
            0.Dispose();
            this.uIGradient.color1 = new UnityEngine.Color() {r = this.normalTop};
            this.uIGradient.color2 = new UnityEngine.Color() {r = this.normalBottom};
            this.selectedLetters.Clear();
            this.bgImageGroup.alpha = 0f;
        }
        public void StopClearCoroutine()
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            if(this.lastCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.lastCoroutine);
            }
            
            this.DoClear();
        }
        private void OnSelectLetter()
        {
            var val_1;
            var val_2;
            var val_3;
            System.Collections.Generic.List<System.Char> val_4;
            if((this.selectedLetters == null) || (this.selectedLetters == null))
            {
                goto label_2;
            }
            
            this._selectLetters.Clear();
            val_1 = 0;
            label_10:
            if(val_1 >= 1152921507372162576)
            {
                goto label_5;
            }
            
            if(1152921507372162576 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this._selectLetters.Add(item:  public static UnityEngine.Purchasing.ProductCatalog UnityEngine.JsonUtility::FromJson<UnityEngine.Purchasing.ProductCatalog>(string json).__il2cppRuntimeField_18 + 24);
            val_1 = val_1 + 1;
            if(this.selectedLetters != null)
            {
                goto label_10;
            }
            
            throw new NullReferenceException();
            label_2:
            val_2 = 1152921512896575696;
            val_3 = 29;
            val_4 = 0;
            goto label_13;
            label_5:
            val_2 = 1152921512896575696;
            val_3 = 29;
            val_4 = this._selectLetters;
            label_13:
            Message.Messager.Dispatch<System.Collections.Generic.List<System.Char>>(cmd:  29, t:  val_4);
        }
        public SelectedPanel()
        {
            this.minScale = 0.8f;
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  0.596f, g:  0.235f, b:  0.047f, a:  1f);
            this.normalBottom = val_1.r;
            UnityEngine.Color val_2 = new UnityEngine.Color(r:  0.2f, g:  0.051f, b:  0.004f, a:  1f);
            this.normalTop = val_2.r;
            UnityEngine.Color val_3 = new UnityEngine.Color(r:  0.341f, g:  0.592f, b:  0.016f, a:  1f);
            this.rightBottom = val_3.r;
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  0.09f, g:  0.176f, b:  0f, a:  1f);
            this.rightTop = val_4.r;
            UnityEngine.Color val_5 = new UnityEngine.Color(r:  0.631f, g:  0.055f, b:  0f, a:  1f);
            this.errorBottom = val_5.r;
            UnityEngine.Color val_6 = new UnityEngine.Color(r:  0.376f, g:  0.031f, b:  0f, a:  1f);
            this.errorTop = val_6.r;
            UnityEngine.Color val_7 = new UnityEngine.Color(r:  0.992f, g:  0.604f, b:  0f, a:  1f);
            this.extraBottom = val_7.r;
            UnityEngine.Color val_8 = new UnityEngine.Color(r:  0.761f, g:  0.267f, b:  0f, a:  1f);
            this.extraTop = val_8.r;
            UnityEngine.Color val_9 = new UnityEngine.Color(r:  0.894f, g:  0.706f, b:  0.09f, a:  1f);
            this.reRightBottom = val_9.r;
            UnityEngine.Color val_10 = new UnityEngine.Color(r:  0.314f, g:  0.165f, b:  0.004f, a:  1f);
            this.reRightTop = val_10.r;
            this.selectedLetters = new System.Collections.Generic.List<View.CommonItem.SelectedLetter>();
            this._selectLetters = new System.Collections.Generic.List<System.Char>();
        }
    
    }

}
