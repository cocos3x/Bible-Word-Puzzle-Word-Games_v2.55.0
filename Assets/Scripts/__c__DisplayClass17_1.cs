using UnityEngine;
private sealed class Fireworks.<>c__DisplayClass17_1
{
    // Fields
    public int x;
    public View.CommonItem.Fireworks.<>c__DisplayClass17_0 CS$<>8__locals1;
    
    // Methods
    public Fireworks.<>c__DisplayClass17_1()
    {
    
    }
    internal void <LetterFly>b__0()
    {
        Fireworks.<>c__DisplayClass17_0 val_4 = this.CS$<>8__locals1;
        if(val_4 <= this.x)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + ((this.x) << 3);
        Message.Messager.Dispatch(cmd:  103);
        Fireworks.<>c__DisplayClass17_0 val_5 = this.CS$<>8__locals1;
        if(val_5 <= this.x)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + ((this.x) << 3);
        UnityEngine.Vector3 val_3 = 0.transform.position;
        View.CommonEffect.FireworkEffect.Create(parent:  this.CS$<>8__locals1.<>4__this.fireworkParent, prefab:  this.CS$<>8__locals1.<>4__this.fireworkEffect).Play(startPosition:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, onComplete:  0);
    }
    internal void <LetterFly>b__1()
    {
        Fireworks.<>c__DisplayClass17_0 val_4 = this.CS$<>8__locals1;
        if(val_4 <= this.x)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + ((this.x) << 3);
        Fireworks.<>c__DisplayClass17_0 val_5 = this.CS$<>8__locals1;
        if(val_5 <= this.x)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + ((this.x) << 3);
        UnityEngine.Vector3 val_3 = 0.transform.position;
        View.CommonEffect.FireworkEffect.Create(parent:  this.CS$<>8__locals1.<>4__this.fireworkParent, prefab:  this.CS$<>8__locals1.<>4__this.fireworkEffect).Play(startPosition:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, onComplete:  0);
    }

}
