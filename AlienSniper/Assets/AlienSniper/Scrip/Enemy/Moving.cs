using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : Util {

    public bool state;

    public Vector3 Posicion_destino;
    public int estado;

    float timer;
	// Use this for initialization
	void Start ()
    {
        state = false;
        estado = 0;
        timer = 0;
        Posicion_destino = FindObjectOfType<Util>().Asignar_posicion();
	}
	
	// Update is called once per frame
	void Update () {
        if (estado == 0)
        {
            transform.LookAt(Posicion_destino);
            if ((Posicion_destino - transform.position).magnitude > 1)
            {
                transform.position += transform.forward * (Time.deltaTime * 10);
            }
        }

        timer += Time.deltaTime;
        if (state==false && timer >10)
        {
            state = true;
            timer = 0;
        }
        if (state)
        {
            //Posicion_destino = Assign_Ally();

        }

 

    }

    public void Enemy_Take()
    {

    }



}
