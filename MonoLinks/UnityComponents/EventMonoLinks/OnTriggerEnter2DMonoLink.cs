using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class OnTriggerEnter2DMonoLink : EventMonoLinkBase
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            _entity.Get<OnTriggerEnter2DEvent>() = new OnTriggerEnter2DEvent
            {
                OtherCollider = other,
                Sender = gameObject
            };
        }
    }
}