// v1.11
using UnityEngine;
using System.Collections.Generic;
using System;

public static class Tools {
    public static List<int> idlist = new List<int>();
    private static System.Random random = new System.Random();

    public static void Shuffle<T>(this IList<T> list) {
        System.Random rng = new System.Random();
        int n = list.Count;
        while (n > 1) {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
    public static int UniqueID() {
        if (idlist.Count == 0) {
            idlist.Add(0);
        } else {
            idlist.Add(idlist[idlist.Count - 1] + 1);
        }
        return idlist[idlist.Count - 1];
    }
    public static Timer SetTimeout(Action run, float time) {
        GameObject timerTempObject = new GameObject("Timer");
        Timer timer = timerTempObject.AddComponent<Timer>();
        timer.SetTimeout(run, time);
        return timer;
    }

    public static int GetRandomInt(int min, int max) {
        return random.Next(min, max + 1);
    }
}
