using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


//Classe para controlar o menu inicial
public class Menu : MonoBehaviour {

    //Configurações do texto
    public Font font; 
    public Texture2D normal;
    private GUIStyle guiStyle;

    //Chama a classe estática que armazena os níveis de dificuldade
    MenuDificuldade dificuldade = new MenuDificuldade();


    private void OnGUI()
    

    {
        if (!SystemInfo.supportsGyroscope)
        {
            //Se o smartphone não tem giroscópio redireciona para cena de erro
            SceneManager.LoadScene("Error");
        }

        //Configurações do texto
        guiStyle = new GUIStyle();
        guiStyle.font = font;
        guiStyle.normal.textColor = Color.white;
        guiStyle.hover.textColor = Color.red;
        guiStyle.normal.background = normal; 
        guiStyle.fontSize = 50;
        guiStyle.alignment = TextAnchor.MiddleCenter;


        //Desenha os três botões redirecionando-os para suas respectivas cenas
        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 18, Screen.width-(Screen.width/5), Screen.height / 10), "Start Game", guiStyle))
        {
 
            SceneManager.LoadScene("game-scene");
        }

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 3, Screen.width - (Screen.width / 5), Screen.height / 10), "Dificuldade", guiStyle))
        {
 
            SceneManager.LoadScene("Menu_dificuldade");
        }

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height/1.5f, Screen.width - (Screen.width / 5), Screen.height / 10), "Sair", guiStyle))
        {
            Application.Quit();
        }

    }
}
