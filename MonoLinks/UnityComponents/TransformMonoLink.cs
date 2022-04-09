using Leopotam.Ecs;

namespace Zun010.MonoLinks
{
    public sealed class TransformMonoLink: MonoLink<GameObjectLink>
    {
        public override void Make(ref EcsEntity entity)
        {
            entity.Get<TransformLink>() = new TransformLink
            {
                Transform = transform
            };
        }
    }
}