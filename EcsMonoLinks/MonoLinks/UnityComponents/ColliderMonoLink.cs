using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class ColliderMonoLink : MonoLink<ColliderLink>
    {
        public override void Make(ref EcsEntity entity)
        {
            entity.Replace(new ColliderLink
            {
                Collider = GetComponent<Collider>()
            });
        }
    }
}