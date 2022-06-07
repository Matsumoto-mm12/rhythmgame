using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{
    //‰º‚É—‚¿‚é
    // TODO: —‚¿‚é‘¬“x‚ğ‹È‚Æ”»’èêŠ‚Æ‚Ì‹——£‚©‚çİ’è‚·‚é•K—v‚ª‚ ‚é
    float speed;

    private void Start()
    {
        speed = 20;
    }
    void Update()
    {
        transform.Translate(0, -20 * Time.deltaTime, 0);
    }
}
