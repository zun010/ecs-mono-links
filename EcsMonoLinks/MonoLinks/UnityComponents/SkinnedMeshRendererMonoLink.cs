using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class SkinnedMeshRendererMonoLink : MonoLink<SkinnedMeshRendererLink>
    {
        public override void Make(ref EcsEntity entity)
        {
            entity.Replace(new SkinnedMeshRendererLink
            {
                SkinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>()
            });
        }
    }
}