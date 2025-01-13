using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentVisibility : MonoBehaviour
{
    public GameObject objectToControl;

    public EquipmentSlot targetSlot = EquipmentSlot.Weapon;

    private void OnEnable()
    {
        EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;
    }

    private void OnDisable()
    {
        EquipmentManager.instance.onEquipmentChanged -= OnEquipmentChanged;
    }

    private void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
    {
        if (objectToControl == null)
        {
            return;
        }
        if (newItem != null && newItem.equipSlot == targetSlot)
        {
            objectToControl.SetActive(true);
        }
        else if (oldItem != null && oldItem.equipSlot == targetSlot)
        {
            objectToControl.SetActive(false);
        }
    }
}
