using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openmorado : MonoBehaviour
{
    public GameObject panel_amarillo;
    public GameObject panel_morado;
    public GameObject panel_naranja;
    public GameObject panel_blanco;

    public void OpenPanel()
    {
        if (panel_amarillo != null)
        {
            panel_amarillo.SetActive(true);
            panel_blanco.SetActive(false);
            panel_morado.SetActive(false);
            panel_naranja.SetActive(false);
        }
    }
}
