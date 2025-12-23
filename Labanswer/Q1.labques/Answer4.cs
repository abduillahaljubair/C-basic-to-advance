using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKAI
{
    public class Answer4
    {
        public static void AnswerQuestion4()
        {
            double fixedPrice = 100;

            MaterialA materialA = new MaterialA(fixedPrice);
            MaterialB materialB = new MaterialB(fixedPrice);

            // Call the generic method
            // getAmount<T>() with appropriate
            // parameters two times;
            // Once for materialA variable,
            // other for materialB variable
        }

        // Complete the Generic method
        // with appropriate parameter
        public static void getAmount<T>() where T : Material
        {
            
        }
    }


    public interface Material
    {
        int CalculateAmount();
    }

    // Implement Material in MaterialA and
    // provide definition for CalculateAmount()
    // This class will take rawMaterial and use cost 6
    public class MaterialA
    {
        int rawMaterial;

        public MaterialA(int rawMaterial)
        {
            this.rawMaterial = rawMaterial;
        }

    }

    // Implement Material in MaterialB and
    // provide definition for CalculateAmount()
    // This class will take rawMaterial and use cost 4
    public class MaterialB
    {
        int rawMaterial;

        public MaterialB(int rawMaterial)
        {
            this.rawMaterial = rawMaterial;
        }

    }
}
