using UnityEngine;

namespace Entities.Player
{
    public class AnimationController : MonoBehaviour
    {
        private Animator _anim;
        private Rigidbody2D _rb2D;
        private static readonly int AnimMoveX = Animator.StringToHash("AnimMoveX");

        enum CharStates
        {
            AnimRight = 1,
            AnimLeft = -1,
        }
        // Start is called before the first frame update
        void Start()
        {
            _rb2D = GetComponent<Rigidbody2D>();
            _anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            UpdateState();
        }
        
        private void UpdateState()
        {
            if(_rb2D.velocity.x > 0)
            {
                _anim.SetFloat(AnimMoveX,  (int)CharStates.AnimRight);
            }
            else if(_rb2D.velocity.x<0)
            {
                _anim.SetFloat(AnimMoveX,  (int)CharStates.AnimLeft);
            }
        }
    }
}
