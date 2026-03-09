using UnityEngine;

public class InteractionObject : MonoBehaviour, IInteractable
{

    public bool debugEnabled = false;
    

    public void Interact()
    {
      if (debugEnabled)  Debug.Log("Interacted With " + gameObject.name);
    }

    public void Focused()
    {

    }

    public void Unfocused()
    {
       
    }

    
}
