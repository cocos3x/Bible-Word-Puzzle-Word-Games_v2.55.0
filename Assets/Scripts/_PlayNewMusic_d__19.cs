using UnityEngine;
private sealed class GameMusic.<PlayNewMusic>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Logic.Game.GameMusic <>4__this;
    public UnityEngine.AudioClip clip;
    public float time;
    public float volumeScale;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameMusic.<PlayNewMusic>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) == 2)
        {
            goto label_0;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_3 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_3;
        return (bool)val_3;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.audioSource.Stop();
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_3 = 1;
        return (bool)val_3;
        label_0:
        this.<>1__state = 0;
        this.<>4__this.audioSource.clip = this.clip;
        float val_2 = this.<>4__this.audioSource.clip.length;
        this.<>4__this.audioSource.time = this.time;
        this.<>4__this.audioSource.Play();
        this.<>4__this.audioSource.volume = this.volumeScale;
        label_2:
        val_3 = 0;
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
