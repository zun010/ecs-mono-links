using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public struct OnCollisionEnterEvent
    {
        public Collider Collider;
        public Vector3 Impulse;
        
        public GameObject Sender;
        
        public EcsEntity GetSenderEntity()
        {
            var monoEntity = Sender.GetComponentInParent<MonoEntity>();
            if (!monoEntity)
                throw new MissingComponentException(
                    $"Has no {nameof(MonoEntity)} component with the {nameof(OnTriggerEnterEvent)}.");

            return monoEntity.Entity;
        }
        
        public EcsEntity GetOtherEntity()
        {
            var monoEntity = Collider.GetComponentInParent<MonoEntity>();
            if (!monoEntity)
                throw new MissingComponentException(
                    $"Has no {nameof(MonoEntity)} component with the {nameof(OnTriggerEnterEvent)}.");

            return monoEntity.Entity;
        }
    }
}