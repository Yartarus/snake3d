using System.Collections;
using UnityEngine;

public static class ExtensionMethods
{

    public static Vector3 Round(this Vector3 vector3, int decimalPlaces = 2) // By Yamaraj
    {
        float multiplier = 1;
        for (int i = 0; i < decimalPlaces; i++)
        {
            multiplier *= 10f;
        }
        return new Vector3(
            Mathf.Round(vector3.x * multiplier) / multiplier,
            Mathf.Round(vector3.y * multiplier) / multiplier,
            Mathf.Round(vector3.z * multiplier) / multiplier);
    }

}
