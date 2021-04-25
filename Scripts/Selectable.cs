using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{

    public void Select()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }

    public void DeSelect()
    {
        GetComponent<Renderer>().material.color = Color.gray;
    }
}
