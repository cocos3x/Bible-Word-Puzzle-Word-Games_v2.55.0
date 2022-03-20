using UnityEngine;
public class RaycastTarget : MaskableGraphic
{
    // Methods
    protected RaycastTarget()
    {
        mem[1152921512600682808] = 0;
    }
    protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
    {
        if(vh != null)
        {
                vh.Clear();
            return;
        }
        
        throw new NullReferenceException();
    }
    private void OnDrawGizmosSelected()
    {
        if(this.isActiveAndEnabled == false)
        {
                return;
        }
        
        if(this.raycastTarget == false)
        {
                return;
        }
        
        UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[4];
        this.rectTransform.GetWorldCorners(fourCornersArray:  val_3);
        var val_8 = 0;
        do
        {
            UnityEngine.Color val_5 = this.color;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            val_8 = val_8 + 1;
            var val_9 = (long)(val_8 == 4) ? 0 : (val_8);
            val_9 = val_3 + (val_9 * 12);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 8.428086E-15f, y = 8.428086E-15f, z = val_5.b}, to:  new UnityEngine.Vector3() {x = ((long)(int)(0 == 0x4 ? 0 : (0 + 1)) * 12) + val_3 + 32, y = ((long)(int)(0 == 0x4 ? 0 : (0 + 1)) * 12) + val_3 + 32 + 4, z = ((long)(int)(0 == 0x4 ? 0 : (0 + 1)) * 12) + val_3 + 40});
        }
        while((val_8 - 1) < 3);
        
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_3[0], y = val_3[0], z = val_3[1]}, to:  new UnityEngine.Vector3() {x = val_3[3], y = val_3[3], z = val_3[4]});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_3[1], y = val_3[2], z = val_3[2]}, to:  new UnityEngine.Vector3() {x = val_3[4], y = val_3[5], z = val_3[5]});
    }

}
