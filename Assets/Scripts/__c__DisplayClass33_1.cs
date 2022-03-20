using UnityEngine;
private sealed class ShopTestDialog.<>c__DisplayClass33_1
{
    // Fields
    public int index;
    public View.Dialog.ShopTest.ShopTestDialog <>4__this;
    
    // Methods
    public ShopTestDialog.<>c__DisplayClass33_1()
    {
    
    }
    internal void <PlayCloseAni>b__4()
    {
        View.Dialog.ShopTest.ShopTestDialog val_1 = this.<>4__this;
        if(val_1 <= this.index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + ((this.index) << 3);
        0.PlayHideAni();
    }

}
