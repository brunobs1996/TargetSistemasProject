namespace TargetSistemasProject;

public class Exercicio1
{
    public int ReturnSum()
    {
        int index = 13;
        int sum = 0;
        int k = 0;

        while (k < index)
        {
            k += 1;
            sum += k;
        }

        return sum;
    }
}