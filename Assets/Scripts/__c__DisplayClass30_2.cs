using UnityEngine;
private sealed class ShopTestDialog.<>c__DisplayClass30_2
{
    // Fields
    public int index;
    public View.Dialog.ShopTest.ShopTestDialog.<>c__DisplayClass30_0 CS$<>8__locals2;
    
    // Methods
    public ShopTestDialog.<>c__DisplayClass30_2()
    {
    
    }
    internal void <CreateProducts>b__2()
    {
        this.CS$<>8__locals2.<>4__this._tempFixedPackage = View.Dialog.ShopTest.ShopFixedPackage.Create(parent:  this.CS$<>8__locals2.<>4__this.TransformContents, prefab:  this.CS$<>8__locals2.<>4__this.FixedPackagePrefab);
        View.Dialog.ShopTest.ShopTestDialog val_2 = this.CS$<>8__locals2.<>4__this;
        if((this.CS$<>8__locals2) <= this.index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + ((this.index) << 3);
        this.CS$<>8__locals2.<>4__this._tempFixedPackage.SetFixedPackageInfo(data:  this.CS$<>8__locals2.<>4__this.FixedPackagePrefab);
        this.CS$<>8__locals2.<>4__this._fixedPackages.Add(item:  this.CS$<>8__locals2.<>4__this._tempFixedPackage);
    }

}
