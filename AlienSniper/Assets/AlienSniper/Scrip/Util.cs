using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour {

   
    public Vector3[] posicion_entrada;
    public int cant_posiciones;
    public Vector3 posicion_inicial;
    public float posicion_x;
    public float posicion_z;
    public float posicion_y;

    public int asignacion;
    public int cantidad_tropa;
    // Use this for initialization
    void Start () {
        posicion_inicial = new Vector3(-25, 2, 42);
        posicion_x = posicion_inicial.x;
        posicion_y = 2;
        posicion_z = posicion_inicial.z;
        cant_posiciones = 5;
        posicion_entrada = new Vector3[cant_posiciones];

        Cargar_posiciones();
        asignacion = 0;
        Enviar_tropa();
    }
	
	// Update is called once per frame
	void Update ()
    {
     
	}

    public void Cargar_posiciones()
    {
        for (int i = 0; i < cant_posiciones; i++)
        {
            posicion_entrada[i] = new Vector3(posicion_x, posicion_y, posicion_z);
            posicion_x += 2.5f;
            posicion_z += 2.5f;
        }
    }

    public Vector3 Asignar_posicion()
    {
        Vector3 posicion;
        posicion = posicion_entrada[asignacion];
        asignacion += 1;
        return posicion;
        
    }

    public void Enviar_tropa()
    {
        for (int i =0;i<5;i++)
        {
            float timer = 0;
            while(timer < 10)
            {

                timer += Time.deltaTime;

                print(timer);
            }
            GameObject enemy = Instantiate(Resources.Load("Cube") as GameObject, transform.position, transform.rotation);

        }

    }

}
