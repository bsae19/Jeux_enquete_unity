using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    void OnMouseOver()
    {
         this.GetComponent<Outline>().enabled=true;
    } 

    void OnMouseExit()
    {
         this.GetComponent<Outline>().enabled=false;
    }
}
