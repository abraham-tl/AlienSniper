using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemmy : Util {
    public bool attack;
    public bool enemmy;
    public Vector3 pos_enemmy;
	// Use this for initialization
	void Start () {
        attack = false;
        enemmy = false;

        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (attack)
        {
            if (enemmy)
            {

            }
            else
            {
                //pos_enemmy = Assign_Ally();
                //enemmy = true;
            }
        }
    }
}
