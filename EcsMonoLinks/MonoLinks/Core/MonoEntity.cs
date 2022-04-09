using Leopotam.Ecs;

namespace Zun010.MonoLinks
{
    public sealed class MonoEntity : MonoLinkBase
    {
        public EcsEntity Entity => _entity;

        private EcsEntity _entity;
        
        private MonoLinkBase[] _monoLinks;

        public MonoLink<T> Get<T>()
            where T : struct
        {
            foreach (var link in _monoLinks)
            {
                if (link is MonoLink<T> monoLink)
                    return monoLink;
            }

            // todo: mb return not null?
            return null;
        }

        public override void Make(ref EcsEntity entity)
        {
            _entity = entity;
            
            _monoLinks = GetComponents<MonoLinkBase>();
            foreach (var link in _monoLinks)
            {
                if (link is MonoEntity)
                    continue;
                
                link.Make(ref entity);
            }
        }
    }
}