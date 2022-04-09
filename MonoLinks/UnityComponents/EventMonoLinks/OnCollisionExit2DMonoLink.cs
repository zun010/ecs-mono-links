using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class OnCollisionExit2DMonoLink : EventMonoLinkBase
    {
        private void OnCollisionExit2D(Collision2D other)
        {
            _entity.Get<OnCollisionExit2DEvent>() = new OnCollisionExit2DEvent
            {
                Collision2D = other,
                Sender = gameObject
            };
        }
    }
}