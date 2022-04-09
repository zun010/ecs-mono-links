using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public abstract class MonoLinkBase : MonoBehaviour
    {
        public abstract void Make(ref EcsEntity entity);
    }
}