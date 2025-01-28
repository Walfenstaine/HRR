using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameInterfase : MonoBehaviour
{
    [SerializeField] private Language lvl;
    public Text lvlNum;
    public Slider slider;
    public Data data;

    void Update()
    {
        Muwer.rid.sensitivity = 1;
      
    }
}
