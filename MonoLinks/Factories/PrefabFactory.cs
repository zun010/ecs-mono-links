using System;
using Leopotam.Ecs;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Zun010.MonoLinks
{
    public sealed class PrefabFactory
    {
        private readonly EcsWorld _world;
        
        public PrefabFactory(EcsWorld world)
        {
            _world = world;
        }
        
        public EcsEntity Spawn(MonoEntity prefab)
        {
            CheckPrefabIsNull(prefab);
            
            var instance = Object.Instantiate(prefab);
            var entity = MakeMonoEntity(instance);

            return entity;
        }
        
        public EcsEntity Spawn(MonoEntity prefab, Transform parent)
        {
            CheckPrefabIsNull(prefab);
            
            var instance = Object.Instantiate(prefab, parent);
            var entity = MakeMonoEntity(instance);

            return entity;
        }
        
        public EcsEntity Spawn(MonoEntity prefab, Vector3 position, Quaternion rotation)
        {
            CheckPrefabIsNull(prefab);
            
            var instance = Object.Instantiate(prefab, position, rotation);
            var entity = MakeMonoEntity(instance);

            return entity;
        }
        
        public EcsEntity Spawn(MonoEntity prefab, Vector3 position, Quaternion rotation, Transform parent)
        {
            CheckPrefabIsNull(prefab);
            
            var instance = Object.Instantiate(prefab, position, rotation, parent);
            var entity = MakeMonoEntity(instance);

            return entity;
        }

        private EcsEntity MakeMonoEntity(MonoEntity monoEntity)
        {
            var entity = _world.NewEntity();
            monoEntity.Make(ref entity);

            return entity;
        }

        private void CheckPrefabIsNull(MonoEntity prefab)
        {
            if (prefab == null)
                throw new ArgumentNullException(nameof(prefab));
        }
    }
}