using UnityEngine;

internal class InputListener : MonoBehaviour
{
    Hotkeys hotkeys;
    MenuManager menuManager;
    FirstAndThirdPersonCamera.CameraController FTPCamera;
    //ThirdPersonCamera.CameraController TPCamera;
    //FirstPersonCamera.CameraController FPCamera;
    //RTSCamera.CameraController RTSCAmera;


    // Start is called before the first frame update
    void Start()
    {
        hotkeys = GameObject.FindObjectOfType<Hotkeys>();
        menuManager = GameObject.FindObjectOfType<MenuManager>();
        FTPCamera = GameObject.FindAnyObjectByType<FirstAndThirdPersonCamera.CameraController>();
        //TPCamera = GameObject.FindAnyObjectByType<ThirdPersonCamera.CameraController>();
        //FPCamera = GameObject.FindAnyObjectByType<FirstPersonCamera.CameraController>();
        //RTSCAmera = GameObject.FindAnyObjectByType<RTSCamera.CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        Menu();
    }

    void Menu()
    {
        if (Input.GetKeyDown(hotkeys.MenuMain))
        {
            if (menuManager.MainMenu())
            {
                FTPCamera.canRotate = false;
            }
            else
            {
                FTPCamera.canRotate = true;
            }
        }
    }
}
