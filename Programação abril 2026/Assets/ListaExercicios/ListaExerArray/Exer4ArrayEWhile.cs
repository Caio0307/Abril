using UnityEngine;

public class Exer4ArrayEWhile : MonoBehaviour
{
    /*
     4. Contar números pares
Crie um array e use while para contar quantos números pares existem.
Objetivo: usar condição (if) dentro do while.

     */

   [SerializeField]int[] numerosPares = new int[] { 1, 2, 3, 4, 5,};

    void Start()
    {
        int i = 0;
        
        while(i < numerosPares.Length)
        {
            i++;
            if (i <  numerosPares.Length)
            {
                print(numerosPares[i] % 2 == 0);
            }
            
        }



    }

}
