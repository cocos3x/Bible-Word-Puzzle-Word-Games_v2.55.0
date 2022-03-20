using UnityEngine;

namespace Logic.Game
{
    public class GameSound : MonoBehaviour
    {
        // Fields
        private UnityEngine.AudioSource audioSource;
        private UnityEngine.AudioSource loopAudioSource;
        private System.Collections.Generic.Dictionary<string, UnityEngine.AudioClip> sounds;
        private bool _mute;
        private const string SOUND = "Sound/";
        
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
        public void Play(string clipName, float volumeScale = 1, bool loop = False, float delay = 0)
        {
            UnityEngine.Object val_10;
            if(this._mute != false)
            {
                    return;
            }
            
            if((this.sounds.ContainsKey(key:  clipName)) != false)
            {
                    val_10 = this.sounds.Item[clipName];
            }
            else
            {
                    val_10 = Resource.ResManager.Load<UnityEngine.AudioClip>(path:  "Sound/"("Sound/") + clipName, parent:  0);
                if(val_10 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "GameSound [" + clipName + "] missed!"("] missed!"));
                return;
            }
            
                this.sounds.set_Item(key:  clipName, value:  val_10);
            }
            
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.PlayOneShot(clip:  val_10, volumeScale:  volumeScale, loop:  loop, delay:  delay));
        }
        public void Stop(string clipName, bool isLoopClip = False)
        {
            UnityEngine.Object val_11;
            if(isLoopClip == false)
            {
                goto label_1;
            }
            
            val_11 = this.loopAudioSource.clip;
            if(val_11 == 0)
            {
                    return;
            }
            
            if((this.loopAudioSource.clip.name.Equals(value:  clipName)) == false)
            {
                    return;
            }
            
            if(this.loopAudioSource != null)
            {
                goto label_10;
            }
            
            label_1:
            val_11 = this.audioSource.clip;
            if(val_11 == 0)
            {
                    return;
            }
            
            if((this.audioSource.clip.name.Equals(value:  clipName)) == false)
            {
                    return;
            }
            
            label_10:
            this.audioSource.Stop();
        }
        private System.Collections.IEnumerator PlayOneShot(UnityEngine.AudioClip clip, float volumeScale, bool loop, float delay)
        {
            typeof(GameSound.<PlayOneShot>d__10).__il2cppRuntimeField_10 = 0;
            typeof(GameSound.<PlayOneShot>d__10).__il2cppRuntimeField_28 = this;
            typeof(GameSound.<PlayOneShot>d__10).__il2cppRuntimeField_30 = clip;
            typeof(GameSound.<PlayOneShot>d__10).__il2cppRuntimeField_38 = volumeScale;
            typeof(GameSound.<PlayOneShot>d__10).__il2cppRuntimeField_24 = loop;
            typeof(GameSound.<PlayOneShot>d__10).__il2cppRuntimeField_20 = delay;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void PlayButton()
        {
            this.Play(clipName:  "eff_btn_click", volumeScale:  1f, loop:  false, delay:  0f);
        }
        public void PlayConnect(int index)
        {
            this.Play(clipName:  System.String.Format(format:  "eff_connect_{0}", arg0:  UnityEngine.Mathf.Min(a:  7, b:  index)), volumeScale:  1f, loop:  false, delay:  0f);
        }
        public void PlayCombo(int index)
        {
            this.Play(clipName:  System.String.Format(format:  "eff_combo_{0}", arg0:  UnityEngine.Mathf.Min(a:  index, b:  4)), volumeScale:  1f, loop:  false, delay:  0f);
        }
        private void Awake()
        {
            this.audioSource = this.transform.Find(n:  "").GetComponent<UnityEngine.AudioSource>();
            this.loopAudioSource = this.transform.Find(n:  "AudioLoop").GetComponent<UnityEngine.AudioSource>();
        }
        public GameSound()
        {
            this.sounds = new System.Collections.Generic.Dictionary<System.String, UnityEngine.AudioClip>();
        }
    
    }

}
