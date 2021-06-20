using System;
using UnityEngine;

namespace Entities.Player
{
    public class MovementController : MonoBehaviour
    { 
        private float _forceScale = 6.25f;
        private float _moveInput;
        public float checkRadius;
        private Rigidbody2D _rb2D;
        private Boolean _isGrounded = true;
        public Transform feetPosition;
        public LayerMask whatIsGrounded;
        private Animator _anim;
        private Player _player;
        private static readonly int AnimMoveX = Animator.StringToHash("AnimMoveX");
        private static readonly int IsWalking = Animator.StringToHash("IsWalking");

        // Start is called before the first frame update
        void Start()
        {
            _player = GetComponent<Player>();
            _rb2D = GetComponent<Rigidbody2D>();
            _anim = GetComponent<Animator>();
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
                _rb2D.velocity = Vector2.up * (_forceScale * _player.getStats().jumpForce);
            };
        }
        
        void MoveCharacter()
        {
            _moveInput = Input.GetAxisRaw("Horizontal");
            _rb2D.velocity = new Vector2(_moveInput * _forceScale * _player.getStats().movementSpeed, _rb2D.velocity.y);
            _anim.SetBool(IsWalking, _moveInput != 0);
        }
    }
}
