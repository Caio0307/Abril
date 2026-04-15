using UnityEngine;

public class Exer2For : MonoBehaviour
{
    /*
     Exercício 2
Crie um array com palavras em maiúsculo e use um for para exibir todas em
minúsculo.

     */
    string[] nomes = new string[] {"CAIO","LUCAS","ADRIANO" };
    
    
    void Start()
    {
      for(int i = 0;  i < nomes.Length; i++)
        {
            print(nomes[i].ToLower());
        }
        
    }

    
}
