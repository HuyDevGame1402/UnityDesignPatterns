public interface IPlayerBuilder
{
    void SetName(string name);  
    void SetHealth(int health);
    void SetSpeed(float speed);
    PlayerBuilderData Build();
}
