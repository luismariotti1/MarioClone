using System;
using UnityEngine;

namespace Entities.Player
{
    public class MovementController : MonoBehaviour
    {
        private float _movementSpeed = 2f;
        private float _jumpForce = 4f;
        private float _forceScale = 6.25f;
        private Rigidbody2D _rb2D;
        private Boolean _isGrounded = true;
        private float _moveInput;
        public Transform feetPosition;
        public float checkRadius;
        public LayerMask whatIsGrounded;
        private static readonly int AnimMoveX = Animator.StringToHash("AnimMoveX");

        // Start is called before the first frame update
        void Start()
        {
            _rb2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void FixedUpdate() {
            MoveCharacter();
            Jump();
        }
        void Jump()
        {
            _isGrounded = Physics2D.OverlapCircle(feetPosition.position, checkRadius, whatIsGrounded);
            
            if (Input.GetKey("space") && _isGrounded)
            {
                _rb2D.velocity = Vector2.up * (_forceScale * _jumpForce);
            };
        }
        
        void MoveCharacter()
        {
            _moveInput = Input.GetAxisRaw("Horizontal");
            _rb2D.velocity = new Vector2(_moveInput * _forceScale * _movementSpeed, _rb2D.velocity.y);
        }
    }
}
