using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionRecorder : MonoBehaviour
{
    private bool isRecording = false;
    private List<Vector3[]> recordedFrames;

    void Start()
    {
        recordedFrames = new List<Vector3[]>();
    }

    public void RecordData(Vector3[] currentFrameData)
    {
        if (isRecording)
        {
            recordedFrames.Add(currentFrameData);
        }
    }

    // return whether recording
    public bool IsRecording
    {
        get { return isRecording; }
    }
    public void ToggleRecording()
    {
        isRecording = !isRecording;
        Debug.Log(isRecording ? "Start Motion Recording" : "End Motion Recording");
        if (!isRecording)
        {
            ProcessRecordedData();
        }
    }

    private void ProcessRecordedData()
    {
        // 处理或输出记录的数据
        recordedFrames.Clear(); // 清除数据以备下次记录
    }
}

