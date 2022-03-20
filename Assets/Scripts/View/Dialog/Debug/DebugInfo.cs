using UnityEngine;

namespace View.Dialog.Debug
{
    public class DebugInfo : MonoBehaviour
    {
        // Fields
        private static View.Dialog.Debug.DebugInfo _instance;
        public bool isShowFPS;
        private float _lastUpdateShowTime;
        private float _updateShowDeltaTime;
        private int _frameUpdate;
        private int _FPS;
        private UnityEngine.GUIStyle _style;
        
        // Properties
        public static View.Dialog.Debug.DebugInfo instance { get; }
        
        // Methods
        public static View.Dialog.Debug.DebugInfo get_instance()
        {
            View.Dialog.Debug.DebugInfo val_5 = View.Dialog.Debug.DebugInfo._instance;
            if(val_5 != 0)
            {
                    return (View.Dialog.Debug.DebugInfo)View.Dialog.Debug.DebugInfo._instance;
            }
            
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "DebugInfoSingleton");
            View.Dialog.Debug.DebugInfo._instance = AddComponent<View.Dialog.Debug.DebugInfo>();
            val_5 = View.Dialog.Debug.DebugInfo._instance.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_5);
            return (View.Dialog.Debug.DebugInfo)View.Dialog.Debug.DebugInfo._instance;
        }
        private void Start()
        {
            this._lastUpdateShowTime = UnityEngine.Time.realtimeSinceStartup;
            this._style.fontSize = 40;
            UnityEngine.Color val_3 = UnityEngine.Color.red;
            this._style.normal.textColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        }
        private void Update()
        {
            int val_4 = this._frameUpdate;
            val_4 = val_4 + 1;
            this._frameUpdate = val_4;
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            val_1 = val_1 - this._lastUpdateShowTime;
            if(val_1 < this._updateShowDeltaTime)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.realtimeSinceStartup;
            val_2 = val_2 - this._lastUpdateShowTime;
            val_2 = (float)this._frameUpdate / val_2;
            this._frameUpdate = 0;
            this._FPS = (int)val_2;
            this._lastUpdateShowTime = UnityEngine.Time.realtimeSinceStartup;
        }
        private void OnGUI()
        {
            if(this.isShowFPS == false)
            {
                    return;
            }
            
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  10f, y:  10f, width:  300f, height:  100f);
            this = this._style;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height}, text:  "FPS: "("FPS: ") + this._FPS, style:  this);
        }
        public DebugInfo()
        {
            this._updateShowDeltaTime = 0.5f;
            this._style = new UnityEngine.GUIStyle();
        }
    
    }

}
