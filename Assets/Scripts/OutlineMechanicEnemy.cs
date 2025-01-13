
using UnityEngine;

public class OutlineMechanicEnemy : MonoBehaviour
{

    public Color outlineColor = Color.red;
    public float outlineWidth = 6f;

    private void Start()
    {
        GameObject[] Items = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Item in Items)
        {
            if (Item.GetComponent<Outline>() != null)
            {
                Item.AddComponent<Outline>();
                Item.GetComponent<Outline>().enabled = false;
                Item.GetComponent<Outline>().OutlineColor = Color.red;
                Item.GetComponent<Outline>().OutlineWidth = 6f;
            }
            if (Item.GetComponent<OutlineSelect>() == null)
            {
                Item.AddComponent<OutlineSelect>();
            }
            if (Item.GetComponent<MeshRenderer>() == null)
            {
                Item.AddComponent<MeshRenderer>();
            }
        }
    }
}
