using UnityEngine;

namespace Logic.Game
{
    public class GameScene : MonoBehaviour
    {
        // Fields
        private bool loadingScene;
        private UnityEngine.Transform transitionTransform;
        private UnityEngine.Transform leftPosition;
        private UnityEngine.Transform rightPosition;
        private UnityEngine.Transform[] lefts;
        private UnityEngine.Transform[] rights;
        private UnityEngine.Canvas transitionCanvas;
        private UnityEngine.UI.GraphicRaycaster transitionRaycaster;
        private UnityEngine.UI.Image[] leftImages;
        private UnityEngine.UI.Image[] rightImages;
        private System.Action _loadCallBack;
        
        // Properties
        public string CurrentSceneName { get; }
        
        // Methods
        public string get_CurrentSceneName()
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            return (string)val_1.m_Handle.name;
        }
        public void LoadScene(string name, bool useLoadingScreen = True, System.Action callBack)
        {
            this._loadCallBack = callBack;
            if(this.loadingScene != false)
            {
                    return;
            }
            
            if(useLoadingScreen != false)
            {
                    UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.LoadSceneAsync(name:  name, callBack:  callBack));
                return;
            }
            
            this.ResetCloudPosition();
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  name);
            if(callBack == null)
            {
                    return;
            }
            
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void Logic.Game.GameScene::LoadSceneCallBack(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode sceneType)));
        }
        private void LoadSceneCallBack(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode sceneType)
        {
            if(this._loadCallBack == null)
            {
                    return;
            }
            
            this._loadCallBack.Invoke();
        }
        private void ResetCloudPosition()
        {
            this.SetVisible(isVisible:  false);
            if(this.lefts.Length >= 1)
            {
                    var val_4 = 0;
                do
            {
                UnityEngine.Vector3 val_1 = this.leftPosition.position;
                this.lefts[val_4].position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
                val_4 = val_4 + 1;
            }
            while(val_4 < this.lefts.Length);
            
            }
            
            if(this.rights.Length < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                UnityEngine.Vector3 val_2 = this.rightPosition.position;
                this.rights[val_6].position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
                val_6 = val_6 + 1;
            }
            while(val_6 < this.rights.Length);
        
        }
        private void DoClose()
        {
            Logic.Game.GameManager.gameSound.Play(clipName:  "eff_cloud", volumeScale:  1f, loop:  false, delay:  0f);
            this.DoCloseCloud();
        }
        private void DoCloseCloud()
        {
            UnityEngine.UI.Image val_9;
            float val_10;
            UnityEngine.UI.Image[] val_11;
            val_9 = this;
            this.SetVisible(isVisible:  true);
            if(this.lefts.Length >= 1)
            {
                    val_10 = 0.8f;
                var val_10 = 0;
                do
            {
                UnityEngine.Transform val_9 = this.lefts[val_10];
                UnityEngine.Vector3 val_1 = this.leftPosition.position;
                val_9.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
                DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOMoveX(target:  val_9, endValue:  0f, duration:  UnityEngine.Random.Range(min:  0.5f, max:  val_10), snapping:  false);
                val_10 = val_10 + 1;
            }
            while(val_10 < this.lefts.Length);
            
            }
            
            if(this.rights.Length >= 1)
            {
                    val_10 = 0.8f;
                var val_12 = 0;
                do
            {
                UnityEngine.Transform val_11 = this.rights[val_12];
                UnityEngine.Vector3 val_4 = this.rightPosition.position;
                val_11.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
                DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOMoveX(target:  val_11, endValue:  0f, duration:  UnityEngine.Random.Range(min:  0.5f, max:  val_10), snapping:  false);
                val_12 = val_12 + 1;
            }
            while(val_12 < this.rights.Length);
            
            }
            
            val_11 = this.leftImages;
            if(this.leftImages.Length >= 1)
            {
                    var val_14 = 0;
                do
            {
                UnityEngine.Color val_7 = UnityEngine.Color.white;
                val_11[val_14].color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
                val_14 = val_14 + 1;
            }
            while(val_14 < this.leftImages.Length);
            
            }
            
            if(this.rightImages.Length < 1)
            {
                    return;
            }
            
            do
            {
                val_9 = this.rightImages[0];
                UnityEngine.Color val_8 = UnityEngine.Color.white;
                val_9.color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
                val_11 = 0 + 1;
            }
            while(val_11 < this.rightImages.Length);
        
        }
        private void DoOpen()
        {
            this.DoOpenCloud();
        }
        private void DoOpenCloud()
        {
            float val_7;
            int val_7 = this.leftImages.Length;
            if(val_7 >= 1)
            {
                    val_7 = 0.8f;
                var val_8 = 0;
                val_7 = val_7 & 4294967295;
                do
            {
                DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  1152921506076137392, endValue:  0f, duration:  UnityEngine.Random.Range(min:  0.5f, max:  val_7));
                val_8 = val_8 + 1;
            }
            while(val_8 < (this.leftImages.Length << ));
            
            }
            
            int val_9 = this.rightImages.Length;
            if(val_9 >= 1)
            {
                    val_7 = 0.8f;
                var val_10 = 0;
                val_9 = val_9 & 4294967295;
                do
            {
                DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  1152921506076137392, endValue:  0f, duration:  UnityEngine.Random.Range(min:  0.5f, max:  val_7));
                val_10 = val_10 + 1;
            }
            while(val_10 < (this.rightImages.Length << ));
            
            }
            
            UnityEngine.Coroutine val_6 = Utils.Extensions.MonoBehaviourExtension.WaitSecondsDo(behaviour:  this, call:  new System.Action(object:  this, method:  System.Void Logic.Game.GameScene::<DoOpenCloud>b__19_0()), seconds:  0.8f);
        }
        public void DoAnimation(System.Action closeFinishAction)
        {
            this.DoClose();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.Open(closeFinishAction:  closeFinishAction));
        }
        private System.Collections.IEnumerator Open(System.Action closeFinishAction)
        {
            typeof(GameScene.<Open>d__21).__il2cppRuntimeField_10 = 0;
            typeof(GameScene.<Open>d__21).__il2cppRuntimeField_20 = closeFinishAction;
            typeof(GameScene.<Open>d__21).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private System.Collections.IEnumerator LoadSceneAsync(string name, System.Action callBack)
        {
            typeof(GameScene.<LoadSceneAsync>d__22).__il2cppRuntimeField_10 = 0;
            typeof(GameScene.<LoadSceneAsync>d__22).__il2cppRuntimeField_20 = this;
            typeof(GameScene.<LoadSceneAsync>d__22).__il2cppRuntimeField_28 = name;
            typeof(GameScene.<LoadSceneAsync>d__22).__il2cppRuntimeField_30 = callBack;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void SetVisible(bool isVisible)
        {
            bool val_1 = isVisible;
            this.transitionCanvas.enabled = val_1;
            this.transitionRaycaster.enabled = val_1;
        }
        private void Awake()
        {
            int val_27;
            int val_28;
            UnityEngine.Transform val_2 = this.transform.Find(n:  "TransitionCanvas");
            this.transitionTransform = val_2;
            val_2.gameObject.SetActive(value:  true);
            this.transitionCanvas = this.transitionTransform.GetComponent<UnityEngine.Canvas>();
            this.transitionRaycaster = this.transitionTransform.GetComponent<UnityEngine.UI.GraphicRaycaster>();
            this.SetVisible(isVisible:  false);
            this.leftPosition = this.transitionTransform.transform.Find(n:  "TransitionCanvas/LeftPosition");
            this.rightPosition = this.transform.Find(n:  "TransitionCanvas/RightPosition");
            do
            {
                this.lefts[0] = this.transform.Find(n:  "TransitionCanvas/LeftPanel_"("TransitionCanvas/LeftPanel_") + 0);
                this.rights[0] = this.transform.Find(n:  "TransitionCanvas/Right_"("TransitionCanvas/Right_") + 0);
            }
            while(0 == 0);
            
            object val_27 = 0;
            do
            {
                object[] val_17 = new object[4];
                object val_18 = (val_27 > 2) ? 1 : 0;
                val_17[0] = "TransitionCanvas/LeftPanel_";
                val_27 = val_17.Length;
                val_17[1] = val_18;
                val_27 = val_17.Length;
                val_17[2] = "/Image_";
                val_17[3] = val_27;
                this.leftImages[val_27] = this.transform.Find(n:  +val_17).GetComponent<UnityEngine.UI.Image>();
                object[] val_23 = new object[4];
                val_23[0] = "TransitionCanvas/Right_";
                val_28 = val_23.Length;
                val_23[1] = val_18;
                val_28 = val_23.Length;
                val_23[2] = "/Image_";
                val_23[3] = val_27;
                val_27 = val_27 + 1;
                this.rightImages[val_27] = this.transform.Find(n:  +val_23).GetComponent<UnityEngine.UI.Image>();
            }
            while(val_27 < 5);
        
        }
        public GameScene()
        {
            this.lefts = new UnityEngine.Transform[2];
            this.rights = new UnityEngine.Transform[2];
            this.leftImages = new UnityEngine.UI.Image[6];
            this.rightImages = new UnityEngine.UI.Image[6];
        }
        private void <DoOpenCloud>b__19_0()
        {
            if(this.lefts.Length >= 1)
            {
                    var val_4 = 0;
                do
            {
                UnityEngine.Vector3 val_1 = this.leftPosition.position;
                this.lefts[val_4].position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
                val_4 = val_4 + 1;
            }
            while(val_4 < this.lefts.Length);
            
            }
            
            if(this.rights.Length >= 1)
            {
                    var val_6 = 0;
                do
            {
                UnityEngine.Vector3 val_2 = this.rightPosition.position;
                this.rights[val_6].position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
                val_6 = val_6 + 1;
            }
            while(val_6 < this.rights.Length);
            
            }
            
            this.SetVisible(isVisible:  false);
        }
    
    }

}
