using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //Adicionado para usar o "System.Convert"

public class ConversaoDeDados : MonoBehaviour
{
    int vidas, dinheiroEmReais;
    float dinheiro = 15.6f;
    public string mensagemDoMenu;
    bool estaVivo = true;

    // Start is called before the first frame update
    void Start()
    {
        //Convertendo Float em Inteiro
        dinheiroEmReais = (int)dinheiro;

        //Convertendo Float em Inteiro
        vidas = Convert.ToInt32 (estaVivo); //Necessário adicionar o "using System;"


        //Convertendo Float/Inteiro em String
        mensagemDoMenu = "Voce tem " + dinheiro.ToString() + " em dinheiro.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
