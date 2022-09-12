using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int number)
    {
        value += number;
    }
    
}