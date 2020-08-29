using NSubstitute;
using NUnit.Framework;
using TransformService;

public class MovementTests
{
    [Test]
    public void Moves_Along_X_Axis_For_Horizontal_Input()
    {
        var inputService = GivenInputService();
        inputService.GetAxisRaw("Horizontal").Returns(1);
        inputService.GetDeltaTime().Returns(1);
        Assert.AreEqual(1,
                        new Movement(1).TopDownCalculateWithoutDirection(1, 0, 1).x);
    }

    [Test]
    public void Moves_Along_Z_Axis_For_Vertical_Input()
    {
        var inputService = GivenInputService();
        inputService.GetAxisRaw("Horizontal").Returns(1);
        inputService.GetDeltaTime().Returns(1);
        Assert.AreEqual(1,
                        new Movement(1).TopDownCalculateWithoutDirection(0, 1, 1).z
                        ,0.1f);
    }

    private static IInputService GivenInputService()
    {
        var unityService = Substitute.For<IInputService>();
        return unityService;
    }
}