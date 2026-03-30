using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CommandInvoker _invoker = new CommandInvoker();
    private PlayerCommand _player;

    private void Awake()
    {
        _player = GetComponent<PlayerCommand>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _invoker.AddCommand(new AttackCommand(_player));
        }
    }
}
