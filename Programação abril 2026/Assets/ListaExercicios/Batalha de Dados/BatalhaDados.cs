using UnityEngine;

public class BatalhaDados : MonoBehaviour
{

    [SerializeField] private int VidaJogador;
    [SerializeField] private int AtaqueJogador;
    [SerializeField] private int DefesaJogador;
    [SerializeField]private int VidaCPU;
    [SerializeField] private int AtaqueCPU;
    [SerializeField] private int DefesaCPU;
    int PontosDistribuiçãoCPU = 5;
    int PontosDistribuiJogador = 5;
    bool jogando = true;   
    bool distribuiçãoCorreta = false;
    void Start()
    {
       
        if(jogando)
        {
            
            AtaqueCPU = Random.Range(1, PontosDistribuiçãoCPU--);   
           
           
            if(AtaqueCPU > 0 && PontosDistribuiçãoCPU > 0)
            {
                PontosDistribuiçãoCPU = PontosDistribuiçãoCPU - AtaqueCPU;
            }
            VidaCPU = Random.Range(1, PontosDistribuiçãoCPU--);
            if (VidaCPU > 0 && PontosDistribuiçãoCPU > 0)
            {
                PontosDistribuiçãoCPU = PontosDistribuiçãoCPU - VidaCPU;
            }
            DefesaCPU = Random.Range(1, PontosDistribuiçãoCPU--);
            if (DefesaCPU > 0 && PontosDistribuiçãoCPU > 0)
            {
                PontosDistribuiçãoCPU = PontosDistribuiçãoCPU - DefesaCPU;
            }
           

              
        }



    }

   

    void Update()
    {
       
        
    }
}
