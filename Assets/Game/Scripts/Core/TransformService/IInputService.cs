using UnityEngine;

public interface IInputService
{
    float GetDeltaTime();
    float GetAxisRaw(string axisName);
    float GetHorizontal();
    float GetVertical();
}

public abstract class InputService : IInputService
{
    public virtual float GetDeltaTime() => Time.deltaTime;
    public abstract float GetAxisRaw(string axisName);
    public abstract float GetHorizontal();
    public abstract float GetVertical();
}

public class UnityInputService : InputService
{
    public override float GetAxisRaw(string axisName) => Input.GetAxisRaw(axisName);
    public override float GetHorizontal() => GetAxisRaw("Horizontal");
    public override float GetVertical() => GetAxisRaw("Vertical");
}