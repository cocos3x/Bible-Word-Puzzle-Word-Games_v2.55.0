using UnityEngine;

namespace View.Game
{
    public class ChrysalisContent : MonoBehaviour
    {
        // Fields
        public View.CommonItem.Chrysalis ChrysalisPrefab;
        private UnityEngine.Vector3 _iconPos;
        private View.CommonItem.Chrysalis _tempChrysalis;
        
        // Methods
        private void UpdateChrysalisIconPos(UnityEngine.Vector3 iconPos)
        {
            this._iconPos = iconPos;
            mem[1152921512617794884] = iconPos.y;
            mem[1152921512617794888] = iconPos.z;
        }
        private void CollectChrysalisFly(UnityEngine.Vector3 beginPos, UnityEngine.Vector3 scale)
        {
            View.Controller.MainController val_1 = Common.SingletonController<View.Controller.MainController>.Instance;
            if(val_1._bibleGameState != 3)
            {
                    return;
            }
            
            View.CommonItem.Chrysalis val_3 = View.CommonItem.Chrysalis.Create(parent:  this.transform, prefab:  this.ChrysalisPrefab);
            this._tempChrysalis = val_3;
            val_3.transform.localScale = new UnityEngine.Vector3() {x = scale.x, y = scale.y, z = scale.z};
            this._tempChrysalis.CollectChrysalis(beginPos:  new UnityEngine.Vector3() {x = beginPos.x, y = beginPos.y, z = beginPos.z}, endPos:  new UnityEngine.Vector3() {x = this._iconPos, y = scale.y, z = scale.z});
        }
        private void OnEnable()
        {
            Message.Messager.Add<UnityEngine.Vector3>(cmd:  109, action:  new System.Action<UnityEngine.Vector3>(object:  this, method:  System.Void View.Game.ChrysalisContent::UpdateChrysalisIconPos(UnityEngine.Vector3 iconPos)));
            Message.Messager.Add<UnityEngine.Vector3, UnityEngine.Vector3>(cmd:  107, action:  new System.Action<UnityEngine.Vector3, UnityEngine.Vector3>(object:  this, method:  System.Void View.Game.ChrysalisContent::CollectChrysalisFly(UnityEngine.Vector3 beginPos, UnityEngine.Vector3 scale)));
        }
        private void OnDisable()
        {
            Message.Messager.Remove<UnityEngine.Vector3>(cmd:  109, action:  new System.Action<UnityEngine.Vector3>(object:  this, method:  System.Void View.Game.ChrysalisContent::UpdateChrysalisIconPos(UnityEngine.Vector3 iconPos)));
            Message.Messager.Remove<UnityEngine.Vector3, UnityEngine.Vector3>(cmd:  107, action:  new System.Action<UnityEngine.Vector3, UnityEngine.Vector3>(object:  this, method:  System.Void View.Game.ChrysalisContent::CollectChrysalisFly(UnityEngine.Vector3 beginPos, UnityEngine.Vector3 scale)));
        }
        public ChrysalisContent()
        {
        
        }
    
    }

}
