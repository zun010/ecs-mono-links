using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class RendererMonoLink : MonoLink<RendererLink>
    {
        public override void Make(ref EcsEntity entity)
        {
            entity.Replace(new RendererLink
            {
                Renderer = GetComponent<Renderer>()
            });
        }
    }
}