using UnityEngine;

namespace Logic.Game
{
    public class GameMusic : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, UnityEngine.AudioClip> musics;
        private bool _mute;
        private const string SOUND = "Sound/";
        private bool _isPause;
        private string _curPlayName;
        private float _playGameTime;
        private UnityEngine.AudioSource audioSource;
        private int oldIndex;
        
        // Properties
        public bool mute { get; set; }
        
        // Methods
        public bool get_mute()
        {
            return (bool)this._mute;
        }
        public void set_mute(bool value)
        {
            bool val_1 = value;
            this._mute = val_1;
            if(this.audioSource != null)
            {
                    this.audioSource.mute = val_1;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void Awake()
        {
            this.audioSource = this.transform.Find(n:  "AudioLoop").GetComponent<UnityEngine.AudioSource>();
        }
        public void Pause(bool pause)
        {
            this._isPause = pause;
            if(this.audioSource != null)
            {
                    if(pause != false)
            {
                    this.audioSource.Pause();
                return;
            }
            
                this.audioSource.UnPause();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void Play(string clipName, float volumeScale = 1)
        {
            UnityEngine.Object val_13;
            if((System.String.op_Equality(a:  this._curPlayName, b:  clipName)) != false)
            {
                    if(this._isPause == false)
            {
                    return;
            }
            
                this._isPause = false;
                this.audioSource.UnPause();
                return;
            }
            
            if((this.musics.ContainsKey(key:  clipName)) != false)
            {
                    val_13 = this.musics.Item[clipName];
            }
            else
            {
                    val_13 = Resource.ResManager.Load<UnityEngine.AudioClip>(path:  "Sound/"("Sound/") + clipName, parent:  0);
                if(val_13 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "GameMusic [" + clipName + "] missed!"("] missed!"));
                return;
            }
            
                this.musics.set_Item(key:  clipName, value:  val_13);
            }
            
            if((System.String.op_Equality(a:  this._curPlayName, b:  "music_game_bgm")) != false)
            {
                    this._playGameTime = this.audioSource.time;
            }
            
            this._curPlayName = clipName;
            bool val_10 = System.String.op_Equality(a:  clipName, b:  "music_game_bgm");
            UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.PlayNewMusic(clip:  val_13, volumeScale:  volumeScale, time:  this._playGameTime));
        }
        public void PlayHome()
        {
            this.oldIndex = 0;
            this.Play(clipName:  "music_game_bgm", volumeScale:  1f);
        }
        public void PlayGame(bool useNewMusic = True)
        {
            this.Play(clipName:  "music_game_bgm", volumeScale:  1f);
        }
        public void PlayButterFly()
        {
            this.oldIndex = 0;
            this.Play(clipName:  "music_butterfly", volumeScale:  0.5f);
        }
        public void PlayResult()
        {
            this.Play(clipName:  "music_result_bgm", volumeScale:  1f);
        }
        public void Stop()
        {
            if(this.audioSource != null)
            {
                    this.audioSource.Stop();
                return;
            }
            
            throw new NullReferenceException();
        }
        private System.Collections.IEnumerator PlayNewMusic(UnityEngine.AudioClip clip, float volumeScale, float time)
        {
            typeof(GameMusic.<PlayNewMusic>d__19).__il2cppRuntimeField_10 = 0;
            typeof(GameMusic.<PlayNewMusic>d__19).__il2cppRuntimeField_20 = this;
            typeof(GameMusic.<PlayNewMusic>d__19).__il2cppRuntimeField_28 = clip;
            typeof(GameMusic.<PlayNewMusic>d__19).__il2cppRuntimeField_30 = time;
            typeof(GameMusic.<PlayNewMusic>d__19).__il2cppRuntimeField_34 = volumeScale;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public GameMusic()
        {
            this.musics = new System.Collections.Generic.Dictionary<System.String, UnityEngine.AudioClip>();
            this.oldIndex = 0;
        }
    
    }

}
