using UnityEngine;

namespace Helper
{
        [System.Serializable]
        public class Stat
        {
                [SerializeField]
                private float stat;

                public float getStat()
                {
                        return stat;
                }
        }
}
