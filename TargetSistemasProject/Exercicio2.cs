namespace TargetSistemasProject;

public class Exercicio2
{

    public bool VerifyFibonacciNumber(int numberToVerify)
    {
        int a = 0;
        int b = 1;

        if (numberToVerify == 0 || numberToVerify == 1)
            return true;

        while (b <= numberToVerify)
        {
            int temp = a + b;
            a = b;
            b = temp;

            if (b == numberToVerify)
                return true;
        }

        return false;
    }

}