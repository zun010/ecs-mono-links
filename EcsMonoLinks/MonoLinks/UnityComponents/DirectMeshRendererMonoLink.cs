using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class DirectMeshRendererMonoLink : MonoLink<MeshRendererLink>
    {
        [SerializeField] private MeshRenderer meshRenderer;

        public override void Make(ref EcsEntity entity)
        {
            entity.Replace(new MeshRendererLink
            {
                MeshRenderer = meshRenderer
            });
        }
    }
}