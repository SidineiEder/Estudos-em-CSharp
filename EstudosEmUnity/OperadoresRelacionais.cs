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

    //Operadores Lógicos
/*
    && And/E        Todas as sentenças precisam ser verdadeiras, para o resultado ser verdadeiro
    || Or/Ou        Uma sentença verdadeira, dará o resultado verdadeiro
    !(sentença)     Investe o valor booleano da sentença
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
