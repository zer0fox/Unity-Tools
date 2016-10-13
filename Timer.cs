// v1.1
using UnityEngine;
using System;

public class Timer : MonoBehaviour {
    /* example
		Tools.setTimeout(delegate(){
			print("test");
		}, 10.0f); // 10 seconds
	*/
    private Action run = null;
    private float time;

    // tools creates a game object to add this script and then used the update to wait for the seconds to run
    public void SetTimeout(Action run, float time) {
        this.time = Time.time + time;
        this.run = run;
    }

    void Update() {
        if (time <= Time.time && run != null) {
            run();
            Destroy(gameObject);
        }
    }

    // clears this object before the timer is done
    public void Clear() {
        Destroy(gameObject);
    }
}
