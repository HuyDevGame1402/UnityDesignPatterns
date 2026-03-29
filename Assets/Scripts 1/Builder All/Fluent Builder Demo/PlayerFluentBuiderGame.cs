using UnityEngine;

public class PlayerFluentBuiderGame : MonoBehaviour
{
    [SerializeField] PlayerBuilderData _playerBuilderData;
    void Start()
    {
        _playerBuilderData = new PlayerFluentBuilder()
            .SetName("Fluent Builder Player")
            .SetHealth(150)
            .SetSpeed(5.5f)
            .Build();
    }
    
}
