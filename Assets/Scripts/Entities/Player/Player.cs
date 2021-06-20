using System;
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

        public Player()
        {
            stats.movementSpeed = 1;
            stats.jumpForce = 3.25f;
            stats.maxJumpForce = 4.25f;
        }
        public PlayerStats getStats()
        {
            return stats;
        }
    }
}
