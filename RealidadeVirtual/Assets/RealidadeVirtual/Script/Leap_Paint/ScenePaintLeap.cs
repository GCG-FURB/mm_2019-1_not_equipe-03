using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePaintLeap : MonoBehaviour, Persistent<ScenePersistData>
{
    public static ScenePaintLeap Instance;
    private GameObject scene;
    public TrailRenderer OriginalTrail;

    public List<TrailRenderer> Trails = new List<TrailRenderer>();

   void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void AddTrailRenderer(TrailRenderer trail) {
        this.Trails.Add(trail);
    }

    public ScenePersistData GetPersistData()
    {
        ScenePersistData data = new ScenePersistData();
        data.ObjectList = new TrailData[Trails.Count];

        int i = 0;
            
        Trails.ForEach(trail =>
        {
            TrailData objectData = new TrailData();

            Vector3[] positions = new Vector3[trail.positionCount];
            int max = trail.GetPositions(positions);
            objectData.points = new TrailPoint[max];
            for (int j = 0; j < max; j++) {
                TrailPoint point = new TrailPoint();
                point.LocalPosX = positions[j].x;
                point.LocalPosY = positions[j].y;
                point.LocalPosZ = positions[j].z;
                objectData.points[j] = point;
            }

            objectData.LocalRotX = trail.transform.localRotation.x;
            objectData.LocalRotY = trail.transform.localRotation.y;
            objectData.LocalRotZ = trail.transform.localRotation.z;
            objectData.LocalRotW = trail.transform.localRotation.w;

            objectData.LocalScaX = trail.transform.localScale.x;
            objectData.LocalScaY = trail.transform.localScale.y;
            objectData.LocalScaZ = trail.transform.localScale.z;

            objectData.LocalPosX = trail.transform.localPosition.x;
            objectData.LocalPosY = trail.transform.localPosition.y;
            objectData.LocalPosZ = trail.transform.localPosition.z;

            data.ObjectList[i] = objectData;
            i++;
        });

        return data;
    }

    public void LoadPersistData(ScenePersistData data)
    {

        Dictionary<int, GameObject> AnimationMap = new Dictionary<int, GameObject>();
        
        foreach (var obj in data.ObjectList)
            {

            
            GameObject render = new GameObject();
            render.AddComponent(typeof(TrailRenderer));
            render.GetComponent<TrailRenderer>().time = 1000000000f;
            render.GetComponent<TrailRenderer>().minVertexDistance = 0;
            AnimationCurve curve = new AnimationCurve();
             curve.AddKey(0.02f, 0.02f);
            render.GetComponent<TrailRenderer>().widthCurve = curve;
            render.GetComponent<TrailRenderer>().widthMultiplier = 0.5f;
            render.GetComponent<TrailRenderer>().material = OriginalTrail.material;
            Instantiate(render);
            Debug.Log(render.transform);
            render.transform.localRotation = new Quaternion(obj.LocalRotX, obj.LocalRotY, obj.LocalRotZ, obj.LocalRotW);
            render.transform.localScale = new Vector3(obj.LocalScaX, obj.LocalScaY, obj.LocalScaZ);
            render.transform.localPosition = new Vector3(obj.LocalPosX, obj.LocalPosY, obj.LocalPosZ);

            for (int i = 0; i < obj.points.Length; i++) {
                TrailPoint point = obj.points[i];
                render.GetComponent<TrailRenderer>().AddPosition(new Vector3(point.LocalPosX, point.LocalPosY, point.LocalPosZ));
            }

            
        }

    }
}