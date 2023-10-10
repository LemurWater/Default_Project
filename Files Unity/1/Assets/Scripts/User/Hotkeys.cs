using UnityEngine;

public class Hotkeys : MonoBehaviour
{
    [Header("Menu - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    [SerializeField] private KeyCode menuMain = KeyCode.Escape;

    [Space(15)]
    [Header("Default - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    [SerializeField] private KeyCode primaryClick = KeyCode.Mouse0;
    [SerializeField] private KeyCode secondaryClick = KeyCode.Mouse1;



    internal KeyCode PrimaryClick { get => primaryClick; private set => primaryClick = value; }
    internal KeyCode SecondaryClick { get => secondaryClick; private set => secondaryClick = value; }
    internal KeyCode MenuMain { get => menuMain; private set => menuMain = value; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
