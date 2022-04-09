using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class MeshRendererMonoLink : MonoLink<MeshRendererLink>
    {
        public override void Make(ref EcsEntity entity)
        {
            entity.Replace(new MeshRendererLink
            {
                MeshRenderer = GetComponent<MeshRenderer>()
            });
        }
    }
}