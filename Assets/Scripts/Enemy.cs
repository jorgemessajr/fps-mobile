using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

  

  private void Start() {}

  private void FixedUpdate () {
    transform.Translate((Player.Instance.transform.position - transform.position)
        * MenuSelecoes.speed * Time.deltaTime);
  }

}
