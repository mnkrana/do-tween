using UnityEngine;

namespace Tutorial.Why
{
    public class Move : MonoBehaviour
    {
        [SerializeField] private float speed;

        [SerializeField] private float yMax, yMin;

        private bool _goingUp;

        void Update()
        {
            var pos = transform.position;
            if(pos.y < yMax && _goingUp)
            {
                pos.y += Time.deltaTime * speed;
            }
            else if(pos.y > yMin && !_goingUp)
            {
                pos.y -= Time.deltaTime * speed;
            }

            if(pos.y >= yMax)
            {
                _goingUp = false;
            }
            else if(pos.y <= yMin)
            {
                _goingUp = true;
            }

            transform.position = pos;
        }
    }
}