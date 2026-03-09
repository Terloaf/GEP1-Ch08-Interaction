using UnityEngine;

public class InteractablePickUp : MonoBehaviour, IInteractable
{
    public bool debugEnabled = false;


    public void Interact()
    {
        if (debugEnabled) Debug.Log("Interacted With " + gameObject.name);
        Destroy(gameObject);
    }

    public void Focused()
    {

    }

    public void Unfocused()
    {

    }


}
