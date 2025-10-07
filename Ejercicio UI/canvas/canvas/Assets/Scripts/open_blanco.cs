using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openblanco : MonoBehaviour
{
    public GameObject panel_amarillo;
    public GameObject panel_morado;
    public GameObject panel_naranja;
    public GameObject panel_blanco;

    public void OpenPanel()
    {
        if (panel_blanco != null)
        {
            panel_amarillo.SetActive(false);
            panel_blanco.SetActive(true);
            panel_morado.SetActive(false);
            panel_naranja.SetActive(false);
        }
    }
}
