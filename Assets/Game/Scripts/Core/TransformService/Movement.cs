using UnityEngine;

namespace TransformService
{
    public class Movement
    {
        private float _speed;

        public Movement(float speed) => _speed = speed;

        public Vector3 TopDownCalculateWithoutDirection(float h , float v , float deltaTime)
        {
            var x = h * _speed * deltaTime;
            var z = v * _speed * deltaTime;

            return new Vector3(x , 0 , z);
        }
        
        public Vector3 TwoDCalculateWithoutDirection(float h , float v , float deltaTime)
        {
            var x = h * _speed * deltaTime;
            var y = v * _speed * deltaTime;

            return new Vector3(x , y ,0);
        }

        public Vector3 CaculateTowards(float deltaTime , Vector3 currentPosition , Vector3 targetPosition)
        {
            // 朝著目標前進
            float step        = _speed * deltaTime;
            var   moveTowards = Vector3.MoveTowards(currentPosition, targetPosition, step);
            return moveTowards;
        }
    }
}