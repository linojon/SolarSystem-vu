using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    public float rotationRate = 1f; // local "day" in earth days
    private MasterControls controls;

    void Start()
    {
        GameObject controller = GameObject.Find("GameController");
        controls = controller.GetComponent<MasterControls>();
    }

    void Update () {
        float deltaAngle = (360.0f / (rotationRate * controls.gametimePerDay)) * Time.deltaTime;
        transform.Rotate( 0f, deltaAngle, 0f);
	}
}
