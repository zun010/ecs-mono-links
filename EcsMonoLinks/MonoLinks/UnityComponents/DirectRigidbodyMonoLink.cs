using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class DirectRigidbodyMonoLink : MonoLink<RigidbodyLink>
    {
        [SerializeField] private new Rigidbody rigidbody;

        public override void Make(ref EcsEntity entity)
        {
            entity.Replace(new RigidbodyLink
            {
                Rigidbody = rigidbody
            });
        }
    }
}