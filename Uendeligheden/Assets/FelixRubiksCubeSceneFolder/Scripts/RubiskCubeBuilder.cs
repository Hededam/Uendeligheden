using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubiskCubeBuilder : MonoBehaviour
{
    [SerializeField] private GameObject RubisksPiece;

    [SerializeField]private int cubeX = 3;
    [SerializeField]private int cubeY = 3;
    [SerializeField]private int cubeZ = 3;

    // Start is called before the first frame update
    void Start()
    {
        for (var cubeXI = 0; cubeXI < cubeX; cubeXI++)
        {
            for (var cubeYI = 0; cubeYI < cubeY; cubeYI++)
            {
                for (var cubeZI = 0; cubeZI < cubeZ; cubeZI++)
                {
                    if ((cubeXI == 0 || cubeXI == cubeX - 1) || (cubeYI == 0 || cubeYI == cubeY - 1) || (cubeZI == 0 || cubeZI == cubeZ - 1))
                    {
                        Instantiate(RubisksPiece, new Vector3(-cubeX / 2 + cubeXI, -cubeY / 2 + cubeYI, -cubeZ / 2 + cubeZI), Quaternion.identity,transform);
                    }
                }
            }
        }
    }

    public Vector3 returnSize()
    {
        return new Vector3(cubeX, cubeY, cubeZ);
    }
}
