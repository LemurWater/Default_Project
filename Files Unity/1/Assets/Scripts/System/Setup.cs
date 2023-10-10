using TMPro;
using UnityEngine;

internal class Setup : MonoBehaviour
{
    TextMeshProUGUI build;
    GameInfo gameInfo;


    // Start is called before the first frame update
    void Start()
    {
        gameInfo = GetComponent<GameInfo>();
        build = GameObject.Find("Build Info").GetComponent<TextMeshProUGUI>();

        BuildInfo();



        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BuildInfo()
    {
        build.text = gameInfo.Name + " - v." + gameInfo.Version + " - " + gameInfo.Info + " - by: " + gameInfo.Company;
    }
}
