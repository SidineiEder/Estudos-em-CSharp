using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeCompraDeVida : MonoBehaviour
{
    public int vidas = 1, valorDaVida = 100, carteira = 80;
    public bool vivo;
    void Start()
    {
        if(carteira >= valorDaVida){
            print("Posso comprar vida.");
        } else{print("Não posso comprar vida.");}
        if (vidas >= 1){ vivo = true;
        } else{ vivo = false;}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
