using UnityEngine;

namespace I2.Loc
{
    internal class ArabicTable
    {
        // Fields
        private static System.Collections.Generic.List<I2.Loc.ArabicMapping> mapList;
        private static I2.Loc.ArabicTable arabicMapper;
        
        // Properties
        internal static I2.Loc.ArabicTable ArabicMapper { get; }
        
        // Methods
        private ArabicTable()
        {
            I2.Loc.ArabicTable.mapList = new System.Collections.Generic.List<I2.Loc.ArabicMapping>();
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38252269773745E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.3827985571903E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38258635761118E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38262879752701E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38267123744283E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.36885704484383E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38271367735866E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38284099710613E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38296831685359E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38305319668524E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38313807651688E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38322295634852E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38330783618017E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38339271601181E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38343515592764E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38347759584346E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38352003575928E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38356247567511E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38364735550675E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.3837322353384E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38381711517004E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38390199500168E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38398687483333E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38407175466497E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38415663449661E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38424151432829E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38432639415993E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38441127399157E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38449615382322E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38458103365486E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.3846659134865E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38475079331815E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38483567314979E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38492055298144E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38254391769536E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.38292587693777E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.36533453183109E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.36609845031587E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.36643796964252E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.36660772930591E-309;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1.36652284947424E-309;
            Add(item:  new System.Object());
        }
        internal static I2.Loc.ArabicTable get_ArabicMapper()
        {
            I2.Loc.ArabicTable val_2;
            I2.Loc.ArabicTable val_3;
            I2.Loc.ArabicTable val_1 = null;
            val_3 = I2.Loc.ArabicTable.arabicMapper;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            val_2 = val_1;
            val_1 = new I2.Loc.ArabicTable();
            I2.Loc.ArabicTable.arabicMapper = val_2;
            val_3 = I2.Loc.ArabicTable.arabicMapper;
            return val_3;
        }
        internal int Convert(int toBeConverted)
        {
            int val_3 = toBeConverted;
            List.Enumerator<T> val_1 = I2.Loc.ArabicTable.mapList.GetEnumerator();
            label_4:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(11993091 != val_3)
            {
                goto label_4;
            }
            
            val_3 = 1;
            label_2:
            0.Dispose();
            return (int)val_3;
        }
    
    }

}
