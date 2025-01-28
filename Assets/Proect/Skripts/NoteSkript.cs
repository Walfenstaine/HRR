using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSkript : MonoBehaviour {
    public Data data;
    [SerializeField] private Language language;
    public AudioClip clip;
    public void Rider()
    {
        SoundPlayer.regit.Play(clip,1);
        if (data.language == "ru")
        {
            NoteRider.regit.Noting(language.ru);
        }
        else
        {
            NoteRider.regit.Noting(language.en);
        }
    }
}
