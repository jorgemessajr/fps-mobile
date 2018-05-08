using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

    public Font font; 
    public Texture2D normal;
    private GUIStyle guiStyle;

    MenuDificuldade dificuldade = new MenuDificuldade();


    private void OnGUI()
    

    {
        if (!SystemInfo.supportsGyroscope)
        {
            SceneManager.LoadScene("Error");
        }


        guiStyle = new GUIStyle();
        guiStyle.font = font;
        guiStyle.normal.textColor = Color.white;
        guiStyle.hover.textColor = Color.red;

        guiStyle.normal.background = normal; 




        guiStyle.fontSize = 50;
        guiStyle.alignment = TextAnchor.MiddleCenter;

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 18, Screen.width-(Screen.width/5), Screen.height / 10), "Start Game", guiStyle))
        {
            //Application.LoadLevel(1);
            SceneManager.LoadScene("game-scene");
        }

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 3, Screen.width - (Screen.width / 5), Screen.height / 10), "Dificuldade", guiStyle))
        {
            //Application.LoadLevel(1);
            SceneManager.LoadScene("Menu_dificuldade");
        }

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height/1.5f, Screen.width - (Screen.width / 5), Screen.height / 10), "Sair", guiStyle))
        {
            Application.Quit();
        }

    }
}
