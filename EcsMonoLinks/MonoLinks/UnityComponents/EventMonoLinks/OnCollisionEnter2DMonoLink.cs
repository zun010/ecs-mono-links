using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class OnCollisionEnter2DMonoLink : EventMonoLinkBase
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            _entity.Get<OnCollisionEnter2DEvent>() = new OnCollisionEnter2DEvent
            {
                Collision2D = other,
                Sender = gameObject
            };
        }
    }
}