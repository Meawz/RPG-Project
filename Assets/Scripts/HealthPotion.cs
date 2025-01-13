using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public int healAmount = 25;
    public AudioSource pickupSound;
    public float interactRange = 6.0f;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {

                float distance = Vector3.Distance(player.transform.position, transform.position);

                if (distance <= interactRange)
                {
                    CharacterStats characterStats = player.GetComponent<CharacterStats>();
                    if (characterStats != null)
                    {
                        characterStats.Heal(healAmount);

                        if (pickupSound != null)
                        {
                            pickupSound.Play();
                        }

                        Destroy(gameObject);
                    }
                }
                else
                {
                    Debug.Log("Too far!");
                }
            }
        }
    }
}
