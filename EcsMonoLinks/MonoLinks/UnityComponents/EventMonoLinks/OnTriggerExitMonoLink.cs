using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class OnTriggerExitMonoLink : EventMonoLinkBase
    {
        private void OnTriggerExit(Collider other)
        {
            _entity.Get<OnTriggerExitEvent>() = new OnTriggerExitEvent
            {
                OtherCollider = other,
                Sender = gameObject
            };
        }
    }
}