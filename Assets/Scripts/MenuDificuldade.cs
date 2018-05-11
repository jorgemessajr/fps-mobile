using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//Classe que controla o menu de seleção do nível de dificuldade do jogo
public class MenuDificuldade : MonoBehaviour
{

    public Font font;
    public Texture2D normal;
    private GUIStyle guiStyle;

    private void OnGUI()

    {
        //Configurações do texto
        guiStyle = new GUIStyle();
        guiStyle.font = font;
        guiStyle.normal.textColor = Color.white;
        guiStyle.hover.textColor = Color.red;

        guiStyle.normal.background = normal;


        guiStyle.fontSize = 50;
        guiStyle.alignment = TextAnchor.MiddleCenter;

        //Desenha os botões e aplica a dificuldade ao ser clicado, aumentando 0.1 na velocidade para cada nível
        //e diminuindo em 0.5 a frequência de aparecimento de fantasmas
        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 18, Screen.width - (Screen.width / 5), Screen.height / 10), "Fácil", guiStyle))
        {

            MenuSelecoes.speed = 0.10f;
            MenuSelecoes.spawn = 2.0f;
            SceneManager.LoadScene("Menu");
        }

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 3, Screen.width - (Screen.width / 5), Screen.height / 10), "Médio", guiStyle))
        {
            MenuSelecoes.speed = 0.2f;
            MenuSelecoes.spawn = 1.5f;
            SceneManager.LoadScene("Menu");
        }

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height/1.75f, Screen.width - (Screen.width / 5), Screen.height / 10), "Difícl", guiStyle))
        {

            MenuSelecoes.speed = 0.3f;
            MenuSelecoes.spawn = 1.0f;
            SceneManager.LoadScene("Menu");
        }


    }
}
