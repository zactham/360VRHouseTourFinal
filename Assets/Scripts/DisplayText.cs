using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour
{
    //Takes in a game object and toggles
    public void displayText(GameObject TextMesh)
    {
        TextMesh.SetActive(!TextMesh.activeSelf);
    }

    public void hideText(GameObject TextMesh)
    {
        TextMesh.SetActive(false);

    }
}
