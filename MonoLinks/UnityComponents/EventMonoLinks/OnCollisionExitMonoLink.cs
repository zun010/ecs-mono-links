using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class OnCollisionExitMonoLink : EventMonoLinkBase
    {
        private void OnCollisionExit(Collision other)
        {
            _entity.Get<OnCollisionExitEvent>() = new OnCollisionExitEvent
            {
                Collision = other,
                Sender = gameObject
            };
        }
    }
}