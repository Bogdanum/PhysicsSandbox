using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonColliderRay : MonoBehaviour
{
    public TextMesh text;
    private Vector3 localS = new Vector3(3f, 1f, 0.2f);
    private bool OnOff = false;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (GetComponent<Collider>().Raycast(ray, out hit, 100f))
        {
            transform.localScale = localS * 1.2f;

            if (Input.GetMouseButtonDown(0))
            {
                if (!OnOff)
                { GetComponent<Renderer>().material.color = Color.green;
                  text.text = "On"; }
                else
                { GetComponent<Renderer>().material.color = Color.red;
                  text.text = "Off"; }
                OnOff = !OnOff;
            }
        } else
        {
            transform.localScale = localS;
        }
    }
}
