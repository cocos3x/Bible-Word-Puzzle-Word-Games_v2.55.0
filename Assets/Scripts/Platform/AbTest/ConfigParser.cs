using UnityEngine;

namespace Platform.AbTest
{
    internal static class ConfigParser
    {
        // Methods
        public static T ParseData<T>(string json)
        {
            var val_23;
            var val_24;
            var val_26;
            var val_27;
            bool val_29;
            IntPtr val_30;
            Newtonsoft.Json.Linq.JToken val_6 = 0;
            Newtonsoft.Json.Linq.JObject val_1 = Newtonsoft.Json.Linq.JObject.Parse(json:  json);
            val_24 = 0;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 8});
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_26 = val_2.GetFields();
            int val_23 = val_3.Length;
            if(val_23 < 1)
            {
                    return (Platform.AbTest.ABTestData)__RuntimeMethodHiddenParam + 48;
            }
            
            val_23 = 1152921513125411680;
            val_27 = 0;
            val_23 = val_23 & 4294967295;
            label_36:
            if(val_27 >= val_23)
            {
                    throw new IndexOutOfRangeException();
            }
            
            if((System.Reflection.CustomAttributeExtensions.GetCustomAttribute<Platform.AbTest.ABTestAttribute>(element:  1152921504906175568)) == null)
            {
                goto label_60;
            }
            
            val_29 = val_4.allowNull;
            Platform.AbTest.MinVersionAttribute val_5 = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<Platform.AbTest.MinVersionAttribute>(element:  1152921504906175568);
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_1.TryGetValue(propertyName:  val_4.name, value: out  val_6)) == false)
            {
                goto label_9;
            }
            
            if(null == null)
            {
                    throw new NullReferenceException();
            }
            
            val_30 = null;
            if((System.Type.op_Equality(left:  1152921504906175568, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_30}))) == false)
            {
                goto label_13;
            }
            
            1152921504906175568.SetValue(obj:  __RuntimeMethodHiddenParam + 48, value:  System.Convert.ToInt32(value:  val_6));
            goto label_60;
            label_9:
            if(val_29 == true)
            {
                goto label_60;
            }
            
            UnityEngine.Debug.LogError(message:  "ABTestData.Parse Error. Cannot parse property name = "("ABTestData.Parse Error. Cannot parse property name = ") + val_4.name);
            goto label_60;
            label_13:
            val_30 = null;
            if((System.Type.op_Equality(left:  1152921504906175568, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_30}))) != false)
            {
                    1152921504906175568.SetValue(obj:  __RuntimeMethodHiddenParam + 48, value:  System.Convert.ToBoolean(value:  val_6));
            }
            else
            {
                    val_30 = null;
                if((System.Type.op_Equality(left:  1152921504906175568, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_30}))) != false)
            {
                    1152921504906175568.SetValue(obj:  __RuntimeMethodHiddenParam + 48, value:  System.Convert.ToString(value:  val_6));
            }
            else
            {
                    if(val_6 == 0)
            {
                    throw new NullReferenceException();
            }
            
                val_30 = 1152921504906175568;
                1152921504906175568.SetValue(obj:  __RuntimeMethodHiddenParam + 48, value:  Newtonsoft.Json.JsonConvert.DeserializeObject(value:  val_6, type:  val_30));
            }
            
            }
            
            label_60:
            val_27 = val_27 + 1;
            if(val_27 < (val_3.Length << ))
            {
                goto label_36;
            }
            
            return (Platform.AbTest.ABTestData)__RuntimeMethodHiddenParam + 48;
        }
    
    }

}
