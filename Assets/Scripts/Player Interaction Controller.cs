using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerInteractionController : MonoBehaviour
{
    public bool debugEnabled = false;

    private IInteractable targetInteractable;

    [SerializeField]
    private GameObject debugCurrentInteractable;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = foundInteractable;
            debugCurrentInteractable = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = null;
            debugCurrentInteractable = null;
        }
    }




    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (targetInteractable != null)
            {
                if (debugEnabled == true) Debug.Log("Attempting to interact");

                targetInteractable.Interact();
            }

        }

    }
}
