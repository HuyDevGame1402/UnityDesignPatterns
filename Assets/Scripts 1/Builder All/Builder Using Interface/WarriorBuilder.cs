using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBuilder : IPlayerBuilder
{
    PlayerBuilderData _playerBuilderData = new PlayerBuilderData();
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
    public PlayerBuilderData Build()
    {
        return _playerBuilderData;
    }
}
