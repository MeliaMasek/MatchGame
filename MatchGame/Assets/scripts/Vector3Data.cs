using UnityEngine;

[CreateAssetMenu]

//Can't figure out how to impement vector3, not sure what the right code is to use it 

public class Vector3Data : ScriptableObject
{
    public float value;

    public void UpdateValue(Vector3 num)

    {
        value += Vector3;
    }

    public float Vector3 { get; set; }
}