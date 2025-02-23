using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;

    bool isFocus = false;
    Transform player;

    bool hasInteracted = false;

    public virtual void Interact ()
    {
        // This method is meant to be overwritten
        // Debug.Log("Interacting with " + transform.name);
    }

    void Update ()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    public void OnFocused (Transform playerTransfrom)
    {
        isFocus = true;
        player = playerTransfrom;
        hasInteracted = false;
    }

    public void OnDefocused ()
    {
        isFocus=false;
        player = null;
        hasInteracted = false;
    }

    void OnDrawGizmosSelected ()
    {
        if (interactionTransform == null)
            interactionTransform = transform;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
