using UnityEngine;

namespace Resource.Pool
{
    public class AtlasPool
    {
        // Fields
        private readonly string _atlasName;
        private UnityEngine.U2D.SpriteAtlas _atlas;
        private readonly System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> _sprites;
        private bool _hasAtlas;
        
        // Methods
        public AtlasPool(string atlasName)
        {
            this._sprites = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Sprite>(capacity:  32);
            this._atlasName = atlasName;
        }
        private void Load()
        {
            if(this._hasAtlas == true)
            {
                    return;
            }
            
            this._hasAtlas = true;
            UnityEngine.U2D.SpriteAtlas val_1 = Resource.ResManager.Load<UnityEngine.U2D.SpriteAtlas>(path:  this._atlasName, parent:  0);
            this._atlas = val_1;
            if(val_1 != 0)
            {
                    return;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = this._atlasName;
            Log.D.Error(message:  "[AtlasPool] atlas load fail {0}", args:  val_3);
        }
        private UnityEngine.Sprite LoadSprite(string spriteName)
        {
            this.Load();
            if((this._sprites.TryGetValue(key:  spriteName, value: out  0)) == true)
            {
                    return val_3;
            }
            
            UnityEngine.Sprite val_3 = this._atlas.GetSprite(name:  spriteName);
            if(val_3 == 0)
            {
                    return val_3;
            }
            
            this._sprites.Add(key:  spriteName, value:  val_3);
            return val_3;
        }
        public UnityEngine.Sprite GetSprite(string spriteName)
        {
            return this.LoadSprite(spriteName:  spriteName);
        }
    
    }

}
