using UnityEngine;

public class PlayerBuilderLogic
{
    private PlayerBuilderData _playerBuilderData = new PlayerBuilderData();

    public void SetName(string name)
    {
        _playerBuilderData.Name = name;
    }
    public void SetHealth(int health)
    {
        _playerBuilderData.Health = health;
    }
    public void SetSpeed(float speed)
    {
        _playerBuilderData.Speed = speed;
    }
    public PlayerBuilderData Builder()
    {
        return _playerBuilderData;
    }
}
