using UnityEngine;

public class PlayerFluentBuilder
{
    PlayerBuilderData _playerBuilderData = new PlayerBuilderData();

    public PlayerFluentBuilder SetName(string name)
    {
        _playerBuilderData.Name = name;
        return this;
    }
    public PlayerFluentBuilder SetHealth(int health)
    {
        _playerBuilderData.Health = health;
        return this;
    }
    public PlayerFluentBuilder SetSpeed(float speed)
    {
        _playerBuilderData.Speed = speed;
        return this;
    }
    public PlayerBuilderData Build()
    {
        return _playerBuilderData;
    }
}
