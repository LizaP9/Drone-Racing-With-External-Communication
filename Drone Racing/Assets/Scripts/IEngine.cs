using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public interface IEngine
    {
        // Start is called before the first frame update
        void InitEngine();

        // Update is called once per frame
        void UpdateEngine(Rigidbody rb, IP_Drone_Inputs input);

    }

}