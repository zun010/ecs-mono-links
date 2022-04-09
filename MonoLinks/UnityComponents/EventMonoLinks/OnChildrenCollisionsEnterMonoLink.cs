using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class OnChildrenCollisionsEnterMonoLink : EventMonoLinkBase
    {
        private bool _isSended;
        
        private void LateUpdate()
        {
            _isSended = false;
        }

        public override void Make(ref EcsEntity entity)
        {
            base.Make(ref entity);

            var childrenColliders = GetComponentsInChildren<Collider>();
            foreach (var collider in childrenColliders)
            {
                var gameObject = collider.gameObject;
                
                var childCollisionTracker = gameObject.AddComponent<ChildCollisionTracker>();
                childCollisionTracker.SetMonoLink(this);
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            SendEvent(other);
        }

        private void SendEvent(Collision other)
        {
            if (_isSended)
                return;
            
            _entity.Get<OnCollisionEnterEvent>() = new OnCollisionEnterEvent
            {
                Collider = other.collider,
                Impulse = other.impulse,
                Sender = gameObject
            };
            
            _isSended = true;
        }
        
        private sealed class ChildCollisionTracker : MonoBehaviour
        {
            private OnChildrenCollisionsEnterMonoLink _monoLink;

            public void SetMonoLink(OnChildrenCollisionsEnterMonoLink monoLink)
            {
                _monoLink = monoLink;
            }
            
            private void OnCollisionEnter(Collision other)
            {
                _monoLink.SendEvent(other);
            }
        }
    }
}