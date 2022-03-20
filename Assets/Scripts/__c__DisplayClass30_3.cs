using UnityEngine;
private sealed class ShopTestDialog.<>c__DisplayClass30_3
{
    // Fields
    public int index;
    public View.Dialog.ShopTest.ShopTestDialog.<>c__DisplayClass30_0 CS$<>8__locals3;
    
    // Methods
    public ShopTestDialog.<>c__DisplayClass30_3()
    {
    
    }
    internal void <CreateProducts>b__3()
    {
        this.CS$<>8__locals3.<>4__this._tempItem = View.Dialog.ShopTest.ShopItem.Create(parent:  this.CS$<>8__locals3.<>4__this.TransformContents, prefab:  this.CS$<>8__locals3.<>4__this.ItemPrefab);
        View.Dialog.ShopTest.ShopTestDialog val_2 = this.CS$<>8__locals3.<>4__this;
        if((this.CS$<>8__locals3) <= this.index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + ((this.index) << 3);
        this.CS$<>8__locals3.<>4__this._tempItem.SetItemInfo(data:  this.CS$<>8__locals3.<>4__this.ItemPrefab);
        this.CS$<>8__locals3.<>4__this._items.Add(item:  this.CS$<>8__locals3.<>4__this._tempItem);
    }

}
