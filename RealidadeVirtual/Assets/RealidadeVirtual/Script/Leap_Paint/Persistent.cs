using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Persistent<T>
{

    T GetPersistData();

    void LoadPersistData(T data);

}
