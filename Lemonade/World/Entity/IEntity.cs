using Lemonade.Net.Protocol;

namespace Lemonade.World.Entity;

public interface IEntity<T>
{
    public int EntityId
    {
        get;
        set;
    }

    public T FromSceneEntityInfo(SceneEntityInfo data);

}