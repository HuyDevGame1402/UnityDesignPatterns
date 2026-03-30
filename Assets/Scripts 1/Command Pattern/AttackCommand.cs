public class AttackCommand : ICommand
{
    private PlayerCommand _player;

    public AttackCommand(PlayerCommand player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.Attack();
    }
}