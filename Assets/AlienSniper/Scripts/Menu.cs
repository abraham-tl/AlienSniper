using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Image fondo;
    public GameObject fondoG;
    public GameObject play;
    public bool activo;
    public int rango;

    private void Start()
    {
        activo = false;
    }
    void Update () {
        MenuGame();
    }
    public void MenuGame()
    {
        if (activo)
        {
            fondoG.SetActive(true);
            fondo.fillAmount += 5 * Time.deltaTime;
        }
        else
        {
            fondo.fillAmount -= 5 * Time.deltaTime;
        }

        if (fondo.fillAmount == 1)
        {
            play.SetActive(true);
        }
        else if (fondo.fillAmount == 0)
        {
            fondoG.SetActive(false);
            play.SetActive(false);
        }
    }
}
