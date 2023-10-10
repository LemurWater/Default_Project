using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private GameObject background;
    private TextMeshProUGUI title;
    private GameObject options;


    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.Find("Menu Background");
        title = GameObject.Find("Menu Title").GetComponent<TextMeshProUGUI>();

        options = GameObject.Find("-Options-");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool MainMenu()
    {
        if (options.activeInHierarchy == false)
        {
            options.SetActive(true);
            background.SetActive(true);
            title.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            return true;
        }
        else
        {
            options.SetActive(false);
            background.SetActive(false);
            title.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            return false;
        }
    }
}
