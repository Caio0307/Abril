using UnityEngine;

public class Exer1ArrayEWhile : MonoBehaviour
{
    /*
     1. Exibir elementos do array
Crie um array de inteiros com 5 valores e use while para imprimir todos no console
(print).
Objetivo: entender como percorrer um array com while.

     */
    [SerializeField]int[] inteiros = new int[] {1,2,3,4,5 };

    void Start()
    {
        
        int i = 0; 
        
        
      
      while( i < inteiros.Length)
        {
            print(inteiros[i]);
            i++;

        }
    
    
    }

   
}
