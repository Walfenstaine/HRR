using UnityEngine;

[CreateAssetMenu(fileName = "Replic", menuName = "ScriptableObjects/Replics", order = 3)]
public class Replic : ScriptableObject
{
    [System.Serializable]
    public class Replics
    {
        [field: TextArea(5, 5)]
        [field: SerializeField] public string ru { get; private set; }
        [field: TextArea(5, 5)]
        [field: SerializeField] public string en { get; private set; }
    }
    public Replics[] nodes;
}
