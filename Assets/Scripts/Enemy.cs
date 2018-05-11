using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

  

  private void Start() {

    }

    //Utiliza��o da fun��o fixedupdate para ser chamada em intervalos fixos de tempo
    //Recomend�vel para utiliza��o em conjunto com fun��es relacionadas a f�sica de objetos
  private void FixedUpdate () {
        
        //Fun��o para o enemy olhar sempre para a c�mera
        transform.LookAt(Camera.main.transform.position, Vector3.up);

        //Declara��o do vetor de dire��o e dist�ncia para mover o enemy at� a posi��o do player
        Vector3 direcao = (Player.Instance.transform.position - transform.position).normalized;
        float distancia = (Player.Instance.transform.position - transform.position).magnitude;
        Vector3 move = transform.position + (direcao * MenuSelecoes.speed);
        transform.position = move;

    }

}
