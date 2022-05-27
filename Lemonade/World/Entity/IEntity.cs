using Lemonade.Net.Protocol;

namespace Lemonade.World.Entity;

public interface IEntity<T>
{
    public int entityId
    {
        get;
        set;
    }

    public T fromSceneEntityInfo(SceneEntityInfo data);

}