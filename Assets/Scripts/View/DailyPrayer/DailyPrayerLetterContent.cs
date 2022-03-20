using UnityEngine;

namespace View.DailyPrayer
{
    public class DailyPrayerLetterContent : MonoBehaviour
    {
        // Fields
        public UnityEngine.LineRenderer lineRenderer;
        public UnityEngine.LineRenderer guideLineRenderer;
        public View.CommonItem.LetterBlock letterBlockPrefab;
        public float sizeProportionTest;
        public float sizeRatio;
        public float maxSize;
        public View.CommonItem.SelectedPanel selectedPanel;
        private bool canDraw;
        private bool isDragging;
        private bool inited;
        private UnityEngine.RectTransform rectTransform;
        private UnityEngine.Transform handTransform;
        private UnityEngine.Transform centerTransform;
        private System.Collections.Generic.List<View.CommonItem.LetterBlock> letterBlocks;
        private System.Collections.Generic.List<View.CommonItem.LetterBlock> selectedBlocks;
        private System.Collections.Generic.List<UnityEngine.Vector3> blockLocalPositions;
        private System.Collections.Generic.List<UnityEngine.Vector3> linePositions;
        private UnityEngine.Coroutine clearLineCor;
        private View.Dialog.DailyGuide.DailyGuideDialog _guideDialog;
        private System.Collections.Generic.List<UnityEngine.Vector3[]> _guidePaths;
        private System.Collections.Generic.List<string> _guideWords;
        private DG.Tweening.Tweener _guideTweener;
        private UnityEngine.Coroutine _showGuideCoroutine;
        private bool _hasAd;
        private Data.DailyPrayer.DailyPrayerBean _levelItem;
        
        // Properties
        public bool hasAd { get; set; }
        public Data.DailyPrayer.DailyPrayerBean levelBean { get; set; }
        
        // Methods
        public bool get_hasAd()
        {
            return (bool)this._hasAd;
        }
        public void set_hasAd(bool value)
        {
            this._hasAd = value;
        }
        public Data.DailyPrayer.DailyPrayerBean get_levelBean()
        {
            return (Data.DailyPrayer.DailyPrayerBean)this._levelItem;
        }
        public void set_levelBean(Data.DailyPrayer.DailyPrayerBean value)
        {
            this._levelItem = value;
            this.InitLetterContent();
        }
        private void Awake()
        {
            UnityEngine.RectTransform val_7;
            UnityEngine.Transform val_1 = this.transform;
            if(val_1 != null)
            {
                    var val_2 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_7 = 0;
            }
            
            this.rectTransform = val_7;
            this.centerTransform = this.transform.Find(n:  "Center");
            this.handTransform = this.transform.Find(n:  "Hand");
        }
        private void InitLetterContent()
        {
            float val_40;
            float val_42;
            int val_43;
            var val_44;
            int val_45;
            int val_46;
            string val_47;
            this.ClearLetterContent();
            UnityEngine.Rect val_1 = this.rectTransform.rect;
            UnityEngine.Vector2 val_2 = val_1.m_XMin.size;
            float val_3 = UnityEngine.Mathf.Min(a:  val_2.x, b:  val_2.y);
            val_3 = val_3 * this.sizeProportionTest;
            float val_4 = UnityEngine.Mathf.Min(a:  val_3, b:  this.maxSize);
            float val_40 = this.sizeRatio;
            val_40 = val_40 * ((float)this._levelItem.letters.m_stringLength - 3);
            val_40 = val_4 * val_40;
            float val_6 = val_4 - val_40;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.one;
            val_40 = val_7.y;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_40}, d:  UnityEngine.Mathf.Min(a:  val_2.x, b:  val_2.y));
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.one;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, d:  val_6);
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            val_42 = val_12.x;
            object[] val_13 = new object[8];
            val_13[0] = "letter content size = ";
            val_43 = val_13.Length;
            val_13[1] = val_12;
            val_43 = val_13.Length;
            val_13[2] = ", size = ";
            val_44 = 1152921504618561536;
            val_45 = val_13.Length;
            val_13[3] = val_6;
            val_45 = val_13.Length;
            float val_14 = val_42 * 0.5f;
            val_13[4] = ", radiusX = ";
            val_46 = val_13.Length;
            val_13[5] = val_14;
            val_46 = val_13.Length;
            float val_15 = val_12.y * 0.5f;
            val_13[6] = ", radiusY = ";
            val_13[7] = val_15;
            UnityEngine.Debug.Log(message:  +val_13);
            val_47 = this._levelItem.letters;
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide()) != true)
            {
                    Utils.Extensions.ListExtension.Shuffle<System.Char>(list:  new System.Collections.Generic.List<System.Char>(collection:  val_47), count:  0);
            }
            
            float val_43 = 1.570796f;
            val_44 = 1152921512630074768;
            var val_42 = 0;
            UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_14 * val_43, y:  val_15 * val_43);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
            val_42 = val_24.x;
            val_40 = val_24.z;
            this.blockLocalPositions.Add(item:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_47 = mem[((UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished & 4294967295) + 0) + 32];
            val_47 = ((UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished & 4294967295) + 0) + 32;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            ((UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished & 4294967295) + 0) + 32 + 32.letter = List<T>.__il2cppRuntimeField_20>>0&0xFFFF;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.one;
            float val_41 = this.maxSize;
            val_41 = val_6 / val_41;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  val_41);
            localScale = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            localPosition = new UnityEngine.Vector3() {x = val_42, y = val_24.y, z = val_40};
            val_42 = val_42 + 1;
            val_43 = (6.283185f / (float)this._levelItem.letters.m_stringLength) + val_43;
            this.inited = true;
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.IsDailyNewGuide) != false)
            {
                    if((Common.Singleton<Data.Login.LoginDataManager>.Instance.LimitFirstVersion(version:  "2.26.0")) == true)
            {
                goto label_61;
            }
            
            }
            
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.UserLoginDays) > 1)
            {
                    return;
            }
            
            if((Common.Singleton<Data.Login.LoginDataManager>.Instance.LimitFirstVersion(version:  "2.26.0")) == true)
            {
                    return;
            }
            
            label_61:
            UnityEngine.Coroutine val_39 = Utils.Extensions.MonoBehaviourExtension.WaitSecondsDo(behaviour:  this, call:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerLetterContent::<InitLetterContent>b__32_0()), seconds:  0.55f);
        }
        private void Update()
        {
            float val_24;
            float val_25;
            float val_26;
            if(this.inited == false)
            {
                    return;
            }
            
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
                if(phase == 3)
            {
                    Message.Messager.Dispatch<System.Boolean>(cmd:  59, t:  true);
            }
            
            }
            
            if(this.isDragging != true)
            {
                    if((Utils.Extensions.EventSystemExtension.IsPointerOverUIObject(self:  UnityEngine.EventSystems.EventSystem.current)) == true)
            {
                    return;
            }
            
            }
            
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_7 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.TouchPhase val_8 = phase;
                if(val_8 == 0)
            {
                    UnityEngine.Touch val_9 = UnityEngine.Input.GetTouch(index:  val_8);
                UnityEngine.Vector2 val_10 = position;
                val_24 = val_10.x;
                val_25 = val_24;
                val_26 = val_10.y;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_25, y = val_26});
                this.OnPointerDown(pointPosition:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            }
            
            }
            
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_13 = UnityEngine.Input.GetTouch(index:  0);
                if(phase == 1)
            {
                    UnityEngine.Touch val_15 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.Vector2 val_16 = position;
                val_24 = val_16.x;
                val_25 = val_24;
                val_26 = val_16.y;
                UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_25, y = val_26});
                this.OnDrag(pointPosition:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            }
            
            }
            
            if(UnityEngine.Input.touchCount < 1)
            {
                    return;
            }
            
            UnityEngine.Touch val_19 = UnityEngine.Input.GetTouch(index:  0);
            if(phase != 3)
            {
                    return;
            }
            
            UnityEngine.Touch val_21 = UnityEngine.Input.GetTouch(index:  0);
            UnityEngine.Vector2 val_22 = position;
            val_24 = val_22.x;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24, y = val_22.y});
            this.OnPointerUp(pointPosition:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        }
        private void OnPointerDown(UnityEngine.Vector3 pointPosition)
        {
            if((Utils.Extensions.RectTransformExtension.InRect(self:  this.transform, position:  new UnityEngine.Vector3() {x = pointPosition.x, y = pointPosition.y, z = pointPosition.z}, worldSpace:  false)) == false)
            {
                    return;
            }
            
            if(this.canDraw == false)
            {
                    return;
            }
            
            if(View.DailyPrayer.DailyPrayerController.GetInstance() == 0)
            {
                    return;
            }
            
            View.DailyPrayer.DailyPrayerController val_5 = View.DailyPrayer.DailyPrayerController.GetInstance();
            if((val_5.<isGameComplete>k__BackingField) != false)
            {
                    return;
            }
            
            if(this.clearLineCor != null)
            {
                    this.StopCoroutine(routine:  this.clearLineCor);
            }
            
            Message.Messager.Dispatch<System.Boolean>(cmd:  59, t:  false);
            this.selectedPanel.StopClearCoroutine();
            this.DealOperat(pointPosition:  new UnityEngine.Vector3() {x = pointPosition.x, y = pointPosition.y, z = pointPosition.z});
        }
        private void OnDrag(UnityEngine.Vector3 pointPosition)
        {
            if(this.isDragging == false)
            {
                    return;
            }
            
            this.linePositions.Clear();
            this.DealOperat(pointPosition:  new UnityEngine.Vector3() {x = pointPosition.x, y = pointPosition.y, z = pointPosition.z});
        }
        private void OnPointerUp(UnityEngine.Vector3 pointPosition)
        {
            var val_2;
            var val_3;
            System.Collections.Generic.List<View.CommonItem.LetterBlock> val_25;
            string val_26;
            var val_27;
            var val_28;
            string val_29;
            View.Dialog.DailyGuide.DailyGuideDialog val_30;
            if(this.isDragging == false)
            {
                goto label_3;
            }
            
            val_25 = this.selectedBlocks;
            this.isDragging = false;
            if(val_25 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.isDragging < true)
            {
                goto label_3;
            }
            
            val_26 = "";
            List.Enumerator<T> val_1 = val_25.GetEnumerator();
            label_7:
            val_27 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_4;
            }
            
            if(val_2 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_2 + 32) == 0)
            {
                    throw new NullReferenceException();
            }
            
            string val_6 = val_26 + val_2 + 32 + 24.ToString()(val_2 + 32 + 24.ToString());
            val_2.selected = false;
            goto label_7;
            label_4:
            val_29 = public System.Void List.Enumerator<View.CommonItem.LetterBlock>::Dispose();
            val_3.Dispose();
            val_25 = Logic.Game.GameManager.gameSound;
            if(val_25 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_29 = "cancel";
            val_25.Play(clipName:  val_29, volumeScale:  1f, loop:  false, delay:  0f);
            val_26 = this.selectedPanel;
            if(val_26 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_29 = val_26.Clear(delay:  0.5f);
            this.selectedPanel.lastCoroutine = val_26.StartCoroutine(routine:  val_29);
            val_25 = this.selectedBlocks;
            if(val_25 == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_9 = val_25.GetEnumerator();
            label_15:
            val_27 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            val_28 = val_2;
            if(val_28 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_28.DoScaleNormal();
            goto label_15;
            label_13:
            val_29 = public System.Void List.Enumerator<View.CommonItem.LetterBlock>::Dispose();
            val_3.Dispose();
            goto label_71;
            label_32:
            val_27 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_30;
            }
            
            val_28 = val_2;
            if(val_28 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_28.Shake();
            goto label_32;
            label_30:
            val_29 = public System.Void List.Enumerator<View.CommonItem.LetterBlock>::Dispose();
            val_3.Dispose();
            val_26 = 3;
            goto label_67;
            label_45:
            if(val_3.MoveNext() == false)
            {
                goto label_43;
            }
            
            val_2.Shake();
            goto label_45;
            label_43:
            val_29 = public System.Void List.Enumerator<View.CommonItem.LetterBlock>::Dispose();
            val_3.Dispose();
            val_30 = 0;
            if((val_30 == 1) || (419 != 419))
            {
                goto label_48;
            }
            
            val_26 = 1;
            goto label_67;
            label_48:
            val_25 = this.selectedBlocks;
            if(val_25 == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_19 = val_25.GetEnumerator();
            label_53:
            val_29 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_51;
            }
            
            val_25 = val_2;
            if(val_25 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_25.DoJelly();
            goto label_53;
            label_51:
            val_29 = public System.Void List.Enumerator<View.CommonItem.LetterBlock>::Dispose();
            val_3.Dispose();
            label_67:
            val_25 = this.selectedPanel;
            if(val_25 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_29 = ;
            val_25.RemoveAll(type:  val_29);
            label_71:
            val_25 = this.linePositions;
            if(val_25 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_29 = public System.Void System.Collections.Generic.List<UnityEngine.Vector3>::Clear();
            val_25.Clear();
            val_25 = this.selectedBlocks;
            if(val_25 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_29 = public System.Void System.Collections.Generic.List<View.CommonItem.LetterBlock>::Clear();
            val_25.Clear();
            label_3:
            val_25 = this.lineRenderer;
            if(val_25 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_25.positionCount < 1)
            {
                    return;
            }
            
            this.clearLineCor = Utils.Extensions.MonoBehaviourExtension.WaitSecondsDo(behaviour:  this, call:  new System.Action(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerLetterContent::ClearLine()), seconds:  0.15f);
        }
        private void DealOperat(UnityEngine.Vector3 pointPosition)
        {
            var val_2;
            var val_3;
            var val_23;
            var val_25;
            UnityEngine.Object val_27;
            System.Collections.Generic.List<View.CommonItem.LetterBlock> val_28;
            System.Collections.Generic.List<View.CommonItem.LetterBlock> val_30;
            UnityEngine.Vector3[] val_31;
            val_23 = 1152921512631166896;
            List.Enumerator<T> val_1 = this.letterBlocks.GetEnumerator();
            label_4:
            val_25 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_2;
            }
            
            val_27 = val_2;
            if(val_27 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((Utils.Extensions.RectTransformExtension.InRect(self:  val_2 + 48, position:  new UnityEngine.Vector3() {x = pointPosition.x, y = pointPosition.y, z = pointPosition.z}, worldSpace:  false, rectScale:  1.2f)) == false)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            val_27 = 0;
            label_5:
            val_3.Dispose();
            if((UnityEngine.Object.op_Implicit(exists:  val_27)) == false)
            {
                goto label_45;
            }
            
            val_28 = this.selectedBlocks;
            if()
            {
                goto label_10;
            }
            
            val_28 = this.selectedBlocks;
            if(((15228928 + ((UnityEngine.Object.__il2cppRuntimeField_cctor_finished - 2)) << 3) + 32) != val_27)
            {
                goto label_13;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            (UnityEngine.Object.__il2cppRuntimeField_cctor_finished + ((UnityEngine.Object.__il2cppRuntimeField_cctor_finished - 1)) << 3) + 32.selected = false;
            (UnityEngine.Object.__il2cppRuntimeField_cctor_finished + ((UnityEngine.Object.__il2cppRuntimeField_cctor_finished - 1)) << 3) + 32.DoScaleNormal();
            bool val_10 = this.selectedBlocks.Remove(item:  (UnityEngine.Object.__il2cppRuntimeField_cctor_finished + ((UnityEngine.Object.__il2cppRuntimeField_cctor_finished - 1)) << 3) + 32);
            this.selectedPanel.RemoveLast();
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() == false)
            {
                goto label_21;
            }
            
            goto label_24;
            label_13:
            label_10:
            if((val_28.Contains(item:  val_27)) == true)
            {
                goto label_45;
            }
            
            val_27.selected = true;
            val_27.DoScaleBig();
            this.selectedBlocks.Add(item:  val_27);
            this.selectedPanel.AddLetter(letter:  ' ');
            val_30 = this.selectedBlocks;
            this.isDragging = true;
            this.StopGuide();
            val_30 = this.selectedBlocks;
            label_24:
            Logic.Game.GameManager.gameSound.PlayConnect(index:  0);
            label_45:
            if(val_30 < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_13 = this.selectedBlocks.GetEnumerator();
            val_23 = 1152921512630073744;
            label_40:
            val_25 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_37;
            }
            
            if(val_2 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Vector3 val_15 = val_2.position;
            UnityEngine.Vector3 val_16 = val_2.position;
            val_3 = 0;
            val_25 = 0;
            UnityEngine.Vector3 val_17 = new UnityEngine.Vector3(x:  val_15.x, y:  val_16.y, z:  90f);
            if(this.linePositions == null)
            {
                    throw new NullReferenceException();
            }
            
            this.linePositions.Add(item:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            goto label_40;
            label_37:
            val_3.Dispose();
            UnityEngine.Vector3 val_19 = Utils.Extensions.CameraExtension.ScreenToWorldPointExt(camera:  UnityEngine.Camera.main, pointPosition:  new UnityEngine.Vector3() {x = pointPosition.x, y = pointPosition.y, z = pointPosition.z});
            val_3 = 0;
            UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_19.x, y:  val_19.y, z:  90f);
            this.linePositions.Add(item:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            val_31 = this.linePositions.ToArray();
            if(this.linePositions >= 3)
            {
                    val_31 = Common.EzPath.GetSmoothPoints(points:  val_31, smooth:  10);
            }
            
            this.DrawLine(linePositions:  val_31);
            return;
            label_21:
            Logic.Game.GameManager.gameSound.Play(clipName:  "cancel", volumeScale:  1f, loop:  false, delay:  0f);
            goto label_45;
        }
        private void ClearLine()
        {
            if(this.lineRenderer != null)
            {
                    this.lineRenderer.positionCount = 0;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void DrawLine(UnityEngine.Vector3[] linePositions)
        {
            this.lineRenderer.positionCount = linePositions.Length;
            this.lineRenderer.SetPositions(positions:  linePositions);
        }
        private void PlayHideBlockAni(bool isGameComplete)
        {
            var val_3;
            float val_4;
            bool val_3 = true;
            if(this.letterBlocks == null)
            {
                    return;
            }
            
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                if(0 != 0)
            {
                    val_4 = ((float)val_3 + 0) * 0.1f;
            }
            else
            {
                    val_4 = 0f;
            }
            
                if(val_3 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 0;
                (true + 0) + 32.DestroyEffect(time:  0.3f, isGameComplete:  isGameComplete, delay:  val_4);
                val_4 = val_4 + 1;
                val_3 = 0 - 1;
            }
            while(val_3 > val_4);
        
        }
        private void OnRecycleBlock()
        {
            System.Collections.Generic.List<View.CommonItem.LetterBlock> val_3;
            var val_4;
            bool val_4 = true;
            val_3 = this.letterBlocks;
            val_4 = 4;
            label_12:
            var val_1 = val_4 - 4;
            if(val_1 >= val_4)
            {
                goto label_2;
            }
            
            val_4 = val_4 & 4294967295;
            if(val_1 >= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(((true & 4294967295) + 32) != 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                View.CommonItem.LetterBlock val_3 = public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184.Recycle<View.CommonItem.LetterBlock>(obj:  public static View.Dialog.Common.MonoPoolManager Common.MonoSingleton<View.Dialog.Common.MonoPoolManager>::get_instance().__il2cppRuntimeField_18 + 192 + 184 + 32, isUi:  true);
            }
            
            val_3 = this.letterBlocks;
            val_4 = val_4 + 1;
            if(val_3 != null)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
            label_2:
            val_3.Clear();
        }
        public void ClearLetterContent()
        {
            this.canDraw = true;
            this.isDragging = false;
            this.inited = false;
            this.OnRecycleBlock();
            this.selectedBlocks.Clear();
            this.blockLocalPositions.Clear();
            this.linePositions.Clear();
            this.guideLineRenderer.positionCount = 0;
            Logic.DailyPrayer.DailyPrayerControllers val_1 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            val_1.<NowCurLevelUseRefreshCount>k__BackingField = 0;
        }
        public void Shuffle()
        {
            string val_28;
            var val_29;
            var val_30;
            if((Logic.Game.GameManager.gameDialog.IsDialogShowing(dialogName:  "DailyGuideDialog")) == true)
            {
                    return;
            }
            
            if(this._levelItem == null)
            {
                    return;
            }
            
            Logic.DailyPrayer.DailyPrayerControllers val_2 = Common.SingletonController<Logic.DailyPrayer.DailyPrayerControllers>.Instance;
            int val_29 = val_2.<NowCurLevelUseRefreshCount>k__BackingField;
            val_29 = val_29 + 1;
            val_2.<NowCurLevelUseRefreshCount>k__BackingField = val_29;
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_28 = "eff_shuffle";
            }
            else
            {
                    val_28 = "refresh";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_28, volumeScale:  1f, loop:  false, delay:  0f);
            val_29 = null;
            val_29 = null;
            Platform.Analytics.EzAnalytics.SendPropUse(propName:  new PropNameEnum() {<Value>k__BackingField = PropUse.PropNameEnum.PropNameRefresh});
            Utils.Extensions.ListExtension.Shuffle<UnityEngine.Vector3>(list:  this.blockLocalPositions, count:  0);
            Message.Messager.Dispatch<View.CommonItem.LetterBlock>(cmd:  30, t:  0);
            var val_30 = 0;
            val_30 = 4;
            do
            {
                var val_4 = val_30 - 4;
                if(val_4 >= this.letterBlocks)
            {
                    return;
            }
            
                typeof(DailyPrayerLetterContent.<>c__DisplayClass43_0).__il2cppRuntimeField_18 = this;
                if(1152921504810520576 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                int val_6 = DG.Tweening.DOTween.Kill(targetOrId:  null, complete:  false);
                DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
                typeof(DailyPrayerLetterContent.<>c__DisplayClass43_0).__il2cppRuntimeField_10 = val_4;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                UnityEngine.Vector3 val_9 = this.centerTransform.localPosition;
                if(this.centerTransform <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(this.centerTransform <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(null <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  1080f);
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished + 32 + 100, y = DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished + 32 + 100 + 4, z = DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished + 32 + 108});
                if(1152921512633479360 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished + 32 + 32.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.5f, snapping:  false)), ease:  5), t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  0.transform, endValue:  new UnityEngine.Vector3() {x = UnityEngine.Transform.__il2cppRuntimeField_byval_arg, y = typeof(UnityEngine.Transform).__il2cppRuntimeField_24, z = typeof(UnityEngine.Transform).__il2cppRuntimeField_28}, duration:  0.5f, snapping:  false)), ease:  6), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  UnityEngine.Transform.__il2cppRuntimeField_byval_arg.transform, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  DG.Tweening.TweenExtensions.Duration(t:  val_7, includeLoops:  true), mode:  1), ease:  7)), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerLetterContent::<Shuffle>b__43_0())), action:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void DailyPrayerLetterContent.<>c__DisplayClass43_0::<Shuffle>b__1())), id:  "stack");
                val_30 = val_30 + 1;
                val_30 = val_30 + 12;
            }
            while(this.letterBlocks != null);
            
            throw new NullReferenceException();
        }
        private void UpdatePosition()
        {
            var val_1;
            bool val_1 = true;
            val_1 = 0;
            var val_2 = 0;
            do
            {
                if(val_2 >= val_1)
            {
                    return;
            }
            
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                if(W9 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + val_1;
                (true + 0) + 32.localPosition = new UnityEngine.Vector3() {x = ((true + 0) + val_1) + 32, y = ((true + 0) + val_1) + 32 + 4, z = ((true + 0) + val_1) + 40};
                val_2 = val_2 + 1;
                val_1 = val_1 + 12;
            }
            while(this.letterBlocks != null);
            
            throw new NullReferenceException();
        }
        private void StopGuide()
        {
            this.handTransform.gameObject.SetActive(value:  false);
            this.guideLineRenderer.positionCount = 0;
            if(this._guideTweener == null)
            {
                    return;
            }
            
            if(W8 == 0)
            {
                    return;
            }
            
            if((DG.Tweening.TweenExtensions.IsPlaying(t:  this._guideTweener)) == false)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this._guideTweener, complete:  false);
        }
        private bool IsGuiding()
        {
            if(this._guideTweener == null)
            {
                    return false;
            }
            
            if(W8 == 0)
            {
                    return false;
            }
            
            return DG.Tweening.TweenExtensions.IsPlaying(t:  this._guideTweener);
        }
        private void ShowGuide(float delay)
        {
            var val_9;
            System.Collections.Generic.List<System.String> val_10;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 4)
            {
                    return;
            }
            
            if((this._guideTweener != null) && (val_1._bibleGameState != 0))
            {
                    if((DG.Tweening.TweenExtensions.IsPlaying(t:  this._guideTweener)) == true)
            {
                    return;
            }
            
            }
            
            if(this._guideDialog != 0)
            {
                goto label_8;
            }
            
            View.Dialog.Common.Dialog val_4 = Logic.Game.GameManager.gameDialog.Open(name:  "DailyGuideDialog", type:  2);
            val_9 = 0;
            this._guideDialog = ;
            if( == 0)
            {
                goto label_15;
            }
            
            val_10 = this._guideDialog.<words>k__BackingField;
            this._guideWords = val_10;
            if(val_10 != null)
            {
                goto label_17;
            }
            
            return;
            label_15:
            val_10 = this._guideWords;
            if(val_10 == null)
            {
                    return;
            }
            
            label_17:
            if(val_10 == null)
            {
                    return;
            }
            
            label_8:
            this._showGuideCoroutine = this.StartCoroutine(routine:  this.StartShowGuide(delay:  delay, duration:  1f, onComplet:  0));
        }
        private System.Collections.IEnumerator StartShowGuide(float delay, float duration = 1, System.Action onComplet)
        {
            typeof(DailyPrayerLetterContent.<StartShowGuide>d__48).__il2cppRuntimeField_10 = 0;
            typeof(DailyPrayerLetterContent.<StartShowGuide>d__48).__il2cppRuntimeField_30 = duration;
            typeof(DailyPrayerLetterContent.<StartShowGuide>d__48).__il2cppRuntimeField_34 = delay;
            typeof(DailyPrayerLetterContent.<StartShowGuide>d__48).__il2cppRuntimeField_20 = this;
            typeof(DailyPrayerLetterContent.<StartShowGuide>d__48).__il2cppRuntimeField_28 = onComplet;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void ClearGuide()
        {
            if(this._showGuideCoroutine != null)
            {
                    this.StopCoroutine(routine:  this._showGuideCoroutine);
            }
            
            this.handTransform.gameObject.SetActive(value:  false);
            this.guideLineRenderer.positionCount = 0;
            if((this._guideTweener != null) && (true != 0))
            {
                    if((DG.Tweening.TweenExtensions.IsPlaying(t:  this._guideTweener)) != false)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this._guideTweener, complete:  false);
            }
            
            }
            
            this._guideTweener = 0;
            if(this._guideDialog == 0)
            {
                    return;
            }
            
            this._guideDialog = 0;
        }
        private void InitGuidePath()
        {
            var val_3;
            var val_4;
            var val_15;
            var val_17;
            UnityEngine.Vector3[] val_18;
            System.Collections.Generic.List<UnityEngine.Vector3[]> val_19;
            var val_20;
            var val_21;
            val_15 = this;
            if(this._guidePaths != null)
            {
                    this._guidePaths.Clear();
            }
            else
            {
                    this._guidePaths = new System.Collections.Generic.List<UnityEngine.Vector3[]>();
            }
            
            List.Enumerator<T> val_2 = this._guideWords.GetEnumerator();
            val_17 = 1152921512631177136;
            label_29:
            val_18 = public System.Boolean List.Enumerator<System.String>::MoveNext();
            if(val_4.MoveNext() == false)
            {
                goto label_4;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Vector3[] val_6 = new UnityEngine.Vector3[0];
            if((val_3 + 16) < 1)
            {
                goto label_18;
            }
            
            var val_17 = 0;
            label_17:
            val_20 = val_3.Chars[0];
            if(this.letterBlocks == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_8 = this.letterBlocks.GetEnumerator();
            label_11:
            if(val_4.MoveNext() == false)
            {
                goto label_8;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_3 + 32) == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_20 & 65535) != (val_3 + 32 + 24))
            {
                goto label_11;
            }
            
            var val_11 = 0 + 1;
            val_19 = val_3;
            val_18 = 0;
            UnityEngine.Vector3 val_12 = val_19.position;
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            mem[1152921512829445216] = val_12.x;
            mem[1152921512829445220] = val_12.y;
            mem[1152921512829445224] = val_12.z;
            val_21 = 0 + 1;
            val_20 = 0;
            mem2[0] = 171;
            val_15 = val_15;
            val_17 = 1152921512631177136;
            goto label_14;
            label_8:
            val_21 = 0 + 1;
            val_20 = 0;
            mem2[0] = 171;
            label_14:
            val_4.Dispose();
            if(val_20 != 0)
            {
                goto label_15;
            }
            
            if(val_21 != 1)
            {
                    var val_13 = ((-367388784 + ((0 + 1)) << 2) == 171) ? 1 : 0;
                val_13 = ((val_21 >= 0) ? 1 : 0) & val_13;
                val_21 = val_21 - val_13;
            }
            
            val_17 = val_17 + 1;
            if(val_17 < (val_3 + 16))
            {
                goto label_17;
            }
            
            label_18:
            val_18 = Common.EzPath.GetSmoothPoints(points:  val_6, smooth:  10);
            val_19 = this._guidePaths;
            if(val_19 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_19.Add(item:  val_18);
            goto label_29;
            label_4:
            var val_16 = 0 + 1;
            mem2[0] = 236;
            val_4.Dispose();
            return;
            label_15:
            val_19 = val_20;
            val_18 = 0;
            throw val_19;
        }
        private void DailyCheckDoveVacancy(char doveLetter)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            View.CommonItem.LetterBlock val_11;
            val_7 = this;
            typeof(DailyPrayerLetterContent.<>c__DisplayClass51_0).__il2cppRuntimeField_10 = doveLetter;
            if((doveLetter & '￿') == 0)
            {
                    View.CommonItem.LetterBlock val_3 = this.letterBlocks.Find(match:  new System.Predicate<View.CommonItem.LetterBlock>(object:  new System.Object(), method:  System.Boolean DailyPrayerLetterContent.<>c__DisplayClass51_0::<DailyCheckDoveVacancy>b__0(View.CommonItem.LetterBlock x)));
                val_7 = val_3;
                UnityEngine.Vector2 val_5 = val_3.transform.anchoredPosition;
                var val_6 = (val_5.x < 0) ? 1 : 0;
                val_9 = 27;
                val_10 = public static System.Void Message.Messager::Dispatch<View.CommonItem.LetterBlock, System.Boolean>(Message.MessageCmd cmd, View.CommonItem.LetterBlock t, System.Boolean u);
                val_11 = val_7;
            }
            else
            {
                    val_9 = 27;
                val_11 = 0;
                val_8 = 0;
                val_10 = public static System.Void Message.Messager::Dispatch<View.CommonItem.LetterBlock, System.Boolean>(Message.MessageCmd cmd, View.CommonItem.LetterBlock t, System.Boolean u);
            }
            
            Message.Messager.Dispatch<View.CommonItem.LetterBlock, System.Boolean>(cmd:  27, t:  val_11, u:  false);
        }
        private void OnEnable()
        {
            Message.Messager.Add<System.Char>(cmd:  26, action:  new System.Action<System.Char>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerLetterContent::DailyCheckDoveVacancy(char doveLetter)));
            Message.Messager.Add(cmd:  58, action:  new System.Action(object:  this, method:  public System.Void View.DailyPrayer.DailyPrayerLetterContent::Shuffle()));
            Message.Messager.Add<System.Boolean>(cmd:  63, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerLetterContent::PlayHideBlockAni(bool isGameComplete)));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<System.Char>(cmd:  26, action:  new System.Action<System.Char>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerLetterContent::DailyCheckDoveVacancy(char doveLetter)));
            Message.Messager.Remove(cmd:  58, action:  new System.Action(object:  this, method:  public System.Void View.DailyPrayer.DailyPrayerLetterContent::Shuffle()));
            Message.Messager.Remove<System.Boolean>(cmd:  63, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.DailyPrayer.DailyPrayerLetterContent::PlayHideBlockAni(bool isGameComplete)));
            this.ClearGuide();
        }
        public DailyPrayerLetterContent()
        {
            this.maxSize = 200f;
            this.canDraw = true;
            this.sizeProportionTest = 0.285f;
            this.sizeRatio = 0.045f;
            this.letterBlocks = new System.Collections.Generic.List<View.CommonItem.LetterBlock>();
            this.selectedBlocks = new System.Collections.Generic.List<View.CommonItem.LetterBlock>();
            this.blockLocalPositions = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.linePositions = new System.Collections.Generic.List<UnityEngine.Vector3>();
        }
        private void <InitLetterContent>b__32_0()
        {
            this.ShowGuide(delay:  0.1f);
        }
        private void <Shuffle>b__43_0()
        {
            this.canDraw = false;
        }
    
    }

}
