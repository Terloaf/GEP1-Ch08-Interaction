using UnityEngine;

public class InteractMessage : MonoBehaviour, IInteractable
{
    [Header("Message")]
    [SerializeField] private string message;
    [SerializeField] private UIManager uiManager;

    private void Awake()
    {
        uiManager = ServiceHub.Instance.UIManager;
        if (uiManager == null) Debug.LogError("UIManager not found in ServiceHub. please ensure it is properly set up.");
    }


    public void Interact()
    {
        uiManager.DisplayMessage(message);

        
    }

    public void Focused()
    {

    }

    public void Unfocused()
    {

    }
}
