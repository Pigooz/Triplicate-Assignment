using UnityEngine;
using UnityEngine.InputSystem;

public class AttackLogger : MonoBehaviour
{
    public InputAction attack;

    private void OnEnable()
    {
        attack.Enable();
        attack.performed += OnAttackPerformed;
    }

    private void OnDisable()
    {
        attack.performed -= OnAttackPerformed;
        attack.Disable();
    }

    private void OnAttackPerformed(InputAction.CallbackContext context)
    {
        Debug.Log("Attack!!!");
    }
}

