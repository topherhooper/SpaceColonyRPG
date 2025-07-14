using UnityEngine;

namespace SpaceColonyRPG.Colony
{
    public class RTSCameraController : MonoBehaviour
    {
        [Header("Movement Settings")]
        public float moveSpeed = 20f;
        public float edgeScrollSpeed = 15f;
        public float edgeBorderThickness = 10f;

        [Header("Zoom Settings")]
        public float zoomSpeed = 500f;
        public float minHeight = 10f;
        public float maxHeight = 50f;

        [Header("Bounds")]
        public Vector2 mapBoundsMin = new Vector2(-45, -45);
        public Vector2 mapBoundsMax = new Vector2(45, 45);

        private Camera cam;
        private Vector3 targetPosition;

        void Start()
        {
            cam = GetComponent<Camera>();
            targetPosition = transform.position;

            // Set initial position
            transform.position = new Vector3(0, 30, -20);
            transform.rotation = Quaternion.Euler(45, 0, 0);
        }

        void Update()
        {
            HandleMovement();
            HandleZoom();
            ClampPosition();
        }

        void HandleMovement()
        {
            Vector3 moveDir = Vector3.zero;

            // Keyboard input
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                moveDir.z += 1;
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                moveDir.z -= 1;
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                moveDir.x -= 1;
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                moveDir.x += 1;

            // Edge scrolling
            Vector3 mousePos = Input.mousePosition;
            if (mousePos.x <= edgeBorderThickness)
                moveDir.x -= 1;
            if (mousePos.x >= Screen.width - edgeBorderThickness)
                moveDir.x += 1;
            if (mousePos.y <= edgeBorderThickness)
                moveDir.z -= 1;
            if (mousePos.y >= Screen.height - edgeBorderThickness)
                moveDir.z += 1;

            // Apply movement
            moveDir.Normalize();
            targetPosition += moveDir * moveSpeed * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 10f);
        }

        void HandleZoom()
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            if (scroll != 0)
            {
                targetPosition.y -= scroll * zoomSpeed * Time.deltaTime;
                targetPosition.y = Mathf.Clamp(targetPosition.y, minHeight, maxHeight);
            }
        }

        void ClampPosition()
        {
            targetPosition.x = Mathf.Clamp(targetPosition.x, mapBoundsMin.x, mapBoundsMax.x);
            targetPosition.z = Mathf.Clamp(targetPosition.z, mapBoundsMin.y, mapBoundsMax.y);
        }
    }
}
