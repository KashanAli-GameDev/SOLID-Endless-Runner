using UnityEngine;
using Sirenix.OdinInspector;

public class PlayerMovement : MonoBehaviour
{
    #region Fields and Properties

    [Title("Player Components")]
    [SerializeField] private Rigidbody rb;
    [SerializeField] private InputReader inputReader;

    [Title("Scriptable Objects")]
    [SerializeField] private PlayerAttributesSO playerAttributesSO;

    private Vector3 _movementInput;
    private bool _isGrounded = false;

    #endregion

    #region Unity Functions

    private void OnEnable()
    {
        inputReader.JumpEvent += JumpPlayer;
    }

    private void OnDisable()
    {
        inputReader.JumpEvent -= JumpPlayer;
    }

    private void FixedUpdate()
    {
        MovePlayer(inputReader.HorizontalMoveValue);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(StringUtility.GroundTag))
        {
            _isGrounded = true;
        }
    }

    #endregion

    private void MovePlayer(float horizontalInput)
    {
        _movementInput = Vector3.right * horizontalInput * playerAttributesSO.Speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + _movementInput);
    }

    private void JumpPlayer()
    {
        if (_isGrounded)
        {
            rb.AddForce(Vector3.up * playerAttributesSO.JumpForce, ForceMode.Impulse);
            _isGrounded = false;
        }
    }
}
