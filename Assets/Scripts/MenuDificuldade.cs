using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuDificuldade : MonoBehaviour
{

    public Font font;
    public Texture2D normal;
    private GUIStyle guiStyle;

    private void OnGUI()


    {
        guiStyle = new GUIStyle();
        guiStyle.font = font;
        guiStyle.normal.textColor = Color.white;
        guiStyle.hover.textColor = Color.red;

        guiStyle.normal.background = normal;


        guiStyle.fontSize = 50;
        guiStyle.alignment = TextAnchor.MiddleCenter;

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 18, Screen.width - (Screen.width / 5), Screen.height / 10), "Fácil", guiStyle))
        {
            //Application.LoadLevel(1);
            //SceneManager.LoadScene("Game");
            MenuSelecoes.speed = 0.10f;
            MenuSelecoes.spawn = 2.0f;
            SceneManager.LoadScene("Menu");
        }

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 3, Screen.width - (Screen.width / 5), Screen.height / 10), "Médio", guiStyle))
        {
            //Application.LoadLevel(1);
            //SceneManager.LoadScene("Game");
            MenuSelecoes.speed = 0.2f;
            MenuSelecoes.spawn = 1.5f;
            SceneManager.LoadScene("Menu");
        }

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height/1.75f, Screen.width - (Screen.width / 5), Screen.height / 10), "Difícl", guiStyle))
        {
            //Application.LoadLevel(1);
            //SceneManager.LoadScene("Game");
            MenuSelecoes.speed = 0.3f;
            MenuSelecoes.spawn = 1.0f;
            SceneManager.LoadScene("Menu");
        }


    }
}
