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

    private void Awake()
    {
        _Character = GetComponent<PlatformerCharacter2D>();
    }

    private void Update()
    {
        if (!_Jump)
        {
            // Read the jump input in Update so button presses aren't missed
            _Jump = Input.GetKeyDown(_JumpKey);
        }
    }

    private void FixedUpdate()
    {
        // Read the inputs.
        bool crouch = Input.GetKey(_CrouchKey);
        float h = Input.GetAxis("Horizontal");
        // Pass all parameters to the character control script.
        _Character.Move(h, crouch, _Jump);
        _Jump = false;
    }
}
