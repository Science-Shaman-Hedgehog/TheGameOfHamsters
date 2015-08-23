using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

[RequireComponent(typeof(PlatformerCharacter2D))]
public class CharacterUserControl_PC : MonoBehaviour
{
    [SerializeField] private KeyCode _JumpKey;
    [SerializeField] private KeyCode _CrouchKey;

    private PlatformerCharacter2D _Character;
    private bool _Jump;
    private bool _Crouch;

    private void Awake()
    {
        _Character = GetComponent<PlatformerCharacter2D>();
    }

    private void Update()
    {
        if (!_Jump)
        {
            // Read the jump and crouch input in Update so button presses aren't missed
            _Jump = Input.GetKeyDown(_JumpKey);
            _Crouch = Input.GetKey(_CrouchKey);
        }
    }

    private void FixedUpdate()
    {
        // Read the inputs.
        float h = Input.GetAxis("Horizontal");
        
        // Pass all parameters to the character control script.
        _Character.Move(h, _Crouch, _Jump);
        _Jump = false;
    }
}
