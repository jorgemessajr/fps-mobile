using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

  

  private void Start() {

    }

    //Utilização da função fixedupdate para ser chamada em intervalos fixos de tempo
    //Recomendável para utilização em conjunto com funções relacionadas a física de objetos
  private void FixedUpdate () {
        
        //Função para o enemy olhar sempre para a câmera
        transform.LookAt(Camera.main.transform.position, Vector3.up);

        //Declaração do vetor de direção e distância para mover o enemy até a posição do player
        Vector3 direcao = (Player.Instance.transform.position - transform.position).normalized;
        float distancia = (Player.Instance.transform.position - transform.position).magnitude;
        Vector3 move = transform.position + (direcao * MenuSelecoes.speed);
        transform.position = move;

    }

}
