using System.Numerics;

namespace LostOasisLibrary
{
    namespace UnityEngine
    {
        namespace InputSystem
        {
            public class Input
            {
                public Vector2 startPosition { get; private set; }
                public Vector2 position { get; private set; }
                public Vector2 deltaPosition { get; private set; }
                public Input(Vector2 startPosition)
                {
                    this.startPosition = startPosition;
                }
                public float Length => Vector2.Distance(startPosition, position);
                public float Angle => Convert.ToSingle(Math.Atan2(position.Y - startPosition.Y, position.X - startPosition.X) * (180 / Math.PI));
                public static float Distance(Input start, Input end)
                {
                    return Vector2.Distance(start.position, end.position);
                }
            }
        }
    }
}
