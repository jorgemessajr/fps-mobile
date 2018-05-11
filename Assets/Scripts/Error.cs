using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Error : MonoBehaviour {
    public Font font;
    public Texture2D normal;
    private GUIStyle guiStyle;


    //Chamada da função OnGUI para desenhar botões na tela
    private void OnGUI()
    {
        //Definição das configurações do texto
        guiStyle = new GUIStyle();
        guiStyle.font = font;
        guiStyle.normal.textColor = Color.white;
        guiStyle.hover.textColor = Color.red;
        guiStyle.normal.background = normal;
        guiStyle.fontSize = 45;
        guiStyle.alignment = TextAnchor.MiddleCenter;

        //A mensagem de que o celular não tem giroscópio é um botão tem função
        GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 18, Screen.width - (Screen.width / 5), Screen.height / 10), "Seu dispositivo não tem giroscópio!", guiStyle);

        //Apenas o botão para sair é clicável
        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 1.5f, Screen.width - (Screen.width / 5), Screen.height / 10), "Sair", guiStyle))
        {
            Application.Quit();
        }

    }
}
