using UnityEngine;

namespace Utils.Unity
{
    public static class RectTransformExtension
    {
        // Methods
        public static UnityEngine.Vector2 RelativePosition(UnityEngine.RectTransform self, UnityEngine.RectTransform target)
        {
            var val_3;
            UnityEngine.Bounds val_1 = UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds(root:  target, child:  self);
            UnityEngine.Vector3 val_4 = val_3.center;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        }
        public static UnityEngine.Vector2 GetWorldSize(UnityEngine.RectTransform self)
        {
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[4];
            self.GetWorldCorners(fourCornersArray:  val_1);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1[3], y = val_1[3], z = val_1[4]}, b:  new UnityEngine.Vector3() {x = val_1[0], y = val_1[0], z = val_1[1]});
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return new UnityEngine.Vector2() {x = System.Math.Abs(val_3.x), y = System.Math.Abs(val_3.y)};
        }
        public static UnityEngine.RectTransform AnchorPosX(UnityEngine.RectTransform self, float anchorPosX)
        {
            UnityEngine.Vector2 val_1 = self.anchoredPosition;
            self.anchoredPosition = new UnityEngine.Vector2() {x = anchorPosX, y = val_1.y};
            return (UnityEngine.RectTransform)self;
        }
        public static UnityEngine.RectTransform AnchorPosY(UnityEngine.RectTransform self, float anchorPosY)
        {
            UnityEngine.Vector2 val_1 = self.anchoredPosition;
            self.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = anchorPosY};
            return (UnityEngine.RectTransform)self;
        }
        public static UnityEngine.RectTransform SetSizeWidth(UnityEngine.RectTransform self, float sizeWidth)
        {
            UnityEngine.Vector2 val_1 = self.sizeDelta;
            self.sizeDelta = new UnityEngine.Vector2() {x = sizeWidth, y = val_1.y};
            return (UnityEngine.RectTransform)self;
        }
        public static UnityEngine.RectTransform SetSizeHeight(UnityEngine.RectTransform self, float sizeHeight)
        {
            UnityEngine.Vector2 val_1 = self.sizeDelta;
            self.sizeDelta = new UnityEngine.Vector2() {x = val_1.x, y = sizeHeight};
            return (UnityEngine.RectTransform)self;
        }
        public static UnityEngine.RectTransform SetSize(UnityEngine.RectTransform self, UnityEngine.Vector2 size)
        {
            UnityEngine.Vector2 val_1 = self.sizeDelta;
            self.sizeDelta = new UnityEngine.Vector2() {x = size.x, y = size.y};
            return (UnityEngine.RectTransform)self;
        }
        public static UnityEngine.Vector3 GetCenterPosition(UnityEngine.RectTransform transform)
        {
            UnityEngine.Vector2 val_1 = transform.sizeDelta;
            float val_10 = val_1.x;
            UnityEngine.Vector3 val_2 = transform.lossyScale;
            UnityEngine.Vector2 val_3 = transform.pivot;
            val_3.x = 0.5f - val_3.x;
            val_10 = (val_10 * val_2.x) * val_3.x;
            UnityEngine.Vector2 val_5 = transform.sizeDelta;
            float val_11 = val_5.y;
            UnityEngine.Vector3 val_6 = transform.lossyScale;
            UnityEngine.Vector2 val_7 = transform.pivot;
            val_7.y = 0.5f - val_7.y;
            val_11 = (val_11 * val_6.y) * val_7.y;
            UnityEngine.Vector3 val_9 = transform.position;
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = 0f});
        }
    
    }

}
