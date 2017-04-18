using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlanetMarkerHandler : MonoBehaviour {

    public List<Transform> bodies = new List<Transform>();

    private VuMarkManager mVuMarkManager;
    private PlanetView planetView;

    // Use this for initialization
    void Start () {
        // get the Planet View component
        planetView = GetComponent<PlanetView>();

        // register callbacks to VuMark Manager
        mVuMarkManager = TrackerManager.Instance.GetStateManager().GetVuMarkManager();
        mVuMarkManager.RegisterVuMarkDetectedCallback(OnVuMarkDetected);

    }

    public void OnVuMarkDetected(VuMarkTarget target)
    {
        int id = markIdToInt(target.InstanceId.StringValue);
        //Debug.Log("New VuMark: " + id);
        Debug.Log("Changing view: " + bodies[id].name);
        planetView.planet = bodies[id];
    }


    private int markIdToInt(string str)
    {
        return int.Parse(str.Substring(6, 2));
    }

}
