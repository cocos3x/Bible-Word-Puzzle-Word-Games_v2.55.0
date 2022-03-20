using UnityEngine;

namespace I2.Loc
{
    public class RTLFixer
    {
        // Methods
        public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
        {
            string val_17;
            var val_18;
            string val_19;
            string val_20;
            val_17 = str;
            string val_1 = I2.Loc.HindiFixer.Fix(text:  val_17);
            if((System.String.op_Inequality(a:  val_1, b:  val_17)) != false)
            {
                    return val_1;
            }
            
            val_18 = null;
            val_18 = null;
            I2.Loc.RTLFixerTool.showTashkeel = showTashkeel;
            I2.Loc.RTLFixerTool.useHinduNumbers = useHinduNumbers;
            val_19 = "\n";
            val_20 = System.Environment.NewLine;
            if((val_17.Contains(value:  "\n")) != false)
            {
                    val_17 = val_17.Replace(oldValue:  "\n", newValue:  val_20);
                val_20 = System.Environment.NewLine;
            }
            
            if((val_17.Contains(value:  val_20)) == false)
            {
                    return I2.Loc.RTLFixerTool.FixLine(str:  val_17);
            }
            
            string[] val_10 = new string[1];
            val_19 = System.Environment.NewLine;
            val_10[0] = val_19;
            System.String[] val_12 = val_17.Split(separator:  val_10, options:  0);
            if((val_12.Length == 0) || (val_12.Length == 1))
            {
                    return I2.Loc.RTLFixerTool.FixLine(str:  val_17);
            }
            
            if(val_12.Length < 2)
            {
                    return val_1;
            }
            
            do
            {
                var val_14 = 5 - 4;
                string val_17 = I2.Loc.RTLFixerTool.FixLine(str:  val_12[0])(I2.Loc.RTLFixerTool.FixLine(str:  val_12[0])) + System.Environment.NewLine + I2.Loc.RTLFixerTool.FixLine(str:  val_12[1])(I2.Loc.RTLFixerTool.FixLine(str:  val_12[1]));
                var val_19 = 5 + 1;
            }
            while((5 - 3) < val_12.Length);
            
            return val_1;
        }
    
    }

}
