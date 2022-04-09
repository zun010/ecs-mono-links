using UnityEngine;

namespace Zun010.MonoLinks
{
    public struct OnCollisionEnterEvent
    {
        public Collider Collider;
        public Vector3 Impulse;
        
        public GameObject Sender;
    }
}