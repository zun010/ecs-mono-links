using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class OnCollisionEnterMonoLink : EventMonoLinkBase
    {
        private void OnCollisionEnter(Collision other)
        {
            _entity.Get<OnCollisionEnterEvent>() = new OnCollisionEnterEvent
            {
                Collider = other.collider,
                Impulse = other.impulse,
                Sender = gameObject
            };
        }
    }
}