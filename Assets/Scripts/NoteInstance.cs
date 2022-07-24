using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{

    [SerializeField] notegenerator noteGenerator = default;
    public void NoteEvent()
    {
        Debug.Log("音がなるよ");
        noteGenerator.SpawnNote();
    }
}
