using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class node : MonoBehaviour {


     
    private GameObject turret;
    private Renderer rend;
    public Color hoverColor;
    private Color startColor;
    void Start ()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("cant build there!");
            return;
        }
        GameObject turretToBuild = buildManeger.instance.GetTurrrtToBuild();
        turret =(GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
    }
    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }


    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}

     