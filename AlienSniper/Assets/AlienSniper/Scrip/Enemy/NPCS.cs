﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCS : MonoBehaviour {
    public Vector3 [] pos_enemy;
    
    public float speed;
    public float timeMax;
    public float timeRun;
    int i;
    public int cant_pos;
    private void Start()
    {
        cant_pos = 10;
        pos_enemy = new Vector3[cant_pos];
        timeMax = Random.Range(1,5);
        speed = Random.Range(1,5);
    }
    void Update () {
        timeRun += Time.deltaTime;
        if (timeRun >= timeMax)
        {
            i = Random.Range(0, 5);
            timeRun = 0;
        }

        switch (i)
        {
            case 0:
                transform.position += transform.forward * speed * Time.deltaTime;
                break;
            case 1:
                transform.position -= transform.forward * speed * Time.deltaTime;
                break;
            case 2:
                transform.position += transform.right * speed * Time.deltaTime;
                break;
            case 3:
                transform.position -= transform.right * speed * Time.deltaTime;
                break;
            default:
                break;
        }
    }
}