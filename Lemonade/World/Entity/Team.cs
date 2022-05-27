using System.Collections.Generic;
using Lemonade.Net.Protocol;

namespace Lemonade.World.Entity;

public class Team
{
    public List<Avatar> TeamMembers = new();

    public void FromSceneTeam(SceneTeamUpdateNotify sceneTeamUpdateNotify)
    {
        foreach (var sceneTeamAvatar in sceneTeamUpdateNotify.SceneTeamAvatarList)
        {
            TeamMembers.Add(new Avatar().fromSceneEntityInfo(sceneTeamAvatar.SceneEntityInfo));
        }
    }
    
}