using UnityEngine;

public class PlayerBuildGame : MonoBehaviour
{
    PlayerBuilderLogic _playerBuilderLogic;
    [SerializeField] PlayerBuilderData _playerBuilderData;
    void Start()
    {
        _playerBuilderLogic = new PlayerBuilderLogic();
        _playerBuilderLogic.SetName("Player1");
        _playerBuilderLogic.SetHealth(100);
        _playerBuilderLogic.SetSpeed(5f);
        _playerBuilderData = _playerBuilderLogic.Builder();
        
        // Debug Game Data
        /* Debug.Log("Player Name: " + _playerBuilderData.Name);
        Debug.Log("Player Health: " + _playerBuilderData.Health);
        Debug.Log("Player Speed: " + _playerBuilderData.Speed); */
    }
}
