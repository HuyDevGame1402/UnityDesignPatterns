using UnityEngine;

public class PlayerDirectorGame : MonoBehaviour
{
    [Header("Builder Fluent Director")]
    [SerializeField] PlayerBuilderData _playerWarrior;
    [SerializeField] PlayerBuilderData _playerArcher;

    [Header("Builder Interface Director")]
    [SerializeField] PlayerBuilderData _playerWarriorUsingInterface;  
    


    private void Start()
    {
        PlayerDirector director = new PlayerDirector();
        _playerWarrior = director.CreateWarrior(new PlayerFluentBuilder());
        _playerArcher = director.CreateArcher(new PlayerFluentBuilder());

        // Using Builder Interface
        _playerWarriorUsingInterface = director.Construct(new WarriorBuilder());
    }
}
