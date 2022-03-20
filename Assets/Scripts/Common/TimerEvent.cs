using UnityEngine;

namespace Common
{
    public class TimerEvent
    {
        // Fields
        private static System.Collections.Generic.List<float> timer_Timer;
        private static System.Collections.Generic.List<float> timer_Time;
        private static System.Collections.Generic.List<System.Action> eventList;
        private static System.Collections.Generic.List<bool> isRepeat;
        
        // Methods
        public static void Update()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            System.Collections.Generic.List<System.Boolean> val_7;
            var val_8;
            var val_9;
            val_4 = null;
            val_4 = null;
            if((Common.TimerEvent.timer_Time + 24) < 1)
            {
                    return;
            }
            
            val_3 = 0;
            goto label_5;
            label_44:
            if(val_3 >= (Common.TimerEvent.timer_Time + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = Common.TimerEvent.timer_Time + 16;
            val_3 = val_3 + 0;
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = ((Common.TimerEvent.timer_Time + 16 + 0) + 32) - val_1;
            Common.TimerEvent.timer_Time.set_Item(index:  0, value:  val_1);
            if(val_3 >= (Common.TimerEvent.timer_Time + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = Common.TimerEvent.timer_Time + 16;
            val_4 = val_4 + 0;
            if(((Common.TimerEvent.timer_Time + 16 + 0) + 32) <= 0f)
            {
                    val_5 = null;
                val_5 = null;
                if(val_3 >= (Common.TimerEvent.eventList + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_5 = Common.TimerEvent.eventList + 16;
                val_5 = val_5 + 0;
                (Common.TimerEvent.eventList + 16 + 0) + 32.Invoke();
                if((Common.TimerEvent.eventList.Contains(item:  (Common.TimerEvent.eventList + 16 + 0) + 32)) != false)
            {
                    val_6 = null;
                val_6 = null;
                val_7 = Common.TimerEvent.isRepeat;
                if(val_3 >= (Common.TimerEvent.isRepeat + 24))
            {
                    return;
            }
            
                val_6 = null;
                val_7 = Common.TimerEvent.isRepeat;
                if(val_3 >= (Common.TimerEvent.isRepeat + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_6 = null;
            }
            
                var val_6 = Common.TimerEvent.isRepeat + 16;
                val_6 = val_6 + val_3;
                if(((Common.TimerEvent.isRepeat + 16 + val_3) + 32) != 0)
            {
                    val_8 = null;
                if(val_3 >= (Common.TimerEvent.timer_Timer + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_7 = Common.TimerEvent.timer_Timer + 16;
                val_7 = val_7 + 0;
                Common.TimerEvent.timer_Time.set_Item(index:  0, value:  (Common.TimerEvent.timer_Timer + 16 + 0) + 32);
            }
            else
            {
                    val_9 = null;
                Common.TimerEvent.timer_Timer.RemoveAt(index:  0);
                Common.TimerEvent.timer_Time.RemoveAt(index:  0);
                Common.TimerEvent.eventList.RemoveAt(index:  0);
                Common.TimerEvent.isRepeat.RemoveAt(index:  0);
            }
            
            }
            
            }
            
            val_4 = null;
            val_3 = 1;
            label_5:
            val_4 = null;
            if(val_3 < (Common.TimerEvent.timer_Time + 24))
            {
                goto label_44;
            }
        
        }
        public static void Add(float time, System.Action callback, bool isrepeat = False)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((Common.TimerEvent.eventList.Contains(item:  callback)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            Common.TimerEvent.timer_Timer.Add(item:  time);
            Common.TimerEvent.timer_Time.Add(item:  time);
            Common.TimerEvent.eventList.Add(item:  callback);
            Common.TimerEvent.isRepeat.Add(item:  isrepeat);
        }
        public static void remove(System.Action callback)
        {
            var val_4;
            int val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            if(<0)
            {
                    return;
            }
            
            val_5 = (long)(Common.TimerEvent.eventList + 24) - 1;
            val_6 = (Common.TimerEvent.eventList + 24) - 2;
            goto label_5;
            label_17:
            val_4 = null;
            val_5 = val_5 - 1;
            val_6 = val_6 - 1;
            label_5:
            val_4 = null;
            if(val_5 >= (Common.TimerEvent.eventList + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = Common.TimerEvent.eventList + 16;
            val_3 = val_3 + ((((long)(int)((Common.TimerEvent.eventList + 24 - 1)) - 1)) << 3);
            if((System.Delegate.op_Equality(d1:  (Common.TimerEvent.eventList + 16 + (((long)(int)((Common.TimerEvent.eventList + 24 - 1)) - 1)) << 3) + 32, d2:  callback)) != false)
            {
                    val_7 = null;
                val_7 = null;
                Common.TimerEvent.timer_Timer.RemoveAt(index:  val_5);
                Common.TimerEvent.timer_Time.RemoveAt(index:  val_5);
                Common.TimerEvent.eventList.RemoveAt(index:  val_5);
                Common.TimerEvent.isRepeat.RemoveAt(index:  val_5);
            }
            
            if((val_6 & 2147483648) == 0)
            {
                goto label_17;
            }
        
        }
        private static TimerEvent()
        {
            Common.TimerEvent.timer_Timer = new System.Collections.Generic.List<System.Single>();
            Common.TimerEvent.timer_Time = new System.Collections.Generic.List<System.Single>();
            Common.TimerEvent.eventList = new System.Collections.Generic.List<System.Action>();
            Common.TimerEvent.isRepeat = new System.Collections.Generic.List<System.Boolean>();
        }
    
    }

}
