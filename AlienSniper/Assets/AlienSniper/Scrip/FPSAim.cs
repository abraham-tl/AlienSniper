using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public sealed class FPSAim : MonoBehaviour {
    public Text hola;
    //float mousex;
    //float mousey;
    //public bool invertedmouse;

    void Start ()
    {
        ////SE ASIGNA ROTACION A UN OBJETO
        //transform.eulerAngles = new Vector3(30,0,0);       
	}

	void Update () {
        int fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
                fingerCount++;

        }
        if (fingerCount > 0)
        {
            print("User has " + fingerCount + " finger(s) touching the screen");
        }
        hola.text = fingerCount.ToString();

        // //ESTE IF CONTROL O INVIERTE LA ROTACION VERTICAL CON EL MUSE
        // if (invertedmouse)
        // {
        //     mousey = mousey + Input.GetAxis("Mouse Y");
        // }
        // else
        // {
        //     mousey = mousey - Input.GetAxis("Mouse Y");
        // }

        ////ROTA EL OBJETO DEPENDIENDO DEL MOVIMIENTO DEL MOUSE VERTICAL 
        // mousex = mousex + Input.GetAxis("Mouse X"); 
        // transform.eulerAngles = new Vector3(mousey, mousex, 0);     
    }   
}
