using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_menu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
    RectTransform objet=this.GetComponent<RectTransform>();
    objet.sizeDelta = new Vector2(Screen.width, Screen.height);
    objet.position = new Vector3(Screen.width/2,Screen.height/2,0);
    }
}
