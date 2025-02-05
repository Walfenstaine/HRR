using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Predmet : MonoBehaviour
{
    public Data data;
    public AudioClip clip;
    public Sprite sprite;
    [SerializeField] private Language text;
    public int index;
    public GameObject predmet;
    public void Onpredmet()
    {
        Inventar.rid.OnIndex(index);
        Inventar.rid.OnImage(sprite);
        if (data.language == "ru")
        {
            Inventar.rid.OnText(text.ru);
            SubTitres.rid.MaSage(text.ru);
        }
        else
        {
            Inventar.rid.OnText(text.en);
            SubTitres.rid.MaSage(text.en);
        }
        Instantiate(predmet, Vector3.zero, Quaternion.identity);
        SoundPlayer.regit.Play(clip,1);
        Destroy(gameObject);
    }
}
