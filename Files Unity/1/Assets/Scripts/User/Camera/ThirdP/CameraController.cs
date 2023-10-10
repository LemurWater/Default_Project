using UnityEngine;

namespace ThirdPersonCamera
{
    public class CameraController : MonoBehaviour
    {
        [Header("Control")]
        [SerializeField] internal bool canRotate = true;
        [SerializeField] private bool firstPerson = false;
        [Space(20)]
        [SerializeField] private float sensitivity = 450.0f;
        [Space(20)]
        [SerializeField] private Transform body;
        [SerializeField] private Transform head;


        [SerializeField] private float springArmLenght = 5.0f;


        float xRotation = 0f;
        public float maxYAngle = 80f;
        private Vector2 currentRotation;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Direction();

            Follow();
            Rotate();
        }

        public void Direction()
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Debug.DrawRay(transform.position, forward, Color.magenta);
        }


        public void Follow()
        {
            transform.position = head.position;
        }
        public void Rotate()
        {
            if (canRotate)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime, 0); ;
                transform.Rotate(-Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime, 0, 0);

                currentRotation.x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
                currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
                currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
                currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);
                transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);


                float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
                float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

                xRotation -= mouseY;
                xRotation = Mathf.Clamp(xRotation, -90f, 90f);
                body.transform.Rotate(Vector3.up * mouseX);

            }
        }

        public void SwapBody(Transform newBody, Transform newHead)
        {
            body = newBody;
            head = newHead;
        }
    }
}