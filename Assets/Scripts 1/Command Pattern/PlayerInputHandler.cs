using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerCommand _player;

    void Awake()
    {
        _player = GetComponent<PlayerCommand>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ICommand cmd = new AttackCommand(_player);
            cmd.Execute();
        }
    }
}
