using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    
    public Vector3 Posicion_destino;

    public int estado;
	// Use this for initialization
	void Start ()
    {
        estado = 0;
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
    }





}
