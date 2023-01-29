using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut_Scene28 : MonoBehaviour
{
    public GameObject CenterObj;
    private OVRScreenFade OFade;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FadeOut()
    {
        OFade = CenterObj.transform.GetComponent<OVRScreenFade>();
        //OFade.FadeOut();
        OFade.fadeTime = 5f;
        //OFade.FadeOut();
        OFade.FadeOut();
    }
}
