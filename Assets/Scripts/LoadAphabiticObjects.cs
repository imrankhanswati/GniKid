using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadAphabiticObjects : MonoBehaviour
{
    public SceneObjectType[] alphabitsObjectArray = new SceneObjectType[26];


    public string LoadNextAlphabit(string currentAlpha)
    {
        if (GetIndex(currentAlpha)==25)
        {
            return alphabitsObjectArray[0].alphabetText;
        }
        return alphabitsObjectArray[GetIndex(currentAlpha) + 1].alphabetText;
    }

    public string LoadPreivousAlphabit(string currentAlpha)
    {
        if (GetIndex(currentAlpha) == 0)
        {
            return alphabitsObjectArray[25].alphabetText;
        }
        else
        {
            return alphabitsObjectArray[GetIndex(currentAlpha) - 1].alphabetText;
        }
    }
    public SceneObjectType LoadCurrentCanvasObject(string currentAlpha)
    {
        return alphabitsObjectArray[GetIndex(currentAlpha)];
    }
    public SceneObjectType LoadNextCanvasObject(string currentAlpha)
    {
        return alphabitsObjectArray[GetIndex(currentAlpha) + 1];
    }

    public SceneObjectType LoadPreivousCanvasObject(string currentAlpha)
    {
        return alphabitsObjectArray[GetIndex(currentAlpha) - 1];
    }

    private int GetIndex(string alpha)
    {
        switch (alpha)
        {
            case "A":
                return 0;
            case "B":
                return 1;
            case "C":
                return 2;
            case "D":
                return 3;
            case "E":
                return 4;
            case "F":
                return 5;
            case "G":
                return 6;
            case "H":
                return 7;
            case "I":
                return 8;
            case "J":
                return 9;
            case "K":
                return 10;
            case "L":
                return 11;
            case "M":
                return 12;
            case "N":
                return 13;
            case "O":
                return 14;
            case "P":
                return 15;
            case "Q":
                return 16;
            case "R":
                return 17;
            case "S":
                return 18;
            case "T":
                return 19;
            case "U":
                return 20;
            case "V":
                return 21;
            case "W":
                return 22;
            case "X":
                return 23;
            case "Y":
                return 24;
            default:
                return 25;

        }
    }

}

[System.Serializable]
public class SceneObjectType
{
    public string alphabetText;
    public Sprite itemImge;
    public string itemText;
}
