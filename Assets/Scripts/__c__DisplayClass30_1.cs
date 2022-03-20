using UnityEngine;
private sealed class ShopTestDialog.<>c__DisplayClass30_1
{
    // Fields
    public int index;
    public View.Dialog.ShopTest.ShopTestDialog.<>c__DisplayClass30_0 CS$<>8__locals1;
    
    // Methods
    public ShopTestDialog.<>c__DisplayClass30_1()
    {
    
    }
    internal void <CreateProducts>b__1()
    {
        this.CS$<>8__locals1.<>4__this._tempLimitTimePackage = View.Dialog.ShopTest.ShopLimitTimePackage.Create(parent:  this.CS$<>8__locals1.<>4__this.TransformContents, prefab:  this.CS$<>8__locals1.<>4__this.LimitTimePackagePrefab);
        View.Dialog.ShopTest.Controller.ShopController val_2 = Common.Singleton<View.Dialog.ShopTest.Controller.ShopController>.Instance;
        ShopTestDialog.<>c__DisplayClass30_0 val_4 = this.CS$<>8__locals1;
        if(val_4 <= this.index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + ((this.index) << 3);
        View.Dialog.ShopTest.ShopTestDialog val_5 = this.CS$<>8__locals1.<>4__this;
        if((this.CS$<>8__locals1) <= this.index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + ((this.index) << 3);
        this.CS$<>8__locals1.<>4__this._tempLimitTimePackage.SetLimitTimePackageInfo(data:  this.CS$<>8__locals1.<>4__this.LimitTimePackagePrefab, seconds:  0.GetOverdueSecondForName(name:  this.CS$<>8__locals1.<>4__this.LimitTimePackagePrefab));
        this.CS$<>8__locals1.<>4__this._limitTimePackages.Add(item:  this.CS$<>8__locals1.<>4__this._tempLimitTimePackage);
    }

}
