using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class DirectSkinnedMeshRendererMonoLink : MonoLink<SkinnedMeshRendererLink>
    {
        [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;

        public override void Make(ref EcsEntity entity)
        {
            entity.Replace(new SkinnedMeshRendererLink
            {
                SkinnedMeshRenderer = skinnedMeshRenderer
            });
        }
    }
}