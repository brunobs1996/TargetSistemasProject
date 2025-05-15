namespace TargetSistemasProject;

public class Exercicio5
{

    public string InverterString(string str)
    {
        char[] caracteres = str.ToCharArray();
        int inicio = 0;
        int fim = caracteres.Length - 1;

        while (inicio < fim)
        {
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            inicio++;
            fim--;
        }

        return new string(caracteres);
    }

}