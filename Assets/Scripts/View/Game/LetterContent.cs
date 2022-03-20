using UnityEngine;

namespace View.Game
{
    public class LetterContent : MonoBehaviour
    {
        // Fields
        public UnityEngine.LineRenderer lineRenderer;
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
        private bool _hasAd;
        private bool _isAnswerGuide;
        public UnityEngine.LineRenderer guideLineRenderer;
        private View.Dialog.Guide.GuideDialog guideDialog;
        private System.Collections.Generic.List<UnityEngine.Vector3[]> guidePaths;
        private System.Collections.Generic.List<string> guideWords;
        private DG.Tweening.Tweener guideTweener;
        private UnityEngine.Coroutine showGuideCoroutine;
        private bool IsKeyButtonClick;
        private bool IsLevel1_2GuideWaiting;
        private bool IsLevel1_2GuideFirst;
        private bool is1_3Guided;
        private bool isBonusWordGuide;
        
        // Methods
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
        public void InitLetterContent()
        {
            View.CommonItem.LetterBlock val_37;
            float val_38;
            float val_39;
            System.Collections.Generic.IList<T> val_40;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(val_1._levelBean == null)
            {
                    return;
            }
            
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if((System.String.IsNullOrEmpty(value:  val_2._levelBean.l)) == true)
            {
                    return;
            }
            
            val_37 = Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelLettersLength();
            UnityEngine.Rect val_6 = this.rectTransform.rect;
            UnityEngine.Vector2 val_7 = val_6.m_XMin.size;
            float val_8 = UnityEngine.Mathf.Min(a:  val_7.x, b:  val_7.y);
            val_8 = val_8 * this.sizeProportionTest;
            float val_9 = UnityEngine.Mathf.Min(a:  val_8, b:  this.maxSize);
            float val_37 = this.sizeRatio;
            val_37 = val_37 * ((float)val_37 - 3);
            val_37 = val_9 * val_37;
            float val_11 = val_9 - val_37;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.one;
            val_38 = val_12.y;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_38}, d:  UnityEngine.Mathf.Min(a:  val_7.x, b:  val_7.y));
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.one;
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, d:  val_11);
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
            val_39 = val_17.y;
            Logic.Game.GameControllers val_18 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            System.Collections.Generic.List<System.Char> val_19 = null;
            val_40 = val_19;
            val_19 = new System.Collections.Generic.List<System.Char>(collection:  val_18._levelBean.l);
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide()) == true)
            {
                goto label_15;
            }
            
            bool val_22 = Logic.Game.GameManager.gameLevel.IsPassLevelForCurrentLevel(sectionIndex:  5, levelIndex:  1);
            if(val_22 == false)
            {
                goto label_17;
            }
            
            Utils.Extensions.ListExtension.Shuffle<System.Char>(list:  val_40, count:  0);
            if(null != 0)
            {
                goto label_18;
            }
            
            label_17:
            val_40 = val_22.ClockwiseSort();
            label_15:
            label_18:
            float val_40 = 1.570796f;
            var val_39 = 0;
            UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  (val_17.x * 0.5f) * val_40, y:  (val_39 * 0.5f) * val_40);
            UnityEngine.Vector3 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y});
            val_39 = val_30.x;
            val_38 = val_30.z;
            this.blockLocalPositions.Add(item:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_37 = mem[((UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished & 4294967295) + 0) + 32];
            val_37 = ((UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished & 4294967295) + 0) + 32;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            ((UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished & 4294967295) + 0) + 32 + 32.letter = (((UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished & 4294967295) + 0) + 0) + 32;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.one;
            float val_38 = this.maxSize;
            val_38 = val_11 / val_38;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, d:  val_38);
            localScale = new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z};
            localPosition = new UnityEngine.Vector3() {x = val_39, y = val_30.y, z = val_38};
            SetScaleToZero();
            val_39 = val_39 + 1;
            val_40 = (6.283185f / (float)val_37) + val_40;
            this.PlayShowBlocksAni();
            this.inited = true;
            this._isAnswerGuide = false;
        }
        private System.Collections.Generic.List<char> ClockwiseSort()
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            Logic.Game.GameControllers val_3 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            System.Collections.Generic.List<System.String> val_4 = val_3._levelBean.answerList;
            Logic.Game.GameControllers val_5 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            System.Collections.Generic.List<System.String> val_6 = val_5._levelBean.answerList;
            if(W9 <= 1152921512609388751)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_20 = mem[1152921512205213544];
            val_21 = mem[mem[1152921512205213544] + 16];
            val_21 = mem[1152921512205213544] + 16;
            if(val_21 < 1)
            {
                goto label_11;
            }
            
            val_22 = 1152921512630322960;
            var val_25 = 0;
            do
            {
                set_Item(index:  1, value:  val_20.Chars[0]);
                val_21 = mem[mem[1152921512205213544] + 16];
                val_21 = mem[1152921512205213544] + 16;
                val_25 = val_25 + 1;
            }
            while(val_25 < val_21);
            
            if(null != 0)
            {
                goto label_14;
            }
            
            label_11:
            val_23 = 1;
            label_14:
            int val_12 = Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelLettersLength();
            bool[] val_13 = new bool[0];
            if((mem[1152921512205213544] + 16) < 1)
            {
                goto label_19;
            }
            
            label_31:
            var val_26 = 0;
            label_29:
            if(val_26 >= ((Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelLettersLength()) << ))
            {
                goto label_21;
            }
            
            Logic.Game.GameControllers val_16 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(((val_16._levelBean.l.Chars[0] & 65535) == val_20.Chars[0]) && (null == null))
            {
                    mem2[0] = 1;
            }
            
            val_26 = val_26 + 1;
            if((Common.SingletonController<Logic.Game.GameControllers>.Instance) != null)
            {
                goto label_29;
            }
            
            label_21:
            val_22 = 0 + 1;
            if(val_22 < (mem[1152921512205213544] + 16))
            {
                goto label_31;
            }
            
            label_19:
            int val_27 = val_13.Length;
            if(val_27 < 1)
            {
                    return (System.Collections.Generic.List<System.Char>)new System.Collections.Generic.List<System.Char>(collection:  val_1._levelBean.l);
            }
            
            val_27 = val_27 & 4294967295;
            do
            {
                if(null == null)
            {
                    Logic.Game.GameControllers val_21 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
                set_Item(index:  1, value:  val_21._levelBean.l.Chars[0]);
                var val_23 = val_23 - 1;
            }
            
                val_20 = 0 + 1;
            }
            while(val_20 < (val_13.Length << ));
            
            return (System.Collections.Generic.List<System.Char>)new System.Collections.Generic.List<System.Char>(collection:  val_1._levelBean.l);
        }
        private void Update()
        {
            float val_24;
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
            
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_5 = UnityEngine.Input.GetTouch(index:  0);
                if((phase == 0) && (this.isDragging != true))
            {
                    if((Utils.Extensions.EventSystemExtension.IsPointerOverUIObject(self:  UnityEngine.EventSystems.EventSystem.current)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_10 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.TouchPhase val_11 = phase;
                if(val_11 == 0)
            {
                    UnityEngine.Touch val_12 = UnityEngine.Input.GetTouch(index:  val_11);
                UnityEngine.Vector2 val_13 = position;
                val_24 = val_13.x;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24, y = val_13.y});
                this.OnPointerDown(pointPosition:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            }
            
            }
            
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_16 = UnityEngine.Input.GetTouch(index:  0);
                if(phase == 1)
            {
                    UnityEngine.Touch val_18 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.Vector2 val_19 = position;
                val_24 = val_19.x;
                UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24, y = val_19.y});
                this.OnDrag(pointPosition:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            }
            
            }
            
            if(UnityEngine.Input.touchCount < 1)
            {
                    return;
            }
            
            UnityEngine.Touch val_22 = UnityEngine.Input.GetTouch(index:  0);
            if(phase != 3)
            {
                    return;
            }
            
            this.OnPointerUp();
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
            
            if(View.Game.GameController.GetInstance() == 0)
            {
                    return;
            }
            
            View.Game.GameController val_5 = View.Game.GameController.GetInstance();
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
        private void OnPointerUp()
        {
            var val_2;
            var val_3;
            System.Collections.Generic.List<View.CommonItem.LetterBlock> val_23;
            string val_24;
            var val_25;
            var val_26;
            string val_27;
            View.Dialog.Guide.GuideDialog val_28;
            if(this.isDragging == false)
            {
                goto label_3;
            }
            
            this.isDragging = false;
            this.ShowGuide(delay:  0.2f);
            val_23 = this.selectedBlocks;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(15228928 < 1)
            {
                goto label_3;
            }
            
            val_24 = "";
            List.Enumerator<T> val_1 = val_23.GetEnumerator();
            label_7:
            val_25 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
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
            
            string val_6 = val_24 + val_2 + 32 + 24.ToString()(val_2 + 32 + 24.ToString());
            val_2.selected = false;
            goto label_7;
            label_4:
            val_27 = public System.Void List.Enumerator<View.CommonItem.LetterBlock>::Dispose();
            val_3.Dispose();
            val_23 = Logic.Game.GameManager.gameSound;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_27 = "cancel";
            val_23.Play(clipName:  val_27, volumeScale:  1f, loop:  false, delay:  0f);
            val_23 = this.selectedPanel;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_27 = 0;
            val_23.RemoveAll();
            val_23 = this.selectedBlocks;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_7 = val_23.GetEnumerator();
            label_15:
            val_25 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            val_26 = val_2;
            if(val_26 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_26.DoScaleNormal();
            goto label_15;
            label_13:
            val_27 = public System.Void List.Enumerator<View.CommonItem.LetterBlock>::Dispose();
            val_3.Dispose();
            goto label_71;
            label_32:
            val_25 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_30;
            }
            
            val_26 = val_2;
            if(val_26 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_26.Shake();
            goto label_32;
            label_30:
            val_27 = public System.Void List.Enumerator<View.CommonItem.LetterBlock>::Dispose();
            val_3.Dispose();
            val_24 = 3;
            goto label_67;
            label_45:
            if(val_3.MoveNext() == false)
            {
                goto label_43;
            }
            
            val_2.Shake();
            goto label_45;
            label_43:
            val_27 = public System.Void List.Enumerator<View.CommonItem.LetterBlock>::Dispose();
            val_3.Dispose();
            val_28 = 0;
            if((val_28 == 1) || (430 != 430))
            {
                goto label_48;
            }
            
            val_24 = 1;
            goto label_67;
            label_48:
            val_23 = this.selectedBlocks;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_17 = val_23.GetEnumerator();
            label_53:
            val_27 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_51;
            }
            
            val_23 = val_2;
            if(val_23 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_23.DoJelly();
            goto label_53;
            label_51:
            val_27 = public System.Void List.Enumerator<View.CommonItem.LetterBlock>::Dispose();
            val_3.Dispose();
            label_67:
            val_23 = this.selectedPanel;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_27 = ;
            val_23.RemoveAll(type:  val_27);
            label_71:
            val_23 = this.linePositions;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_27 = public System.Void System.Collections.Generic.List<UnityEngine.Vector3>::Clear();
            val_23.Clear();
            val_23 = this.selectedBlocks;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_27 = public System.Void System.Collections.Generic.List<View.CommonItem.LetterBlock>::Clear();
            val_23.Clear();
            label_3:
            val_23 = this.lineRenderer;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_23.positionCount < 1)
            {
                    return;
            }
            
            this.clearLineCor = Utils.Extensions.MonoBehaviourExtension.WaitSecondsDo(behaviour:  this, call:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::ClearLine()), seconds:  0.15f);
        }
        private void DealOperat(UnityEngine.Vector3 pointPosition)
        {
            var val_2;
            var val_3;
            var val_23;
            var val_25;
            UnityEngine.Object val_27;
            System.Collections.Generic.List<View.CommonItem.LetterBlock> val_28;
            System.Collections.Generic.List<View.CommonItem.LetterBlock> val_29;
            System.Collections.Generic.List<View.CommonItem.LetterBlock> val_31;
            UnityEngine.Vector3[] val_32;
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
                goto label_8;
            }
            
            this.KeyButtonClick();
            val_28 = this;
            val_29 = this.selectedBlocks;
            if()
            {
                goto label_10;
            }
            
            val_29 = val_29;
            if(((15228928 + ((UnityEngine.Object.__il2cppRuntimeField_cctor_finished - 2)) << 3) + 32) != val_27)
            {
                goto label_13;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            (UnityEngine.Object.__il2cppRuntimeField_cctor_finished + ((UnityEngine.Object.__il2cppRuntimeField_cctor_finished - 1)) << 3) + 32.selected = false;
            (UnityEngine.Object.__il2cppRuntimeField_cctor_finished + ((UnityEngine.Object.__il2cppRuntimeField_cctor_finished - 1)) << 3) + 32.DoScaleNormal();
            bool val_10 = val_29.Remove(item:  (UnityEngine.Object.__il2cppRuntimeField_cctor_finished + ((UnityEngine.Object.__il2cppRuntimeField_cctor_finished - 1)) << 3) + 32);
            this.selectedPanel.RemoveLast();
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() == false)
            {
                goto label_21;
            }
            
            goto label_24;
            label_8:
            val_28 = this.selectedBlocks;
            goto label_46;
            label_13:
            label_10:
            if((val_29.Contains(item:  val_27)) == true)
            {
                goto label_46;
            }
            
            val_27.selected = true;
            val_27.DoScaleBig();
            val_29.Add(item:  val_27);
            this.selectedPanel.AddLetter(letter:  ' ');
            val_31 = val_29;
            this.isDragging = true;
            this.StopGuide();
            val_31 = this.selectedBlocks;
            label_24:
            Logic.Game.GameManager.gameSound.PlayConnect(index:  0);
            label_46:
            if(val_31 < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_13 = val_29.GetEnumerator();
            val_23 = 1152921512630073744;
            label_41:
            val_25 = public System.Boolean List.Enumerator<View.CommonItem.LetterBlock>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_38;
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
            goto label_41;
            label_38:
            val_3.Dispose();
            UnityEngine.Vector3 val_19 = Utils.Extensions.CameraExtension.ScreenToWorldPointExt(camera:  UnityEngine.Camera.main, pointPosition:  new UnityEngine.Vector3() {x = pointPosition.x, y = pointPosition.y, z = pointPosition.z});
            val_3 = 0;
            UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_19.x, y:  val_19.y, z:  90f);
            this.linePositions.Add(item:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            val_32 = this.linePositions.ToArray();
            if(this.linePositions >= 3)
            {
                    val_32 = Common.EzPath.GetSmoothPoints(points:  val_32, smooth:  10);
            }
            
            this.DrawLine(linePositions:  val_32);
            return;
            label_21:
            Logic.Game.GameManager.gameSound.Play(clipName:  "cancel", volumeScale:  1f, loop:  false, delay:  0f);
            goto label_46;
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
        private void PlayShowBlocksAni()
        {
            System.Collections.Generic.List<View.CommonItem.LetterBlock> val_2;
            float val_3;
            bool val_2 = true;
            val_2 = this.letterBlocks;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            var val_3 = 0;
            do
            {
                if(val_4 != 0)
            {
                    val_3 = ((float)val_2 + val_4) * 0.1f;
            }
            else
            {
                    val_3 = 0f;
            }
            
                if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + 0;
                (true + 0) + 32.DoShowEffect(time:  0.3f, delay:  val_3);
                val_2 = this.letterBlocks;
                val_3 = val_3 + 1;
                val_4 = val_4 - 1;
            }
            while(val_2 > val_3);
        
        }
        private void PlayHideBlockAni(bool isGameComplete)
        {
            var val_3;
            float val_4;
            bool val_3 = true;
            this.ClearGuideDialog();
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
        private void PlayGameShowEnd()
        {
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(val_1._levelBean == null)
            {
                    return;
            }
            
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if((System.String.IsNullOrEmpty(value:  val_2._levelBean.l)) != false)
            {
                    return;
            }
            
            this.ShowGuide(delay:  0.6f);
        }
        private void ClearGuideDialog()
        {
            if(this.guideDialog == 0)
            {
                    return;
            }
            
            this.guideDialog = 0;
        }
        private void BackHomeClear()
        {
            this.ClearGuideDialog();
        }
        private void ChangeLetterGuide(bool isGuide)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(isGuide != false)
            {
                    Utils.Extensions.GameObjectExtension.ChangeCanvasSorting(obj:  val_1, name:  "Dialog", order:  6);
                return;
            }
            
            if((val_1.GetComponent<UnityEngine.Canvas>()) == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject.GetComponent<UnityEngine.Canvas>());
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
        public void ClearLetterContent(bool isGameComplete = True)
        {
            this.inited = false;
            this._isAnswerGuide = false;
            this.IsKeyButtonClick = false;
            this.IsLevel1_2GuideWaiting = false;
            this.canDraw = true;
            this.isDragging = false;
            this.IsLevel1_2GuideFirst = true;
            this.OnRecycleBlock();
            this.selectedBlocks.Clear();
            this.blockLocalPositions.Clear();
            this.linePositions.Clear();
            this.guideLineRenderer.positionCount = 0;
            View.Dialog.GameDictionary.Controller.GameDictionaryController val_1 = Common.SingletonController<View.Dialog.GameDictionary.Controller.GameDictionaryController>.Instance;
            mem2[0] = 0;
        }
        public virtual void OnApplicationPause(bool pause)
        {
            if(pause == false)
            {
                    return;
            }
            
            if(this.selectedBlocks < 1)
            {
                goto label_3;
            }
            
            this.selectedPanel.RemoveAll();
            List.Enumerator<T> val_1 = this.selectedBlocks.GetEnumerator();
            label_8:
            if(0.MoveNext() == false)
            {
                goto label_6;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.DoJelly();
            goto label_8;
            label_6:
            0.Dispose();
            this.linePositions.Clear();
            this.selectedBlocks.Clear();
            label_3:
            if(this.lineRenderer.positionCount < 1)
            {
                    return;
            }
            
            this.clearLineCor = Utils.Extensions.MonoBehaviourExtension.WaitSecondsDo(behaviour:  this, call:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::ClearLine()), seconds:  0.15f);
        }
        private void Shuffle()
        {
            string val_26;
            DG.Tweening.TweenCallback val_27;
            var val_28;
            var val_29;
            Logic.Game.GameControllers val_1 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            if(val_1._levelBean == null)
            {
                    return;
            }
            
            Logic.Game.GameControllers val_2 = Common.SingletonController<Logic.Game.GameControllers>.Instance;
            int val_27 = val_2.<NowCurLevelUseRefreshCount>k__BackingField;
            val_27 = val_27 + 1;
            val_2.<NowCurLevelUseRefreshCount>k__BackingField = val_27;
            if(Platform.AbTest.GameABTestManager.IsGameSoundTest() != false)
            {
                    val_26 = "eff_shuffle";
            }
            else
            {
                    val_26 = "refresh";
            }
            
            Logic.Game.GameManager.gameSound.Play(clipName:  val_26, volumeScale:  1f, loop:  false, delay:  0f);
            val_27 = 1152921504830435328;
            val_28 = null;
            val_28 = null;
            Platform.Analytics.EzAnalytics.SendPropUse(propName:  new PropNameEnum() {<Value>k__BackingField = PropUse.PropNameEnum.PropNameRefresh});
            Platform.Analytics.EzAnalytics.LogEvent(category:  "game", action:  "a1_button_refresh_click", label:  Logic.Game.GameManager.gameLevel.GetCurrentLevelName(), value:  0);
            Utils.Extensions.ListExtension.Shuffle<View.CommonItem.LetterBlock>(list:  this.letterBlocks, count:  0);
            val_29 = 0;
            var val_28 = 4;
            do
            {
                var val_5 = val_28 - 4;
                if(val_5 >= this.letterBlocks)
            {
                    return;
            }
            
                DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                if(15228928 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_8 = this.centerTransform.localPosition;
                if(this.centerTransform <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(this.centerTransform <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(null <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_17 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  1080f);
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished + 32 + 100, y = DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished + 32 + 100 + 4, z = DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished + 32 + 108});
                DG.Tweening.TweenCallback val_25 = null;
                val_27 = val_25;
                val_25 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Game.LetterContent::<Shuffle>b__38_1());
                DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished + 32 + 32.transform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.5f, snapping:  false)), ease:  5), t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  0.transform, endValue:  new UnityEngine.Vector3() {x = UnityEngine.Transform.__il2cppRuntimeField_byval_arg, y = typeof(UnityEngine.Transform).__il2cppRuntimeField_24, z = typeof(UnityEngine.Transform).__il2cppRuntimeField_28}, duration:  0.5f, snapping:  false)), ease:  6), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  UnityEngine.Transform.__il2cppRuntimeField_byval_arg.transform, endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  DG.Tweening.TweenExtensions.Duration(t:  val_6, includeLoops:  true), mode:  1), ease:  7)), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Game.LetterContent::<Shuffle>b__38_0())), action:  val_27);
                val_28 = val_28 + 1;
                val_29 = val_29 + 12;
            }
            while(this.letterBlocks != null);
            
            throw new NullReferenceException();
        }
        private void ShowGuide(float delay)
        {
            var val_19;
            System.Collections.Generic.List<System.String> val_20;
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                    return;
            }
            
            if((this.guideTweener != null) && (val_1._bibleGameState != 0))
            {
                    if((DG.Tweening.TweenExtensions.IsPlaying(t:  this.guideTweener)) == true)
            {
                    return;
            }
            
            }
            
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide()) == false)
            {
                goto label_7;
            }
            
            if(this.guideDialog != 0)
            {
                goto label_10;
            }
            
            View.Dialog.Common.Dialog val_6 = Logic.Game.GameManager.gameDialog.Open(name:  "GuideDialog", type:  2);
            val_19 = 0;
            goto label_14;
            label_7:
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide1_2()) != false)
            {
                    this.ShowLevel1_2Guide();
                return;
            }
            
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide1_3()) != false)
            {
                    this.ShowLevel1_3Guide();
                return;
            }
            
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowBonusWordGuideDialog) == false)
            {
                    return;
            }
            
            if((Common.SingletonController<Logic.Game.GameControllers>.Instance.GetLevelHasBonus()) == false)
            {
                    return;
            }
            
            this.ShowBonusWordGuide();
            return;
            label_14:
            this.guideDialog = ;
            if( == 0)
            {
                goto label_25;
            }
            
            val_20 = this.guideDialog.<words>k__BackingField;
            this.guideWords = val_20;
            if(val_20 != null)
            {
                goto label_27;
            }
            
            return;
            label_25:
            val_20 = this.guideWords;
            if(val_20 == null)
            {
                    return;
            }
            
            label_27:
            if(val_20 == null)
            {
                    return;
            }
            
            label_10:
            this.showGuideCoroutine = this.StartCoroutine(routine:  this.StartShowGuide(delay:  delay, duration:  1f, onComplet:  0));
        }
        private void StopGuide()
        {
            if((this.showGuideCoroutine != null) && (this.IsLevel1_2GuideWaiting != true))
            {
                    this.StopCoroutine(routine:  this.showGuideCoroutine);
            }
            
            this.handTransform.gameObject.SetActive(value:  false);
            this.guideLineRenderer.positionCount = 0;
            if((this.guideTweener != null) && (this.IsLevel1_2GuideWaiting != false))
            {
                    if((DG.Tweening.TweenExtensions.IsPlaying(t:  this.guideTweener)) != false)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.guideTweener, complete:  false);
            }
            
            }
            
            this.guideTweener = 0;
        }
        private bool IsGuiding()
        {
            if(this.guideTweener == null)
            {
                    return false;
            }
            
            if(W8 == 0)
            {
                    return false;
            }
            
            return DG.Tweening.TweenExtensions.IsPlaying(t:  this.guideTweener);
        }
        private void InitGuidePath()
        {
            var val_4;
            var val_5;
            UnityEngine.Vector3[] val_13;
            System.Collections.Generic.List<UnityEngine.Vector3[]> val_14;
            if(this.guidePaths != null)
            {
                    this.guidePaths.Clear();
            }
            else
            {
                    this.guidePaths = new System.Collections.Generic.List<UnityEngine.Vector3[]>();
            }
            
            List.Enumerator<T> val_3 = this.guideWords.GetEnumerator();
            label_24:
            val_13 = public System.Boolean List.Enumerator<System.String>::MoveNext();
            if(val_5.MoveNext() == false)
            {
                goto label_4;
            }
            
            if(val_4 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_13 = mem[val_4 + 16];
            val_13 = val_4 + 16;
            UnityEngine.Vector3[] val_7 = new UnityEngine.Vector3[0];
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            Clear();
            if((val_4 + 16) < 1)
            {
                goto label_7;
            }
            
            var val_15 = 0;
            var val_16 = 0;
            label_22:
            val_14 = val_4;
            if(this.letterBlocks == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_14 = 4;
            label_15:
            int val_9 = val_14 - 4;
            if(val_9 >= (val_4 + 16))
            {
                goto label_9;
            }
            
            if((val_4 + 16) <= val_9)
            {
                    val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((val_4 + 16 + 32) == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_4 + 16 + 32 + 32) == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_14.Chars[0] & 65535) != (val_4 + 16 + 32 + 32 + 24))
            {
                goto label_13;
            }
            
            val_14 = new System.Collections.Generic.List<System.Int32>();
            if((Contains(item:  val_9)) == false)
            {
                goto label_14;
            }
            
            label_13:
            val_14 = val_14 + 1;
            if(this.letterBlocks != null)
            {
                goto label_15;
            }
            
            throw new NullReferenceException();
            label_14:
            if(this.letterBlocks == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_4 + 16 + 32 + 32 + 24) <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = mem[val_4 + 16 + 32 + 32 + 24 + 32];
            val_14 = val_4 + 16 + 32 + 32 + 24 + 32;
            if(val_14 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Vector3 val_12 = val_14.position;
            if(val_7 == 0)
            {
                    throw new NullReferenceException();
            }
            
            mem[1152921512634365440] = val_12.x;
            mem[1152921512634365444] = val_12.y;
            mem[1152921512634365448] = val_12.z;
            Add(item:  val_9);
            val_15 = val_15 + 1;
            label_9:
            val_16 = val_16 + 1;
            if(val_16 < (val_4 + 16))
            {
                goto label_22;
            }
            
            label_7:
            val_13 = Common.EzPath.GetSmoothPoints(points:  val_7, smooth:  10);
            val_14 = this.guidePaths;
            if(val_14 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_14.Add(item:  val_13);
            goto label_24;
            label_4:
            val_5.Dispose();
        }
        private System.Collections.IEnumerator StartShowGuide(float delay, float duration = 1, System.Action onComplet)
        {
            typeof(LetterContent.<StartShowGuide>d__49).__il2cppRuntimeField_10 = 0;
            typeof(LetterContent.<StartShowGuide>d__49).__il2cppRuntimeField_30 = duration;
            typeof(LetterContent.<StartShowGuide>d__49).__il2cppRuntimeField_34 = delay;
            typeof(LetterContent.<StartShowGuide>d__49).__il2cppRuntimeField_20 = this;
            typeof(LetterContent.<StartShowGuide>d__49).__il2cppRuntimeField_28 = onComplet;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void KeyButtonClick()
        {
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.ShouldShowGuide1_2()) != false)
            {
                    this.IsKeyButtonClick = true;
            }
            
            this.StopGuide();
        }
        private void ShowLevel1_2Guide()
        {
            if(this.IsKeyButtonClick != false)
            {
                    return;
            }
            
            this.showGuideCoroutine = this.StartCoroutine(routine:  this.Level1_2GuideWaitStart());
        }
        private System.Collections.IEnumerator Level1_2GuideWaitStart()
        {
            typeof(LetterContent.<Level1_2GuideWaitStart>d__55).__il2cppRuntimeField_10 = 0;
            typeof(LetterContent.<Level1_2GuideWaitStart>d__55).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void ShowLevel1_3Guide()
        {
            if(this.is1_3Guided != false)
            {
                    return;
            }
            
            this.is1_3Guided = true;
            View.Dialog.Common.Dialog val_1 = Logic.Game.GameManager.gameDialog.Open(name:  "HintClickGuideDialog", type:  2);
        }
        private void ShowBonusWordGuide()
        {
            if(this.isBonusWordGuide == true)
            {
                    return;
            }
            
            this.isBonusWordGuide = true;
            if((Logic.Game.GameManager.gameDialog.Open(name:  "BonusWordGuideDialog", type:  2)) != 0)
            {
                    return;
            }
            
            this.isBonusWordGuide = false;
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  57, action:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::KeyButtonClick()));
            Message.Messager.Add(cmd:  58, action:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::Shuffle()));
            Message.Messager.Add(cmd:  58, action:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::KeyButtonClick()));
            Message.Messager.Add<System.Boolean>(cmd:  63, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Game.LetterContent::PlayHideBlockAni(bool isGameComplete)));
            Message.Messager.Add(cmd:  65, action:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::PlayGameShowEnd()));
            Message.Messager.Add(cmd:  34, action:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::BackHomeClear()));
            Message.Messager.Add<System.Boolean>(cmd:  36, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Game.LetterContent::ChangeLetterGuide(bool isGuide)));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  57, action:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::KeyButtonClick()));
            Message.Messager.Remove(cmd:  58, action:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::Shuffle()));
            Message.Messager.Remove(cmd:  58, action:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::KeyButtonClick()));
            Message.Messager.Remove<System.Boolean>(cmd:  63, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Game.LetterContent::PlayHideBlockAni(bool isGameComplete)));
            Message.Messager.Remove(cmd:  65, action:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::PlayGameShowEnd()));
            Message.Messager.Remove(cmd:  34, action:  new System.Action(object:  this, method:  System.Void View.Game.LetterContent::BackHomeClear()));
            Message.Messager.Remove<System.Boolean>(cmd:  36, action:  new System.Action<System.Boolean>(object:  this, method:  System.Void View.Game.LetterContent::ChangeLetterGuide(bool isGuide)));
            this.StopGuide();
            this.ClearGuideDialog();
        }
        public LetterContent()
        {
            this.maxSize = 200f;
            this.canDraw = true;
            this.sizeProportionTest = 0.285f;
            this.sizeRatio = 0.045f;
            this.letterBlocks = new System.Collections.Generic.List<View.CommonItem.LetterBlock>();
            this.selectedBlocks = new System.Collections.Generic.List<View.CommonItem.LetterBlock>();
            this.blockLocalPositions = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.linePositions = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.IsLevel1_2GuideFirst = true;
        }
        private void <Shuffle>b__38_0()
        {
            this.canDraw = false;
        }
        private void <Shuffle>b__38_1()
        {
            this.canDraw = true;
        }
    
    }

}
