
using UnityEngine;

public class IfStatments : MonoBehaviour
{
    public bool appleIsRipe, orangeIsRipe, peachIsRipe;

    void Start()
    {

        if (appleIsRipe)
        {
            print("Go Pick The Apple.");
        }
        else if (orangeIsRipe)
        {
            print("Go Pick The Orange.");
        }
        else if (peachIsRipe)
        {
            print("Go Pick The Peach.");
        }
        else
        {
            print("Nothing is Ripe.");
        }
    }
}