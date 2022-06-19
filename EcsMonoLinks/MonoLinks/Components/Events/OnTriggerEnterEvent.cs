using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public struct OnTriggerEnterEvent
    {
        public Collider OtherCollider;
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
            var monoEntity = OtherCollider.GetComponentInParent<MonoEntity>();
            if (!monoEntity)
                throw new MissingComponentException(
                    $"Has no {nameof(MonoEntity)} component with the {nameof(OnTriggerEnterEvent)}.");

            return monoEntity.Entity;
        }
    }
}