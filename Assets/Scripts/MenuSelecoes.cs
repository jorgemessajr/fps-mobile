using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe de definição dos itens que são parâmetros para o nível de dificuldade
public static class MenuSelecoes {



       public static float speed
    {
        get;
        set;
    }

    public static float spawn
    {
        get;
        set;
    }


    static MenuSelecoes()
    {
        speed = 0.10f;
        spawn = 2.0f;
    }

}
