using TransformService;
using UnityEngine;

namespace FGJ2020_Team3
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private float             moveSpeed = 3;
        private                  UnityInputService _unityInputService;
        private                  Movement          _movement;
        private                  Transform         _transform;
        

        private void Start()
        {
            _unityInputService = new UnityInputService();
            _movement          = new Movement(moveSpeed);
            _transform         = transform;
        }

        private void Update()
        {
            var moveVector = 
                _movement.TwoDCalculateWithoutDirection(_unityInputService.GetHorizontal() ,
                                                           _unityInputService.GetVertical() ,
                                                           _unityInputService.GetDeltaTime());
            _transform.position += moveVector;
        }
    }
}