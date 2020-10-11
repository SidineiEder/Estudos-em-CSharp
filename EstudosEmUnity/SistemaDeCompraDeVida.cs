using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeCompraDeVida : MonoBehaviour
{
    public int vidas = 1, valorDaVida = 100, carteira = 80, dificuldade;
    public bool vivo;

    void Start()
    {
        if(carteira >= valorDaVida){
            print("Posso comprar vida.");
        } else{print("Não posso comprar vida.");}

        //Operador Ternário
        // variavel = CONDICAO?TRUE:FALSE
        vivo = (vidas > 0)? true : false;
        
        if(vivo){
            print("Jogador com vida");
        }else{print("Jogador sem vida!");}

        //Utilizando Case em Switch ao invés de condicionais IF
        switch(dificuldade){
            case 1:
            print("Muito facil!");
            break;
            case 2:
            print("Tudo normal!");
            break;
            case 3:
            print("Muito Dificil!");
            break;
            default:
            print("Dificuldade não encontrada!");
            break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
