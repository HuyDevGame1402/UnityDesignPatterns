public class IdleState : State
{
    private PlayerStatePattern player;

    public IdleState(PlayerStatePattern player)
    {
        this.player = player;
    }

    public override void Enter()
    {
        player.Animator.Play("Idle");
    }

    public override void Update()
    {
        if (player.HasMoveInput())
        {
            player.StateMachine.ChangeState(player.RunState);
        }
    }

    public override void Exit() { }
}