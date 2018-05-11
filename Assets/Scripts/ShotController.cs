using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Classe para controlar a interação dos projéteis e fanstasmas
public class ShotController : MonoBehaviour {

  private int size = 50;
  public Texture2D bullet;
  private bool canFire = true;
  public Text reloadText;

  //Utiliza o raycast para definir a colisão posteriormente
  RaycastHit hit;

  //Quantidade inicial de munição
  private int shots = 6;

  //Utiliza coroutine para controlar o tempo que o player não pode disparar
  IEnumerator WaitToShoot () {
    canFire = false;
    yield return new WaitForSeconds(0.5f);
    canFire = true;
  }


    //Utiliza coroutine para controlar o tempo para recarregar as munições
    IEnumerator WaitToReload () {
    reloadText.text = "RELOADING...";
    canFire=false;
    yield return new WaitForSeconds(3f);
    shots = 6;
    reloadText.text = "";
    canFire=true;
  }

  void OnGUI () {
    for (int i = 0; i < shots; i++) {
      GUI.DrawTexture (new Rect ((i*size), Screen.height - size, size, size), bullet);
    }
  }

  private void Update () {
    if (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began && canFire==true) {

      shots--;

      if(shots==0)
        StartCoroutine("WaitToReload");
      else
        StartCoroutine("WaitToShoot");

      if (Physics.Raycast(Player.Instance.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
      {
        if(hit.collider.tag == "Enemy"){
          Destroy(hit.collider.gameObject);
          Player.Instance.points++;
        }
      }
    }
  }

}
