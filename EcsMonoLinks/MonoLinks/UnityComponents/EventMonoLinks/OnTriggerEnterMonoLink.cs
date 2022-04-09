using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class OnTriggerEnterMonoLink : EventMonoLinkBase
    {
        private void OnTriggerEnter(Collider other)
        {
            _entity.Get<OnTriggerEnterEvent>() = new OnTriggerEnterEvent
            {
                OtherCollider = other,
                Sender = gameObject
            };
        }
    }
}