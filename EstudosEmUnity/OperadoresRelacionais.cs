using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresRelacionais : MonoBehaviour
{

    //Operadores Relacionais
/*
    == Igual
    != Diferente
    > Maior Que
    < Menor Que
    >= Maior ou Igual Que
    <= Menor ou Igual Que
*/
    public int numero01, numero02;
    public bool maiorQue;
    public string veracidade;
    void Start()
    {
        if (numero01 > numero02){
            maiorQue = true;
            veracidade = " é ";
        } else {
            maiorQue = false; 
            veracidade = " não é ";
            }

        print("O numero " + numero01.ToString() + veracidade + "maior que o numero " + numero02.ToString() +".");
    }

    void Update()
    {
        
    }
}
