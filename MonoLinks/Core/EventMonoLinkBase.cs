using Leopotam.Ecs;

namespace Zun010.MonoLinks
{
    public class EventMonoLinkBase : MonoLinkBase
    {
        protected EcsEntity _entity;
        
        public override void Make(ref EcsEntity entity)
        {
            _entity = entity;
        }
    }
}