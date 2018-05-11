using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

  //Declara��o do tempo inicial, em que os fantasmas come�ar�o a aparecer
  public float startTime = 2f;

  //Intervalo de tempo entre os aparecimentos de fantasmas
  public float intervalTime = MenuSelecoes.spawn;

  public GameObject enemy;

  private void Start()
  {
    //Chamada do InvokeRepeating para controlar a fun��o de Spawn com os tempos definidos acima
    InvokeRepeating("Spawn", startTime, intervalTime);
  }

  private void Spawn()

  {
        //Declara��o do vetor de posi��o onde o fantasma ir� aparecer, neste caso aleatoriamente
        //e em uma faixa vis�vel para o jogador
        Vector3 position = new Vector3(Random.Range(-100f, 100.0f), Random.Range(-5f,20f), Random.Range(-100.0f, 100.0f));
    Instantiate(enemy, position, Quaternion.identity);
    
  }

}
