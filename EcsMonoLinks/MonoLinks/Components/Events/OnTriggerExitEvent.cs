using UnityEngine;

namespace Zun010.MonoLinks
{
    public struct OnTriggerExitEvent
    {
        public Collider OtherCollider;
        public GameObject Sender;
    }
}