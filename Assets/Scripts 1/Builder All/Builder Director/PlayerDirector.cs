using UnityEngine;

public class PlayerDirector
{
    public PlayerBuilderData CreateWarrior(PlayerFluentBuilder builder)
    {
        return builder.SetName("Warrior")
            .SetHealth(150)
            .SetSpeed(3f)
            .Build();
    }
    public PlayerBuilderData CreateArcher(PlayerFluentBuilder builder)
    {
        return builder.SetName("Archer")
            .SetHealth(100)
            .SetSpeed(5f)
            .Build();
    }
    public PlayerBuilderData CreateMage(PlayerFluentBuilder builder)
    {
        return builder.SetName("Mage")
            .SetHealth(80)
            .SetSpeed(4f)
            .Build();
    }

    // Builder Interface
    public PlayerBuilderData Construct(IPlayerBuilder builder)
    {
        builder.SetName("Warrior");
        builder.SetHealth(150);
        builder.SetSpeed(3f);
        return builder.Build();
    }
}
