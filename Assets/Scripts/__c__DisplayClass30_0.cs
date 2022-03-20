using UnityEngine;
private sealed class ShopTestDialog.<>c__DisplayClass30_0
{
    // Fields
    public View.Dialog.ShopTest.ShopTestDialog <>4__this;
    public System.Collections.Generic.List<Data.Bean.ProductBean> packs;
    public System.Collections.Generic.List<Data.Bean.ProductBean> fixedPacks;
    public System.Collections.Generic.List<Data.Bean.ProductBean> products;
    
    // Methods
    public ShopTestDialog.<>c__DisplayClass30_0()
    {
    
    }
    internal void <CreateProducts>b__0()
    {
        this.<>4__this._moreOffers = View.Dialog.ShopTest.ShopMoreOffers.Create(parent:  this.<>4__this.TransformContents, prefab:  this.<>4__this.MoreOffersPrefab);
        this.<>4__this._moreOffers.ShowItem();
    }

}
