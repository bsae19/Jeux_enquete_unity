using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    void Start() {
       go=null;
    }
    void OnMouseOver()
    {
         this.GetComponent<Outline>().enabled=true;
    } 

    void OnMouseExit()
    {
         this.GetComponent<Outline>().enabled=false;
    }
}
