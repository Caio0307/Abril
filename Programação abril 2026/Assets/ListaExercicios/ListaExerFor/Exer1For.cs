using UnityEngine;

public class Exer1For : MonoBehaviour
{
    /*
     Crie um array de nomes e use um for para exibir todos os nomes em maiúsculo.
     */

    string[] nomes = new string[] {"Caio","Lucas","Adriano" };
    void Start()
    {

        for (int i = 0; i < 3; i++)
        {
            print(nomes[i]);
        }


    }

    
}
