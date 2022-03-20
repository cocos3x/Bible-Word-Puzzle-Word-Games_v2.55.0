using UnityEngine;

namespace View.CommonItem
{
    public class ResultBibleTextItem : RecyclableItem
    {
        // Fields
        private static UnityEngine.Material _shareMaterial;
        private static UnityEngine.Color _normalColor;
        public UnityEngine.Color normalFaceColor;
        private char _letter;
        private bool _show;
        private bool _useUnderline;
        private bool <playing>k__BackingField;
        private TMPro.TextMeshProUGUI textmeshPro;
        private TMPro.TextMeshProUGUI hideText;
        private UnityEngine.GameObject effect;
        private DG.Tweening.Sequence sequence;
        
        // Properties
        public char letter { get; set; }
        public bool show { get; set; }
        public bool useUnderline { get; set; }
        public bool playing { get; set; }
        
        // Methods
        public static View.CommonItem.ResultBibleTextItem Create(UnityEngine.Transform parent, View.CommonItem.ResultBibleTextItem prefab, char c, bool show = False, bool useUnderline = False)
        {
            View.CommonItem.ResultBibleTextItem val_1 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Create<View.CommonItem.ResultBibleTextItem>(prefab:  prefab, bufferSize:  40);
            val_1.name = prefab.name;
            val_1.transform.SetParent(parent:  parent, worldPositionStays:  false);
            val_1.letter = c;
            val_1.show = show;
            val_1.useUnderline = useUnderline;
            View.CommonItem.ResultBibleTextItem.SetInfo(material:  val_1.textmeshPro.fontSharedMaterial, color:  new UnityEngine.Color() {r = val_1.normalFaceColor});
            return val_1;
        }
        private static void SetInfo(UnityEngine.Material material, UnityEngine.Color color)
        {
            if(View.CommonItem.ResultBibleTextItem._shareMaterial != 0)
            {
                    return;
            }
            
            View.CommonItem.ResultBibleTextItem._shareMaterial = material;
            View.CommonItem.ResultBibleTextItem._normalColor = color.r;
            View.CommonItem.ResultBibleTextItem._shareMaterial.__il2cppRuntimeField_C = color.g;
            View.CommonItem.ResultBibleTextItem._shareMaterial.__il2cppRuntimeField_10 = color.b;
            View.CommonItem.ResultBibleTextItem._shareMaterial.__il2cppRuntimeField_14 = color.a;
        }
        public static void ResetMaterial()
        {
            View.CommonItem.ResultBibleTextItem._shareMaterial.SetFloat(name:  "_UnderlayDilate", value:  -1f);
            View.CommonItem.ResultBibleTextItem._shareMaterial.SetFloat(name:  "_GlowPower", value:  0f);
            View.CommonItem.ResultBibleTextItem._shareMaterial.SetColor(name:  "_FaceColor", value:  new UnityEngine.Color() {r = View.CommonItem.ResultBibleTextItem._normalColor, g = View.CommonItem.ResultBibleTextItem._shareMaterial.__il2cppRuntimeField_C, b = View.CommonItem.ResultBibleTextItem._shareMaterial.__il2cppRuntimeField_10, a = View.CommonItem.ResultBibleTextItem._shareMaterial.__il2cppRuntimeField_14});
        }
        public static void DoTextAnim(System.Action callback)
        {
            var val_23;
            DG.Tweening.Core.DOGetter<System.Single> val_25;
            DG.Tweening.Core.DOSetter<System.Single> val_27;
            var val_29;
            DG.Tweening.Core.DOGetter<System.Single> val_31;
            DG.Tweening.Core.DOSetter<System.Single> val_33;
            var val_34;
            DG.Tweening.Core.DOGetter<UnityEngine.Color> val_36;
            DG.Tweening.Core.DOSetter<UnityEngine.Color> val_38;
            typeof(ResultBibleTextItem.<>c__DisplayClass5_0).__il2cppRuntimeField_10 = callback;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            View.CommonItem.ResultBibleTextItem._shareMaterial.SetColor(name:  "_FaceColor", value:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            val_23 = null;
            val_23 = null;
            val_25 = ResultBibleTextItem.<>c.<>9__5_0;
            if(val_25 == null)
            {
                    DG.Tweening.Core.DOGetter<System.Single> val_4 = null;
                val_25 = val_4;
                val_4 = new DG.Tweening.Core.DOGetter<System.Single>(object:  ResultBibleTextItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Single ResultBibleTextItem.<>c::<DoTextAnim>b__5_0());
                val_23 = null;
                ResultBibleTextItem.<>c.<>9__5_0 = val_25;
            }
            
            val_23 = null;
            val_27 = ResultBibleTextItem.<>c.<>9__5_1;
            if(val_27 == null)
            {
                    DG.Tweening.Core.DOSetter<System.Single> val_5 = null;
                val_27 = val_5;
                val_5 = new DG.Tweening.Core.DOSetter<System.Single>(object:  ResultBibleTextItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ResultBibleTextItem.<>c::<DoTextAnim>b__5_1(float v));
                ResultBibleTextItem.<>c.<>9__5_1 = val_27;
            }
            
            val_29 = null;
            val_29 = null;
            val_31 = ResultBibleTextItem.<>c.<>9__5_2;
            if(val_31 == null)
            {
                    DG.Tweening.Core.DOGetter<System.Single> val_10 = null;
                val_31 = val_10;
                val_10 = new DG.Tweening.Core.DOGetter<System.Single>(object:  ResultBibleTextItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Single ResultBibleTextItem.<>c::<DoTextAnim>b__5_2());
                val_29 = null;
                ResultBibleTextItem.<>c.<>9__5_2 = val_31;
            }
            
            val_29 = null;
            val_33 = ResultBibleTextItem.<>c.<>9__5_3;
            if(val_33 == null)
            {
                    DG.Tweening.Core.DOSetter<System.Single> val_11 = null;
                val_33 = val_11;
                val_11 = new DG.Tweening.Core.DOSetter<System.Single>(object:  ResultBibleTextItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ResultBibleTextItem.<>c::<DoTextAnim>b__5_3(float v));
                ResultBibleTextItem.<>c.<>9__5_3 = val_33;
            }
            
            val_34 = null;
            val_34 = null;
            val_36 = ResultBibleTextItem.<>c.<>9__5_4;
            if(val_36 == null)
            {
                    DG.Tweening.Core.DOGetter<UnityEngine.Color> val_16 = null;
                val_36 = val_16;
                val_16 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  ResultBibleTextItem.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Color ResultBibleTextItem.<>c::<DoTextAnim>b__5_4());
                val_34 = null;
                ResultBibleTextItem.<>c.<>9__5_4 = val_36;
            }
            
            val_34 = null;
            val_38 = ResultBibleTextItem.<>c.<>9__5_5;
            if(val_38 == null)
            {
                    DG.Tweening.Core.DOSetter<UnityEngine.Color> val_17 = null;
                val_38 = val_17;
                val_17 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  ResultBibleTextItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ResultBibleTextItem.<>c::<DoTextAnim>b__5_5(UnityEngine.Color C));
                ResultBibleTextItem.<>c.<>9__5_5 = val_38;
            }
            
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.DOTween.Sequence(), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  val_25, setter:  val_27, endValue:  1f, duration:  0.25f), delay:  0.5f), loops:  4, loopType:  1)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  val_31, setter:  val_33, endValue:  1f, duration:  0.25f), delay:  0.5f), loops:  4, loopType:  1)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTween.To(getter:  val_36, setter:  val_38, endValue:  new UnityEngine.Color() {r = View.CommonItem.ResultBibleTextItem._normalColor, g = View.CommonItem.ResultBibleTextItem._shareMaterial.__il2cppRuntimeField_C, b = View.CommonItem.ResultBibleTextItem._shareMaterial.__il2cppRuntimeField_10, a = View.CommonItem.ResultBibleTextItem._shareMaterial.__il2cppRuntimeField_14}, duration:  0.5f), delay:  1.5f), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void ResultBibleTextItem.<>c__DisplayClass5_0::<DoTextAnim>b__6())));
        }
        public char get_letter()
        {
            return (char)this._letter;
        }
        public void set_letter(char value)
        {
            this._letter = value;
            this.textmeshPro.text = value.ToString();
        }
        public bool get_show()
        {
            return (bool)this._show;
        }
        public void set_show(bool value)
        {
            this._show = value;
            UnityEngine.Transform val_2 = this.textmeshPro.transform;
            if(value != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                val_2.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
                this = this.textmeshPro.transform;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            }
            else
            {
                    UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            }
            
            val_2.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        public bool get_useUnderline()
        {
            return (bool)this._useUnderline;
        }
        public void set_useUnderline(bool value)
        {
            string val_1;
            if((value == false) || (this._show == true))
            {
                goto label_3;
            }
            
            char val_1 = this._letter;
            val_1 = val_1 & 4294967263;
            val_1 = val_1 - 65;
            val_1 = val_1 & 65535;
            if(val_1 > '')
            {
                goto label_3;
            }
            
            this._useUnderline = true;
            val_1 = "_";
            goto label_5;
            label_3:
            this._useUnderline = false;
            val_1 = "";
            label_5:
            this.hideText.text = val_1;
        }
        public bool get_playing()
        {
            return (bool)this.<playing>k__BackingField;
        }
        public void set_playing(bool value)
        {
            this.<playing>k__BackingField = value;
        }
        private void Awake()
        {
            this.textmeshPro = this.transform.Find(n:  "Content").GetComponent<TMPro.TextMeshProUGUI>();
            this.effect = this.transform.Find(n:  "Content/eff_verses_sweep").gameObject;
            this.hideText = this.transform.Find(n:  "Hiden").GetComponent<TMPro.TextMeshProUGUI>();
        }
        private void OnEnable()
        {
            this.sequence = DG.Tweening.DOTween.Sequence();
        }
        public void Show(UnityEngine.Vector3 startPosition)
        {
            if(this._show == true)
            {
                    return;
            }
            
            if((this.<playing>k__BackingField) != false)
            {
                    return;
            }
            
            this.<playing>k__BackingField = true;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.textmeshPro.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.textmeshPro.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            int val_5 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  1.3f);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  this.sequence, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.textmeshPro.transform, endValue:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, duration:  0.5f, snapping:  false)), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.CommonItem.ResultBibleTextItem::<Show>b__29_0())), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.CommonItem.ResultBibleTextItem::<Show>b__29_1()))), atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.textmeshPro.transform, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  0.5f)), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.textmeshPro.transform, endValue:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, duration:  0.5f), delay:  1f)), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.CommonItem.ResultBibleTextItem::<Show>b__29_2())), id:  this);
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            if(this.sequence == null)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.sequence, complete:  false);
        }
        public ResultBibleTextItem()
        {
        
        }
        private void <Show>b__29_0()
        {
            if(this.effect != null)
            {
                    this.effect.SetActive(value:  true);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <Show>b__29_1()
        {
            this.effect.SetActive(value:  false);
            if(this._useUnderline == false)
            {
                    return;
            }
            
            this.hideText.text = "";
        }
        private void <Show>b__29_2()
        {
            this.<playing>k__BackingField = false;
        }
    
    }

}
