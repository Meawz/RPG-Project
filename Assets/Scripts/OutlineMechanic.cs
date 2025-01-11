
using UnityEngine;

public class OutlineMechanic : MonoBehaviour
{
    private void Start()
    {
        GameObject[] Items = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject Item in Items)
        {
            if (Item.GetComponent<Outline>() != null)
            {
                Item.AddComponent<Outline>();
                Item.GetComponent<Outline>().enabled = false;
                Item.GetComponent<Outline>().OutlineColor = Color.white;
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
