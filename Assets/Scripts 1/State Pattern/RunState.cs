public class RunState : State
{
    private PlayerStatePattern player;

    public RunState(PlayerStatePattern player)
    {
        this.player = player;
    }

    public override void Enter()
    {
        player.Animator.Play("Run");
    }

    public override void Update()
    {
        player.Move();

        if (!player.HasMoveInput())
        {
            player.StateMachine.ChangeState(player.IdleState);
        }
    }

    public override void Exit() { }
}