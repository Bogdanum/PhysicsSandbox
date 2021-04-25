using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRay : MonoBehaviour
{
    private Selectable currentSelectable;

    private void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (selectable)
            {
                if (currentSelectable && currentSelectable != selectable)
                {
                    currentSelectable.DeSelect();
                }
                currentSelectable = selectable;
                selectable.Select();
            } else
            {
                if (currentSelectable)
                {
                    currentSelectable.DeSelect();
                    currentSelectable = null;
                }
            }
        }
        else
        {
            if (currentSelectable)
            {
                currentSelectable.DeSelect();
                currentSelectable = null;
            }
        }

    }
}
