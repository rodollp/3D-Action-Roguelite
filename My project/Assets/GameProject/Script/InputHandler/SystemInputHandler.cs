using UnityEngine;
using UnityEngine.InputSystem;

public class SystemInputHandler : MonoBehaviour
{
   [SerializeField] private InputActionReference pauseInput;

    public void OnEnable()
    {
        pauseInput.action.Enable();

        pauseInput.action.performed += OnPause;
    }

    public void OnDisable()
    {
        pauseInput.action.Disable();
        pauseInput.action.performed -= OnPause;
    }


    private void OnPause(InputAction.CallbackContext context)
    {
        Debug.Log("ESC 입력 감지");
    }

}
