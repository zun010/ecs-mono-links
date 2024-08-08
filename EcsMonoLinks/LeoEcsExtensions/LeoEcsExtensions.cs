using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.LeoEcsExtensions
{
    public static class LeoEcsExtensions
    {
        public static bool TryGet<T>(this EcsEntity entity, out T component)
            where T : struct
        {
            if (!entity.Has<T>())
            {
                component = default;
                return false;
            }

            component = entity.Get<T>();

            return true;
        }

        public static EcsEntity NewEntityWith<T>(this EcsWorld world)
            where T : struct
        {
            var entity = world.NewEntity();
            entity.Get<T>();

            return entity;
        }

        public static EcsEntity NewEntityWith<T>(this EcsWorld world, T component)
            where T : struct
        {
            var entity = world.NewEntity();
            entity.Replace(component);

            return entity;
        }
        
        public static ref T Req<T>(this in EcsEntity entity)
            where T : struct
        {
            if (!entity.Has<T>())
                throw new MissingComponentException($"Entity has no {typeof(T)} component.");

            return ref entity.Get<T>();
        }
    }
}
