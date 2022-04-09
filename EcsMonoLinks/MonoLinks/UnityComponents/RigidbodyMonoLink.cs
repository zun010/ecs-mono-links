using Leopotam.Ecs;
using UnityEngine;
using Zun010.MonoLinks;

namespace Zun010.MonoLinks
{
    public sealed class RigidbodyMonoLink : MonoLink<RigidbodyLink>
    {
        public override void Make(ref EcsEntity entity)
        {
            entity.Get<RigidbodyLink>() = new RigidbodyLink
            {
                Rigidbody = GetComponent<Rigidbody>()
            };
        }
    }
}