using Mono.Cecil.Cil;
using UnityEngine;

public class JogoAposta : MonoBehaviour
{
    int moedasJogador = 100;
    [SerializeField]private bool guerreiroA;
    [SerializeField]private bool guerreiroB;
    [Header("Faça sua aposta:")]
    [SerializeField] private int valorAposta;
    int forcaA;
    int forcaB;
    bool ApostaFeita;
    
    
    void Start()
    {   //vendo de a aposta foi feita corretamente
        if(valorAposta > 0 && valorAposta <= 100)
        {
            ApostaFeita = true;
            print("Aposta feita, boa sorte");
        }



    }

   
   
    
    void Update()
    {//se aposta foi feita, gera a força dos guerreiros
       if(Input.anyKeyDown && ApostaFeita)
        {
            forcaA = Random.Range(1, 99);
            forcaB = Random.Range(1, 99);
           
            //verifica qual guerreiro vai ganhar
            if( forcaA > forcaB)
            {
                print("Guerreiro A venceu!");
            }
            else if(forcaB > forcaA)
            {
                print("Guerreiro B venceu!");
            }
             
            
            //vendo se o jogador ganhou a aposta com o guerreiro A
            if(guerreiroA && forcaA > forcaB)
            {
                valorAposta = valorAposta * 2;
                print("seu guerreiro ganhou! seu valor apostado foi dobrado");
            }
            else if (guerreiroA && forcaB > forcaA)//se apostou errado perdeu
            {
                print("Seu guerreiro perdeu, você perdeu seu dinheiro da aposta");
            }

           
           //vendo se o jogador ganhou a aposta com o guerreiro B            
            if (guerreiroB && forcaB > forcaA)
            {
                valorAposta = valorAposta * 2;
                print("seu guerreiro ganhou! seu valor apostado foi dobrado");
            }
            else if (guerreiroB && forcaA > forcaB)//se apostou errado perdeu
            {
                print("Seu guerreiro perdeu, você perdeu seu dinheiro da aposta");
            }
            



        }




    }
}
