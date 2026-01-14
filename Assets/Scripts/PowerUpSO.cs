using UnityEngine;

[CreateAssetMenu(fileName = "PowerUpSO", menuName = "Scriptable Objects/PowerUpSO")]
public class PowerUpSO : ScriptableObject
{
    [SerializeField] string type;
    [SerializeField] float value = 0f;
    [SerializeField] float time;
    
    public string getType()
    {
        return type;
    }

    public float getValue()
    {
        return value;
    }

    public float getTime()
    {
        return time;
    }
}
