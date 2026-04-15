using UnityEngine;

public class Exer2ArrayEWhile : MonoBehaviour
{/*
  2. Somar valores do array
Crie um array com números e use while para calcular a soma total dos elementos.
Objetivo: acumular valores durante a repetição.

  */

    int[] numeros = new int[] { 1, 1 };

    void Start()
    {
        int i = 1;
        while(i < numeros.Length)
        {
            print("1 + 1 = " +  (numeros[0] + numeros[1]) );
            i++;
                
        }
        

    }

   
}
