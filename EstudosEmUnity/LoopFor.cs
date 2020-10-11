using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopFor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Metodo de Loop For
        //VARIAVEL, CONDICAO, INCREMENTO/DECREMENTO
        for(int intFor = 1; intFor <= 10; intFor++ ){
                print("Estou em um Loop For, e meu inteiro vale "+ intFor +".");
        }
        print ("Acabou o Loop For!");

        //Metodo de Loop While
        int intWhile = 1;
        while(intWhile <= 10){
            print("Estou em um Loop While, e meu inteiro vale"+ intWhile +".");
            intWhile++; // Ou intWhile = intWhile+1;
        }
        print ("Acabou o Loop While!");

        //Metodo de Loop Do/While
        int loopDo = 1;
        do{
            print("Meu inteiro do Loop Do, vale "+ loopDo+".");
            loopDo++;
        }while(loopDo <=10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
