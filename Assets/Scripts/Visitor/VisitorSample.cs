using UnityEngine;

namespace DesignPatternSample.Visitor
{
    public class VisitorSample : MonoBehaviour
    {
        void Start()
        {
            Robot robot = new Robot();
            UpdateVisitor visitor = new UpdateVisitor();
            robot.Run();
            robot.Update(visitor);
            robot.Run();
        }
    }
}