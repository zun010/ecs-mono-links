using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class OnTriggerExit2DMonoLink : EventMonoLinkBase
    {
        private void OnTriggerExit2D(Collider2D other)
        {
            _entity.Get<OnTriggerExit2DEvent>() = new OnTriggerExit2DEvent
            {
                OtherCollider = other,
                Sender = gameObject
            };
        }
    }
}