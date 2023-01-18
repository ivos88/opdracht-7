using Domain; 
namespace opdracht_7
{
    public class Opdracht7Tests
    {
        int[] Route1 = new int[] { 12, 32 };
        int[] Route2 = new int[] { 10, 26 };
        int[] Route3 = new int[] { 16, 34 };
        int[] Route4 = new int[] { 14, 28 };
        int[] Route5 = new int[] { 41, 66 };
        int[] Route6 = new int[] { 32, 58 };
        

        [Test]
        public void Opdracht7MaxTest()
        {
            var opdracht7 = new Opdracht7();

            if (Opdracht7.opdracht7(1) != Route5[1])
                throw new Exception();
        }

        [Test]
        public void Opdracht7MinTest()
        {
            var opdracht7 = new Opdracht7();

            if (Opdracht7.opdracht7(0) != Route5[0])
                throw new Exception();
        }
    }
}