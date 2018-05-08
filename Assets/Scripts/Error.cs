﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Error : MonoBehaviour {
    public Font font;
    public Texture2D normal;
    private GUIStyle guiStyle;


    // Use this for initialization
    private void OnGUI()
    {
        guiStyle = new GUIStyle();
        guiStyle.font = font;
        guiStyle.normal.textColor = Color.white;
        guiStyle.hover.textColor = Color.red;

        guiStyle.normal.background = normal;




        guiStyle.fontSize = 45;
        guiStyle.alignment = TextAnchor.MiddleCenter;

        GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 18, Screen.width - (Screen.width / 5), Screen.height / 10), "Seu dispositivo não tem giroscópio!", guiStyle);

        if (GUI.Button(new Rect(Screen.width / 10.0f, Screen.height / 1.5f, Screen.width - (Screen.width / 5), Screen.height / 10), "Sair", guiStyle))
        {
            Application.Quit();
        }

    }
}
