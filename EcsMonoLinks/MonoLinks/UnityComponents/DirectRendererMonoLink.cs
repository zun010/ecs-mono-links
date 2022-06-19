using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.MonoLinks
{
    public sealed class DirectRendererMonoLink : MonoLink<RendererLink>
    {
        [SerializeField] private new Renderer renderer;
        
        public override void Make(ref EcsEntity entity)
        {
            entity.Replace(new RendererLink
            {
                Renderer = renderer
            });
        }
    }
}