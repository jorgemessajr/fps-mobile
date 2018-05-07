using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        speed = 0.5f;
        spawn = 2.0f;
    }

}
