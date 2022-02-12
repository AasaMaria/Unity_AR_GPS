using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPSText : MonoBehaviour {
    public Text coordinates;

    public void Update()
    {
        coordinates.text = "Lat:" + GPS.Instance.latitude.ToString() + "   Long:" + GPS.Instance.longitude.ToString();
    }
}
