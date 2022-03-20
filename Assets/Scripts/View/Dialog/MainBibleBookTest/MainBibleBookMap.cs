using UnityEngine;

namespace View.Dialog.MainBibleBookTest
{
    public class MainBibleBookMap : MonoBehaviour
    {
        // Fields
        private const float TimeProgress = 0.9;
        private const float TimeDelayAni = 1.2;
        private const float TimeDelayEffect = 1;
        private readonly int[] MapLevelIndex3;
        private readonly int[] MapLevelIndex6;
        private readonly int[] MapLevelIndex9;
        public View.Dialog.MainBibleBookTest.MainBibleProgress[] Progresses;
        public View.Dialog.MainBibleBookTest.MainBibleBookMapLevel[] MapLevels;
        private int[] _currentMapLevelIndex;
        private System.Collections.Generic.List<View.Dialog.MainBibleBookTest.MainBibleBookMapLevel> _currentMapLevels;
        private System.Collections.Generic.List<System.Collections.Generic.List<View.Dialog.MainBibleBookTest.MainBibleProgress>> _currentProgressList;
        private int _bibleSectionIndex;
        private Data.Bean.BibleSection _bibleSection;
        private bool _isHaveAllCollectAni;
        
        // Methods
        public void UpdateBibleBookMap(int bibleSectionIndex)
        {
            this._bibleSectionIndex = bibleSectionIndex;
            Data.Bean.BibleSection val_1 = Logic.Game.GameManager.gameBible.GetBibleSection(sectionIndex:  bibleSectionIndex);
            this._bibleSection = val_1;
            this._isHaveAllCollectAni = false;
            this.GetCurrentMapLevels(nowBibleCount:  UnityEngine.Mathf.Clamp(value:  val_1.maxCount, min:  1, max:  9));
        }
        public void PlayCollectBibleAni()
        {
            System.Collections.Generic.List<View.Dialog.MainBibleBookTest.MainBibleBookMapLevel> val_17;
            System.Collections.Generic.List<System.Collections.Generic.List<View.Dialog.MainBibleBookTest.MainBibleProgress>> val_18;
            var val_19;
            object val_1 = null;
            val_17 = val_1;
            val_1 = new System.Object();
            typeof(MainBibleBookMap.<>c__DisplayClass15_0).__il2cppRuntimeField_10 = this;
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            Data.Bean.BibleSection val_17 = this._bibleSection;
            val_17 = val_17.collectCount - 1;
            typeof(MainBibleBookMap.<>c__DisplayClass15_0).__il2cppRuntimeField_18 = val_17;
            this._isHaveAllCollectAni = false;
            val_18 = this._currentProgressList;
            if(val_17 <= (((val_4 - 1) - 1)))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = val_17 + ((((val_4 - 1) - 1)) << 3);
            var val_18 = ((val_4 - 1) + (((val_4 - 1) - 1)) << 3) + 32 + 24;
            val_18 = this._currentProgressList;
            this._isHaveAllCollectAni = ((((val_4 - 1) + 1)) == this._bibleSection.maxCount) ? 1 : 0;
            var val_20 = 0;
            val_18 = 0.9f / (float)val_18;
            label_22:
            if(this._currentMapLevels <= (((val_4 - 1) - 1)))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(val_20 >= (((val_4 - 1) + (((val_4 - 1) - 1)) << 3) + 32 + 24))
            {
                goto label_16;
            }
            
            if(this._currentMapLevels <= (((val_4 - 1) - 1)))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((((val_4 - 1) + (((val_4 - 1) - 1)) << 3) + 32 + 24) <= val_20)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = ((val_4 - 1) + (((val_4 - 1) - 1)) << 3) + 32 + 16;
            val_19 = val_19 + 0;
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  (((val_4 - 1) + (((val_4 - 1) - 1)) << 3) + 32 + 16 + 0) + 32);
            val_20 = val_20 + 1;
            if(this._currentProgressList != null)
            {
                goto label_22;
            }
            
            val_17 = this._currentMapLevels;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_17 = val_17 + (((val_4 - 1)) << 3);
            ((val_4 - 1) + ((val_4 - 1)) << 3) + 32.PlayCompleteAni(isAll:  false);
            goto label_27;
            label_16:
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_17, method:  System.Void MainBibleBookMap.<>c__DisplayClass15_0::<PlayCollectBibleAni>b__1()));
            label_27:
            if(this._isHaveAllCollectAni != true)
            {
                    DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  1.2f);
                val_18 = 1152921504805302272;
                val_19 = null;
                val_19 = null;
                val_17 = MainBibleBookMap.<>c.<>9__15_0;
                if(val_17 == null)
            {
                    DG.Tweening.TweenCallback val_14 = null;
                val_17 = val_14;
                val_14 = new DG.Tweening.TweenCallback(object:  MainBibleBookMap.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainBibleBookMap.<>c::<PlayCollectBibleAni>b__15_0());
                MainBibleBookMap.<>c.<>9__15_0 = val_17;
            }
            
                DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  val_17);
            }
            
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  val_3, id:  this);
        }
        public void CheckNewGuide()
        {
            Logic.Game.GameDiglog val_8;
            if((Common.Singleton<Data.Guide.GuideDataManager>.Instance.GetHaveMapReelGuide()) == false)
            {
                    return;
            }
            
            if(this._bibleSection.collectCount < 1)
            {
                    return;
            }
            
            if(this._currentMapLevels < 1)
            {
                    return;
            }
            
            val_8 = Logic.Game.GameManager.gameDialog;
            object[] val_4 = new object[3];
            if(Logic.Game.GameManager.gameConfig == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Vector3 val_6 = Logic.Game.GameManager.gameDailyPrayer.transform.position;
            val_4[0] = val_6;
            val_4[1] = this._bibleSectionIndex;
            this = 0;
            val_4[2] = this;
            View.Dialog.Common.Dialog val_7 = val_8.OpenAddParams(name:  "MapReelGuideDialog", type:  2, pars:  val_4);
        }
        private void PlayCollectAllBibleAni()
        {
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            0.SetMalLevelAllState();
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            var val_13 = 0;
            label_22:
            if(val_13 >= this._currentProgressList)
            {
                goto label_7;
            }
            
            typeof(MainBibleBookMap.<>c__DisplayClass17_0).__il2cppRuntimeField_18 = this;
            typeof(MainBibleBookMap.<>c__DisplayClass17_0).__il2cppRuntimeField_10 = val_13;
            var val_11 = 0;
            do
            {
                if(this._currentProgressList <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  ((System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg + 24 + 0) + 32 + 16 + 0) + 32);
                val_11 = val_11 + 1;
            }
            while(this._currentProgressList != null);
            
            System.Collections.Generic.List<View.Dialog.MainBibleBookTest.MainBibleBookMapLevel> val_12 = this._currentMapLevels;
            val_12 = val_12 - 1;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  new System.Object(), method:  System.Void MainBibleBookMap.<>c__DisplayClass17_0::<PlayCollectAllBibleAni>b__1()));
            val_13 = val_13 + 1;
            if(this._currentProgressList != null)
            {
                goto label_22;
            }
            
            throw new NullReferenceException();
            label_7:
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  1f);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMap::<PlayCollectAllBibleAni>b__17_0()));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Sequence>(t:  val_2, id:  this);
        }
        private void GetCurrentMapLevels(int nowBibleCount)
        {
            System.Int32[] val_1;
            this.ResetMap();
            this._currentMapLevels.Clear();
            this._currentProgressList.Clear();
            if(nowBibleCount == 6)
            {
                goto label_3;
            }
            
            if(nowBibleCount != 3)
            {
                goto label_4;
            }
            
            val_1 = this.MapLevelIndex3;
            goto label_6;
            label_3:
            val_1 = this.MapLevelIndex6;
            goto label_6;
            label_4:
            val_1 = this.MapLevelIndex9;
            label_6:
            this._currentMapLevelIndex = val_1;
            this.GroupingMapLevel();
        }
        private void GroupingMapLevel()
        {
            View.Dialog.MainBibleBookTest.MainBibleProgress val_18;
            var val_19;
            var val_21 = 0;
            label_13:
            if(val_21 >= this.MapLevels.Length)
            {
                goto label_2;
            }
            
            if((System.Linq.Enumerable.Contains<System.Int32>(source:  this._currentMapLevelIndex, value:  0)) != false)
            {
                    this.MapLevels[val_21].SetMapLevelInfo(bibleSection:  this._bibleSection, bibleSectionIndex:  this._bibleSectionIndex, bibleIndex:  System.Linq.Enumerable.ToList<System.Int32>(source:  this._currentMapLevelIndex).IndexOf(item:  0), type:  Common.Singleton<Logic.BibleBook.BibleController>.Instance.IsHaveChestForBible(bibleIndex:  (System.Linq.Enumerable.ToList<System.Int32>(source:  this._currentMapLevelIndex).IndexOf(item:  0)) + 1, currentSectionIndex:  this._bibleSectionIndex));
                this._currentMapLevels.Add(item:  this.MapLevels[val_21]);
            }
            
            val_21 = val_21 + 1;
            if(this.MapLevels != null)
            {
                goto label_13;
            }
            
            label_2:
            val_18 = this._bibleSection.collectCount;
            Data.Bible.BibleDataManager val_11 = Common.Singleton<Data.Bible.BibleDataManager>.Instance;
            var val_25 = 1;
            val_19 = 4;
            int val_13 = val_18 - (val_11.<IsExistCollectAni>k__BackingField);
            do
            {
                var val_14 = val_19 - 4;
                if(val_14 >= (this.Progresses.Length << ))
            {
                    return;
            }
            
                if(val_25 < this._currentMapLevelIndex.Length)
            {
                    if(val_14 < this._currentMapLevelIndex[1])
            {
                    var val_15 = (val_25 < val_13) ? 1f : 0f;
                val_18 = this.Progresses[0];
                var val_17 = (val_13 == this._bibleSection.maxCount) ? 1 : 0;
                Add(item:  this.Progresses[0]);
                int val_24 = this._currentMapLevelIndex[1];
                val_24 = val_24 - 1;
                if(val_14 == val_24)
            {
                    this._currentProgressList.Add(item:  new System.Collections.Generic.List<View.Dialog.MainBibleBookTest.MainBibleProgress>());
                val_25 = val_25 + 1;
                System.Collections.Generic.List<View.Dialog.MainBibleBookTest.MainBibleProgress> val_18 = new System.Collections.Generic.List<View.Dialog.MainBibleBookTest.MainBibleProgress>();
            }
            
            }
            
            }
            
                val_19 = val_19 + 1;
            }
            while(this.Progresses != null);
            
            throw new NullReferenceException();
        }
        private void ResetMap()
        {
            var val_2 = 0;
            label_4:
            if(val_2 >= this.Progresses.Length)
            {
                goto label_1;
            }
            
            View.Dialog.MainBibleBookTest.MainBibleProgress val_1 = this.Progresses[val_2];
            val_2 = val_2 + 1;
            if(this.Progresses != null)
            {
                goto label_4;
            }
            
            label_1:
            var val_4 = 0;
            do
            {
                if(val_4 >= this.MapLevels.Length)
            {
                    return;
            }
            
                this.MapLevels[val_4].ResetMapLevel();
                val_4 = val_4 + 1;
            }
            while(this.MapLevels != null);
            
            throw new NullReferenceException();
        }
        private void ShowCompletedEnd()
        {
            if(this._isHaveAllCollectAni == false)
            {
                    return;
            }
            
            this._isHaveAllCollectAni = false;
            this.PlayCollectAllBibleAni();
        }
        private void OnEnable()
        {
            Message.Messager.Add(cmd:  12, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMap::ShowCompletedEnd()));
        }
        private void OnDisable()
        {
            Message.Messager.Remove(cmd:  12, action:  new System.Action(object:  this, method:  System.Void View.Dialog.MainBibleBookTest.MainBibleBookMap::ShowCompletedEnd()));
        }
        public MainBibleBookMap()
        {
            int[] val_1 = new int[3];
            val_1[0] = 4;
            val_1[1] = 8;
            this.MapLevelIndex3 = val_1;
            this.MapLevelIndex6 = new int[6] {0, 2, 3, 5, 6, 8};
            this.MapLevelIndex9 = new int[9] {0, 1, 2, 3, 4, 5, 6, 7, 8};
            this._currentMapLevels = new System.Collections.Generic.List<View.Dialog.MainBibleBookTest.MainBibleBookMapLevel>();
            this._currentProgressList = new System.Collections.Generic.List<System.Collections.Generic.List<View.Dialog.MainBibleBookTest.MainBibleProgress>>();
        }
        private void <PlayCollectAllBibleAni>b__17_0()
        {
            object[] val_1 = new object[1];
            val_1[0] = this._bibleSectionIndex;
            View.Dialog.Common.Dialog val_2 = Logic.Game.GameManager.gameDialog.OpenAddParams(name:  "MainBibleBookCollectDialog", pars:  val_1);
        }
    
    }

}
