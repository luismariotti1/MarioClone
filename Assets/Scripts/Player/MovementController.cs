using System;
using UnityEngine;

namespace Assets.Scripts.Entities.Player
{
    public class MovementController : MonoBehaviour
    {
        private float _movementSpeed = 2f;
        private float _forceScale = 6.25f;
        private Vector2 _movement = new Vector2();
        private Rigidbody2D _rb2D;

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

        private void Jump()
        {
            if (Input.GetKey("space"))
            {
                print(Physics.gravity.y * _forceScale * -2);
                _rb2D.AddForce(new Vector2(0, Physics.gravity.y * _forceScale * -2), ForceMode2D.Impulse);
            };
        }
        
        private void MoveCharacter(){
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.Normalize();
            _rb2D.velocity = _movement * (_forceScale * _movementSpeed);
        }

    }
}
