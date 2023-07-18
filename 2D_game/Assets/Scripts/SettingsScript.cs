using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    public GameObject PanelSet;
    void Start()
    {

    }


    public void PanelSettings()
    {
        PanelSet.SetActive(true);
    }

    public void PanelSessingsFalse()
    {
        PanelSet.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PanelSet.SetActive(false);
        }
    }
}
