using UnityEngine;
private sealed class GameSound.<PlayOneShot>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public bool loop;
    public Logic.Game.GameSound <>4__this;
    public UnityEngine.AudioClip clip;
    public float volumeScale;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameSound.<PlayOneShot>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if(this.loop == false)
        {
            goto label_3;
        }
        
        this.<>4__this.loopAudioSource.clip = this.clip;
        this.<>4__this.loopAudioSource.Play();
        goto label_7;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_7;
        }
        
        this.<>1__state = 0;
        if(this.delay != 0f)
        {
            goto label_8;
        }
        
        val_3 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_3;
        return (bool)val_3;
        label_3:
        this.<>4__this.audioSource.PlayOneShot(clip:  this.clip, volumeScale:  this.volumeScale);
        label_7:
        val_3 = 0;
        return (bool)val_3;
        label_8:
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.delay);
        this.<>1__state = 2;
        return (bool)val_3;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
