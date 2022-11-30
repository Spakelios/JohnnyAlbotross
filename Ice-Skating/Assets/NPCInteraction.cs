using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public GameObject GameManager, GM2, GM3;
    public GameObject Textbox;
    public GameObject InteractButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.SetActive(true);
            GM2.SetActive(false);
            GM3.SetActive(false);
            InteractButton.SetActive(true);
        }
        else
        {
            GameManager.SetActive(false);
            InteractButton.SetActive(false);
            Textbox.SetActive(false);
            GM2.SetActive(false);
            GM3.SetActive(false);
        } 
        
    }

    private void Update()
    {
        if (InteractButton == isActiveAndEnabled)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                InteractButton.SetActive(false);
                Textbox.SetActive(true);
            }
            
        }
    }
}
