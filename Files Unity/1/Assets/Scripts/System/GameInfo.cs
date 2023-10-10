using UnityEngine;

internal class GameInfo : MonoBehaviour
{
    [SerializeField] private string gameName = "Default Project";
    [SerializeField] private string version = "0.01 pre-alpha";
    [SerializeField] private string company = "Infinity Ga∞es";
    [SerializeField] private string info;

    internal string Name { get => gameName; private set => gameName = value; }
    internal string Version { get => version; private set => version = value; }
    internal string Company { get => company; private set => company = value; }
    internal string Info { get => info; private set => info = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
