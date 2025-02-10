using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputReader : MonoBehaviour
{
    public event Action JumpEvent;
    public float HorizontalMoveValue;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {  
            JumpEvent?.Invoke();
        }

        /// Store Current Horizontal Value.
        HorizontalMoveValue = Input.GetAxis("Horizontal") != 0 ? Input.GetAxis("Horizontal") : 0;
    }
}
