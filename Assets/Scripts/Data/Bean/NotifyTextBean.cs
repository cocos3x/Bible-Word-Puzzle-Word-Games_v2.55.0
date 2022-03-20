using UnityEngine;

namespace Data.Bean
{
    public class NotifyTextBean
    {
        // Fields
        public string index;
        public string title;
        public string content;
        private static System.Collections.Generic.List<Data.Bean.NotifyTextBean> notifyTextBeans;
        private static System.Collections.Generic.List<Data.Bean.NotifyTextBean> recallNotifyTextBeans;
        
        // Methods
        public NotifyTextBean(string index, string title, string content)
        {
            val_1 = new System.Object();
            this.index = index;
            this.title = val_1;
            this.content = content;
        }
        public static System.Collections.Generic.List<Data.Bean.NotifyTextBean> getNotifyTextBeans()
        {
            System.Collections.Generic.List<Data.Bean.NotifyTextBean> val_11;
            var val_12;
            if(Data.Bean.NotifyTextBean.notifyTextBeans != null)
            {
                    return (System.Collections.Generic.List<Data.Bean.NotifyTextBean>)Data.Bean.NotifyTextBean.notifyTextBeans;
            }
            
            Data.Bean.NotifyTextBean.notifyTextBeans = new System.Collections.Generic.List<Data.Bean.NotifyTextBean>();
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_10 = "9";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_18 = "217";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_20 = "218";
            Add(item:  new System.Object());
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_10 = "10";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_18 = "219";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_20 = "220";
            Add(item:  new System.Object());
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_10 = "12";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_18 = "221";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_20 = "222";
            Add(item:  new System.Object());
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_10 = "15";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_18 = "223";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_20 = "224";
            Add(item:  new System.Object());
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_10 = "17";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_18 = "225";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_20 = "226";
            Add(item:  new System.Object());
            object val_7 = null;
            val_11 = Data.Bean.NotifyTextBean.notifyTextBeans;
            val_12 = "18";
            val_7 = new System.Object();
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_10 = val_12;
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_18 = "227";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_20 = "228";
            Add(item:  val_7);
            if((Common.Singleton<Logic.Treasure.TreasureController>.Instance.TreasureActivityIsOpen()) == false)
            {
                    return (System.Collections.Generic.List<Data.Bean.NotifyTextBean>)Data.Bean.NotifyTextBean.notifyTextBeans;
            }
            
            object val_10 = null;
            val_11 = Data.Bean.NotifyTextBean.notifyTextBeans;
            val_12 = "19";
            val_10 = new System.Object();
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_10 = val_12;
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_18 = "229";
            typeof(Data.Bean.NotifyTextBean).__il2cppRuntimeField_20 = "230";
            Add(item:  val_10);
            return (System.Collections.Generic.List<Data.Bean.NotifyTextBean>)Data.Bean.NotifyTextBean.notifyTextBeans;
        }
    
    }

}
