using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    public static Action jumped = delegate { };
    public static Action jumping;

    //public ....onEscape PARA MENU PAUSA

    void Update()
    {
        //pause menu INVOKE TECLAS
    }
}
