using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class DirectColliderMonoLInk : MonoLink<ColliderLink>
    {
        [SerializeField] private new Collider collider;

        public override void Make(ref EcsEntity entity)
        {
            entity.Replace(new ColliderLink
            {
                Collider = collider
            });
        }
    }
}