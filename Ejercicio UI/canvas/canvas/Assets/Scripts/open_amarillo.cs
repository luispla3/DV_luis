using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openamarillo : MonoBehaviour
{
    public GameObject panel_amarillo;
    public GameObject panel_morado;
    public GameObject panel_naranja;
    public GameObject panel_blanco;

    public void OpenPanel()
    {
        if (panel_morado != null)
        {
            panel_amarillo.SetActive(false);
            panel_blanco.SetActive(false);
            panel_morado.SetActive(true);
            panel_naranja.SetActive(false);
        }
    }
}
