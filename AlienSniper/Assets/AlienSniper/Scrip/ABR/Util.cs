using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour {
    
    float timer = 0;
    int i = 0;
    int otro = 0;
    public GameObject[] enemy_group;
    public GameObject[] ally_group;
    public Vector3[] posicion_entrada;

    public int cant_posiciones;
    public int cant_ally;

    public Vector3 posicion_inicial;
    public float posicion_x;
    public float posicion_z;
    public float posicion_y;

    public int asignacion;
    public int cantidad_tropa;

    public bool tropa = false;


    // Use this for initialization
    void Start() {
        cant_ally = 5;
        ally_group = new GameObject[cant_ally];
        Load_Ally();


        posicion_inicial = new Vector3(-25, 2, 42);
        posicion_x = posicion_inicial.x;
        posicion_y = 2;
        posicion_z = posicion_inicial.z;
        cant_posiciones = 10;
        posicion_entrada = new Vector3[cant_posiciones];

        Cargar_posiciones();
        asignacion = 0;

        enemy_group = new GameObject[cant_posiciones];
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(tropa)
        {          
            timer += Time.deltaTime;          
            while (i<cant_posiciones && timer > 2.5f)
            {               
                timer = 0;
                i++;
                Create_();
            }
            
            if (i >cant_posiciones)
            {
                tropa = false;
            }
        }
	}

    //Carga Las posiciones iniciales donde se cubren los enemmy
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

    // Asigna a los ennemy la posicion donde se cubren
    public Vector3 Asignar_posicion()
    {
        Vector3 posicion;
        posicion = posicion_entrada[asignacion];
        print(asignacion);
        asignacion++;
        return posicion;

    }

    //Instancia los Ally en la escena
    public void Load_Ally()
    {
        for (int j =0;j< cant_ally;j++)
        {
            string names = "Ally" + j;
            GameObject Ally = Instantiate(Resources.Load("Ally01") as GameObject, transform.position, transform.rotation);
            Ally.transform.position = new Vector3(0+(j*10), 0, 0);
            ally_group[j] = Ally;
            Ally.name = names;
        }
    }

    public Vector3  Assign_Ally()
    {
        Vector3 posocion = new Vector3(0, 0, 0);
       
        for (int j=0; j< cant_ally; j++)
        {
            if (ally_group[j].gameObject.GetComponent<Ally>().attacking == false)
            {
                ally_group[j].gameObject.GetComponent<Ally>().attacking = true;
                posocion = ally_group[j].transform.position;
                break;
            }
           else if(j == (cant_ally-1))
           {
                posocion = ally_group[j].transform.position;
                return posocion;               
           }
        }
        return posocion;
    }


    //Insttancia los enemmy y lo coloca en una matriz
    public void Create_()
    {  	
            GameObject enemy = Instantiate(Resources.Load("Cube") as GameObject, transform.position, transform.rotation);
            enemy_group[otro] = enemy;
            otro++;	
    }

}
