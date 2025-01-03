using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHoverRaycast : MonoBehaviour
{

    public GameObject healthBar;

    // Start is called before the first frame update
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.transform == transform)
            {
                healthBar.SetActive(true);
                return;
            }
        }
        healthBar.SetActive(false);
    }
}
