using Helper;
using UnityEngine;

namespace Entities.Player
{
    public class Player : MonoBehaviour
    {
        [System.Serializable]
        public struct PlayerStats
        {
            public float points;
            public float movementSpeed;
            public float jumpForce;
            public float maxJumpForce;
        }
        [SerializeField]
        private PlayerStats stats;

        public PlayerStats getStats()
        {
            return stats;
        }
    }
}
