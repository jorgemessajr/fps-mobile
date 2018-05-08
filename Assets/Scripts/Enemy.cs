using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

  

  private void Start() {

        //transform.Rotate((0), (5f), (0));
    }

  private void FixedUpdate () {
        //transform.Rotate((0), (5f), (0));
        transform.LookAt(Camera.main.transform.position, Vector3.up);

   
       // transform.Translate((Player.Instance.transform.position - transform.position)
        //* MenuSelecoes.speed * Time.deltaTime);


       // transform.Rotate((0), (5f), (0));
        Vector3 direcao = (Player.Instance.transform.position - transform.position).normalized;
        float distancia = (Player.Instance.transform.position - transform.position).magnitude;
        Vector3 move = transform.position + (direcao * MenuSelecoes.speed);
        transform.position = move;

    }

}
