using Leopotam.Ecs;
using Zun010.MonoLinks;

namespace Zun010.MonoLinks
{
    public sealed class GameObjectMonoLink : MonoLink<GameObjectLink>
    {
        public override void Make(ref EcsEntity entity)
        {
            entity.Get<GameObjectLink>() = new GameObjectLink
            {
                GameObject = gameObject
            };
        }
    }
}