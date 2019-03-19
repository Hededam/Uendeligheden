using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    [SerializeField] private GameObject[] sides = new GameObject[6];

    public bool changeSide(int side)
    {
        GameObject cSide;
        switch (side)
        {
            case 0:
                cSide = sides[0];
                cSide.SetActive(!cSide.activeSelf);
                return true;
            case 1:
                cSide = sides[1];
                cSide.SetActive(!cSide.activeSelf);
                return true;
            case 2:
                cSide = sides[2];
                cSide.SetActive(!cSide.activeSelf);
                return true;
            case 3:
                cSide = sides[3];
                cSide.SetActive(!cSide.activeSelf);
                return true;
            case 4:
                cSide = sides[4];
                cSide.SetActive(!cSide.activeSelf);
                return true;
            case 5:
                cSide = sides[5];
                cSide.SetActive(!cSide.activeSelf);
                return true;
            default:
                return false;
        }
    }
}
