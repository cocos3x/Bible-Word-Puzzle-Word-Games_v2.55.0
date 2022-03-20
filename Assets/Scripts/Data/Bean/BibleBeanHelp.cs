using UnityEngine;

namespace Data.Bean
{
    public class BibleBeanHelp
    {
        // Methods
        public static Data.Bean.BibleSections GetBibleSections(Data.Bean.BibleBeans bibleBeanss)
        {
            if(bibleBeanss != null)
            {
                    return Data.Bean.BibleBeanHelp.GetBibleSections(bibles:  bibleBeanss.bibles);
            }
            
            throw new NullReferenceException();
        }
        public static Data.Bean.BibleSections GetBibleSections(System.Collections.Generic.List<Data.Bean.BibleBean> bibles)
        {
            var val_12;
            System.Collections.Generic.Dictionary<System.String, Data.Bean.BibleSection> val_1 = new System.Collections.Generic.Dictionary<System.String, Data.Bean.BibleSection>();
            if(1152921513067126176 >= 1)
            {
                    int val_12 = 0;
                do
            {
                if(1152921513067126176 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                string val_2 = Data.Bean.BibleBeanHelp.GetReferenceName(refrence:  "RATIOS_OFF".__il2cppRuntimeField_28);
                if((ContainsKey(key:  val_2)) != false)
            {
                    Data.Bean.BibleSection val_4 = Item[val_2];
                if("RATIOS_OFF" <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4.bibles.Add(item:  "RATIOS_OFF".__il2cppRuntimeField_20);
                Data.Bean.BibleSection val_5 = Item[val_2];
                val_5.chapter_end = val_12;
            }
            else
            {
                    if(1152921504822554624 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = val_2;
                if((System.String.IsNullOrEmpty(value:  "Serbian".__il2cppRuntimeField_18)) != true)
            {
                    if(val_12 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = mem[System.String.__il2cppRuntimeField_byval_arg + 24];
                val_12 = System.String.__il2cppRuntimeField_byval_arg + 24;
            }
            
                typeof(Data.Bean.BibleSection).__il2cppRuntimeField_10 = val_12;
                typeof(Data.Bean.BibleSection).__il2cppRuntimeField_18 = val_2;
                if(val_12 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = val_12 + 0;
                typeof(Data.Bean.BibleSection).__il2cppRuntimeField_28 = val_12;
                typeof(Data.Bean.BibleSection).__il2cppRuntimeField_2C = val_12;
                typeof(Data.Bean.BibleSection).__il2cppRuntimeField_20 = (System.String.__il2cppRuntimeField_byval_arg + 24 + 0) + 32 + 56;
                if(1152921513065860432 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Add(item:  null);
                typeof(Data.Bean.BibleSection).__il2cppRuntimeField_30 = new System.Collections.Generic.List<Data.Bean.BibleBean>();
                Add(key:  val_2, value:  new Data.Bean.BibleSection());
            }
            
                val_12 = val_12 + 1;
            }
            while(val_12 < 1152921513067146848);
            
            }
            
            System.Collections.Generic.List<TSource> val_10 = System.Linq.Enumerable.ToList<Data.Bean.BibleSection>(source:  Values);
            val_10.Sort();
            typeof(Data.Bean.BibleSections).__il2cppRuntimeField_10 = val_10;
            return (Data.Bean.BibleSections)new Data.Bean.BibleSections();
        }
        public static string GetReferenceName(Data.Bean.BibleBean bibleBean)
        {
            if(bibleBean != null)
            {
                    return Data.Bean.BibleBeanHelp.GetReferenceName(refrence:  bibleBean.reference);
            }
            
            throw new NullReferenceException();
        }
        public static string GetReferenceName(string refrence)
        {
            string val_8;
            int val_9;
            char[] val_2 = new char[1];
            val_2[0] = 32;
            System.String[] val_3 = refrence.Trim().Split(separator:  val_2);
            int val_8 = val_3.Length;
            val_8 = "";
            if(val_8 < 2)
            {
                    if(val_8 != 1)
            {
                    return (string)val_8 + null(val_8 + null) + " ";
            }
            
                val_8 = val_3[0];
                return (string)val_8 + null(val_8 + null) + " ";
            }
            
            var val_9 = 0;
            val_8 = val_8 & 4294967295;
            do
            {
                val_9 = val_3.Length;
                if(val_9 < (((-8589934592) + ((val_3.Length) << 32)) >> 32))
            {
                    val_9 = val_3.Length;
            }
            
                val_9 = val_9 + 1;
            }
            while(val_9 < (((-4294967296) + ((val_3.Length) << 32)) >> 32));
            
            return (string)val_8 + null(val_8 + null) + " ";
        }
        public BibleBeanHelp()
        {
        
        }
    
    }

}
