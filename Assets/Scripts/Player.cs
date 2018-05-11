using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Classe para controlar o player, que é único
public sealed class Player : MonoBehaviour {

  //Definição de atributos do player
  public int hp = 10;

  public int points = 0;

  private static Player instance;

  public Text hpText;
  public Text scoreText;

  private Player () {}

  private void Start() {

  }

 

  public static Player Instance {
    //Retorna o player
    get {
      if (instance == null)
        instance = GameObject.FindObjectOfType (typeof(Player)) as Player;
      return instance;
    }
  }

  private void OnTriggerEnter(Collider other){
    //Se colidir com o fantasma, o destroi e perde 1 hp
    Destroy(other.gameObject);
    hp--;
  }

  private void FixedUpdate () {
    //Se o HP é 0, então game over
    if(hp>0)
      hpText.text = "HP: "+hp.ToString();
    else
      hpText.text = "Game Over!";

    scoreText.text = "Pontos: "+points.ToString();
  }

}
