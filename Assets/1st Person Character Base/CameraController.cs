using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public float sensitivity;
    public Transform playerBody;

    public bool left = false;
    public bool right = false;

    [SerializeField]
    private InputActionReference cameraControl;




    private float XAxisRotation = 0.0f;

    private Vector2 mouse;


    private void OnEnable()
    {
        cameraControl.action.Enable();





    }

    private void OnDisable()
    {
        cameraControl.action.Disable();



    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenuController.GameIsPaused)
        {
            Vector2 camera = cameraControl.action.ReadValue<Vector2>();

            mouse.x = camera.x * sensitivity;
            mouse.y = camera.y * sensitivity;

            // Look up and down

            if (!right)
            {
                XAxisRotation -= mouse.y;
            }
            else
            {
                XAxisRotation -= -mouse.y;
            }



            XAxisRotation = Mathf.Clamp(XAxisRotation, -90.0f, 90.0f);
            transform.localRotation = Quaternion.Euler(XAxisRotation, 0.0f, 0.0f);

            // Look left and right and rotate around the Y Axis
            if (!left)
            {
                playerBody.Rotate(Vector3.up * mouse.x);
            }
            else
            {
                playerBody.Rotate(Vector3.up * -mouse.x);

            }
        }
    }
}
