


using UnityEngine;

namespace TransformService
{
    public class Rotation
    {
        private float _speed;

        public Rotation(float rotateSpeed) => _speed = rotateSpeed;

        public Quaternion CalculateSlerpLookRotation(Vector3 position , Vector3 targetPosition , Quaternion rotation, float deltaTime)
        {
            var lookRotation = CalculateLookRotation(position , targetPosition);
            var slerpRotation = Quaternion.Slerp(rotation , lookRotation , _speed * deltaTime);
            return slerpRotation;
        }
        
        public Quaternion CalculateLookRotation(Vector3 position , Vector3 targetPosition )
        {
            targetPosition.y = position.y;
            var direction = targetPosition - position;
            direction.y = 0;
            var lookRotation  = Quaternion.LookRotation(direction);
            return lookRotation;
        }
    }
}