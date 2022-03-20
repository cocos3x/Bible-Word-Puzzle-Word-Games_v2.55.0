using UnityEngine;

namespace View.Home
{
    public class HomeTitle : MonoBehaviour
    {
        // Fields
        private readonly UnityEngine.Vector2 TitleWordPos;
        private View.Home.TitleWords _titleWords;
        
        // Methods
        public void LocaleTranslate()
        {
            var val_6;
            var val_7;
            string val_8;
            if(this._titleWords != null)
            {
                    val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Log.D.Error(message:  "HomeTitle LocaleTranslate 语言发生变更...", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                UnityEngine.Object.Destroy(obj:  this._titleWords.gameObject);
                this._titleWords = 0;
            }
            
            val_7 = "Prefab/CommonItem/TitleWords";
            Locale.LocaleE val_2 = Locale.LocaleManager.GetCurLanguage();
            if(val_2 == 3)
            {
                goto label_11;
            }
            
            if(val_2 == 2)
            {
                goto label_12;
            }
            
            if(val_2 != 1)
            {
                goto label_13;
            }
            
            val_8 = "Prefab/CommonPortuguese/TitleWordPt";
            goto label_15;
            label_12:
            val_8 = "Prefab/CommonSpanish/TitleWordsEs";
            goto label_15;
            label_11:
            val_8 = "Prefab/CommonFrench/TitleWordFr";
            label_15:
            label_13:
            View.Home.TitleWords val_4 = View.GameViewFactory.CreateTitleWord(parent:  this.transform, path:  val_8);
            this._titleWords = val_4;
            val_4.InitTitleWord();
            this._titleWords.transform.anchoredPosition = new UnityEngine.Vector2() {x = this.TitleWordPos};
        }
        public void PlayWordAni()
        {
            if(this._titleWords != null)
            {
                    this._titleWords.PlayAni();
                return;
            }
            
            throw new NullReferenceException();
        }
        public HomeTitle()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  16f);
            this.TitleWordPos = val_1.x;
        }
    
    }

}
