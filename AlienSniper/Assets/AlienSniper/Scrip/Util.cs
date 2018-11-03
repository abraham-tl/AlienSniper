using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour {

    float timer = 0;
    int i = 0;

    public Vector3[] posicion_entrada;
    public int cant_posiciones;
    public Vector3 posicion_inicial;
    public float posicion_x;
    public float posicion_z;
    public float posicion_y;

    public int asignacion;
    public int cantidad_tropa;

    public bool tropa = false;
    // Use this for initialization
    void Start () {
        
        posicion_inicial = new Vector3(-25, 2, 42);
        posicion_x = posicion_inicial.x;
        posicion_y = 2;
        posicion_z = posicion_inicial.z;
        cant_posiciones = 10;
        posicion_entrada = new Vector3[cant_posiciones];

        Cargar_posiciones();
        asignacion = 0;
        
    }
	
	// Update is called once per frame
	void Update ()
    {


     if(tropa)
        {
            
            timer += Time.deltaTime;          
            while (i<cant_posiciones && timer > 2.5f)
            {               
                GameObject enemy = Instantiate(Resources.Load("Cube") as GameObject, transform.position, transform.rotation);
                timer = 0;
                i++;
            }
            
            if (i >cant_posiciones)
            {
                tropa = false;
            }
        }
	}

    public void Cargar_posiciones()
    {
        for (int i = 0; i < cant_posiciones; i++)
        {
            if (i < 5)
            {
                posicion_entrada[i] = new Vector3(posicion_x, posicion_y, posicion_z);
                posicion_x += 2.5f;
                posicion_z += 2.5f;
            }
            else
            {
                posicion_entrada[i] = new Vector3(posicion_x+40f, posicion_y, posicion_z);
                posicion_x += 2.5f;
            }
        }
    }
    public Vector3 Asignar_posicion()
    {
        Vector3 posicion;
        posicion = posicion_entrada[asignacion];
        print(asignacion);
        asignacion ++;
        return posicion;
        
    }
}
